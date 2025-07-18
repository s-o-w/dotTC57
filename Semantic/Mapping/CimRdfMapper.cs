using System.Reflection;
using TC57CIM.IEC61970.Base.Core;
using TC57CIM.Semantic.Attributes;
using TC57CIM.Semantic.Ontology;
using VDS.RDF;

namespace TC57CIM.Semantic.Mapping
{
    /// <summary>
    /// Maps CIM objects to RDF and vice versa
    /// </summary>
    public class CimRdfMapper
    {
        private readonly OntologyLoader _ontologyLoader;

        /// <summary>
        /// Creates a new CimRdfMapper
        /// </summary>
        public CimRdfMapper(OntologyLoader ontologyLoader)
        {
            _ontologyLoader = ontologyLoader;
        }

        /// <summary>
        /// Maps a CIM object to an RDF graph
        /// </summary>
        public IGraph MapToRdf(IdentifiedObject cimObject)
        {
            var graph = new Graph();
            CimOntologyNamespaces.AddNamespacesToGraph(graph);

            // Create resource URI for this object
            Uri objectUri = CreateResourceUri(cimObject);

            // Add type information
            AddTypeTriple(graph, objectUri, cimObject);

            // Add base properties (mRID, name, description, etc.)
            AddBaseProperties(graph, objectUri, cimObject);

            // Add other properties from the object
            AddObjectProperties(graph, objectUri, cimObject);

            return graph;
        }

        /// <summary>
        /// Maps a collection of CIM objects to an RDF graph
        /// </summary>
        public IGraph MapToRdf(IEnumerable<IdentifiedObject> cimObjects)
        {
            var graph = new Graph();
            CimOntologyNamespaces.AddNamespacesToGraph(graph);

            foreach (var obj in cimObjects)
            {
                // Create resource URI for this object
                Uri objectUri = CreateResourceUri(obj);

                // Add type information
                AddTypeTriple(graph, objectUri, obj);

                // Add base properties
                AddBaseProperties(graph, objectUri, obj);

                // Add other properties
                AddObjectProperties(graph, objectUri, obj);
            }

            return graph;
        }

        private Uri CreateResourceUri(IdentifiedObject obj)
        {
            // Use the mRID as a unique identifier in the URI
            return new Uri($"{CimOntologyNamespaces.CIM}{obj.GetType().Name}_{obj.mRID}");
        }

        private void AddTypeTriple(IGraph graph, Uri objectUri, IdentifiedObject obj)
        {
            // Get RDF class attribute if present
            var classAttr = obj.GetType().GetCustomAttribute<RdfClassAttribute>();
            string typeUri = classAttr?.Uri ?? $"{CimOntologyNamespaces.CIM}{obj.GetType().Name}";

            // Add the type triple
            graph.Assert(
                graph.CreateUriNode(objectUri),
                graph.CreateUriNode(new Uri(CimOntologyNamespaces.RDF + "type")),
                graph.CreateUriNode(new Uri(typeUri))
            );
        }

        private void AddBaseProperties(IGraph graph, Uri objectUri, IdentifiedObject obj)
        {
            var subjectNode = graph.CreateUriNode(objectUri);

            // Add mRID
            graph.Assert(
                subjectNode,
                graph.CreateUriNode(new Uri(CimOntologyNamespaces.CIM + "mRID")),
                graph.CreateLiteralNode(obj.mRID.ToString())
            );

            // Add name if present
            if (!string.IsNullOrEmpty(obj.name))
            {
                graph.Assert(
                    subjectNode,
                    graph.CreateUriNode(new Uri(CimOntologyNamespaces.CIM + "name")),
                    graph.CreateLiteralNode(obj.name)
                );
            }

            // Add description if present
            if (!string.IsNullOrEmpty(obj.description))
            {
                graph.Assert(
                    subjectNode,
                    graph.CreateUriNode(new Uri(CimOntologyNamespaces.CIM + "description")),
                    graph.CreateLiteralNode(obj.description)
                );
            }
        }

        private void AddObjectProperties(IGraph graph, Uri objectUri, object obj)
        {
            var subjectNode = graph.CreateUriNode(objectUri);
            var objType = obj.GetType();

            // Process all properties of the object
            var properties = objType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var prop in properties)
            {
                // Skip properties already handled in AddBaseProperties
                if (prop.Name == "mRID" || prop.Name == "name" || prop.Name == "description")
                    continue;

                var value = prop.GetValue(obj);
                if (value != null)
                {
                    // Get RDF property attribute if present
                    var propAttr = prop.GetCustomAttribute<RdfPropertyAttribute>();
                    string predicateUri = propAttr?.Uri ?? $"{CimOntologyNamespaces.CIM}{prop.Name}";

                    AddPropertyTriple(graph, subjectNode, new Uri(predicateUri), value);
                }
            }

            // Process public fields
            var fields = objType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            foreach (var field in fields)
            {
                var value = field.GetValue(obj);
                if (value != null)
                {
                    // Get RDF property attribute if present
                    var fieldAttr = field.GetCustomAttribute<RdfPropertyAttribute>();
                    string predicateUri = fieldAttr?.Uri ?? $"{CimOntologyNamespaces.CIM}{field.Name}";

                    AddPropertyTriple(graph, subjectNode, new Uri(predicateUri), value);
                }
            }
        }

        private void AddPropertyTriple(IGraph graph, INode subject, Uri predicateUri, object value)
        {
            var predicateNode = graph.CreateUriNode(predicateUri);

            // Handle different types of values
            if (value is IdentifiedObject relatedObject)
            {
                // Reference to another CIM object - create an object link
                Uri objectUri = CreateResourceUri(relatedObject);
                graph.Assert(subject, predicateNode, graph.CreateUriNode(objectUri));
            }
            else if (value is string strValue)
            {
                graph.Assert(subject, predicateNode, graph.CreateLiteralNode(strValue));
            }
            else if (value is bool boolValue)
            {
                graph.Assert(subject, predicateNode, graph.CreateLiteralNode(boolValue.ToString(),
                    new Uri(CimOntologyNamespaces.XSD + "boolean")));
            }
            else if (value is int intValue)
            {
                graph.Assert(subject, predicateNode, graph.CreateLiteralNode(intValue.ToString(),
                    new Uri(CimOntologyNamespaces.XSD + "integer")));
            }
            else if (value is double || value is float || value is decimal)
            {
                graph.Assert(subject, predicateNode, graph.CreateLiteralNode(value.ToString(),
                    new Uri(CimOntologyNamespaces.XSD + "decimal")));
            }
            else if (value is DateTime dateValue)
            {
                graph.Assert(subject, predicateNode, graph.CreateLiteralNode(dateValue.ToString("o"),
                    new Uri(CimOntologyNamespaces.XSD + "dateTime")));
            }
            else if (value is Guid guidValue)
            {
                graph.Assert(subject, predicateNode, graph.CreateLiteralNode(guidValue.ToString()));
            }
            else if (value is Enum enumValue)
            {
                graph.Assert(subject, predicateNode, graph.CreateLiteralNode(enumValue.ToString()));
            }
            else
            {
                // Default fallback for other types
                graph.Assert(subject, predicateNode, graph.CreateLiteralNode(value.ToString()));
            }
        }
    }
}