using System.Reflection;
using VDS.RDF.Ontology;

namespace TC57CIM.Semantic.Ontology
{
    /// <summary>
    /// Loads and manages OWL ontologies for the CIM model
    /// </summary>
    public class OntologyLoader
    {
        /// <summary>
        /// The ontology graph
        /// </summary>
        private readonly OntologyGraph _ontologyGraph;

        /// <summary>
        /// Gets the loaded ontology graph
        /// </summary>
        public OntologyGraph OntologyGraph => _ontologyGraph;

        /// <summary>
        /// Creates a new OntologyLoader and loads the default CIM ontology
        /// </summary>
        public OntologyLoader()
        {
            _ontologyGraph = new OntologyGraph();
            LoadDefaultOntology();
        }

        /// <summary>
        /// Loads an ontology from an embedded resource
        /// </summary>
        private void LoadDefaultOntology()
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                string resourceName = "dotTC57.Resources.cim-owl-ontology.owl";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                {
                    if (stream != null)
                    {
                        // Fix: Wrap the stream in a StreamReader to match the expected parameter type
                        using (var streamReader = new StreamReader(stream))
                        {
                            var parser = new VDS.RDF.Parsing.RdfXmlParser();
                            parser.Load(_ontologyGraph, streamReader);
                        }
                    }
                    else
                    {
                        throw new FileNotFoundException($"Could not find embedded resource: {resourceName}");
                    }
                }
            }
            catch (Exception ex)
            {
                // In a production environment, consider logging this error
                // For now, create an empty ontology
                Console.WriteLine($"Error loading ontology: {ex.Message}");
            }
        }

        /// <summary>
        /// Loads an ontology from a file
        /// </summary>
        public void LoadFromFile(string filePath)
        {
            // Fix: Use RdfXmlParser to load from file
            var parser = new VDS.RDF.Parsing.RdfXmlParser();
            parser.Load(_ontologyGraph, filePath);
        }

        /// <summary>
        /// Loads an ontology from a string
        /// </summary>
        public void LoadFromString(string ontologyContent, string baseUri = null)
        {
            using var stringReader = new StringReader(ontologyContent);

            // Fix: Use a parser to load from StringReader
            var parser = new VDS.RDF.Parsing.RdfXmlParser();
            parser.Load(_ontologyGraph, stringReader);
        }

        /// <summary>
        /// Gets a class from the ontology by URI
        /// </summary>
        public OntologyClass GetClass(string uri)
        {
            return _ontologyGraph.OwlClasses.FirstOrDefault(c =>
                c.Resource.ToString().Equals(uri, StringComparison.OrdinalIgnoreCase));
        }
    }
}