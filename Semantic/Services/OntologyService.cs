using TC57CIM.Semantic.Ontology;
using VDS.RDF.Ontology;

namespace TC57CIM.Semantic.Services
{
    /// <summary>
    /// Implementation of the IOntologyService
    /// </summary>
    public class OntologyService : IOntologyService
    {
        private readonly OntologyLoader _ontologyLoader;

        /// <summary>
        /// Gets the loaded ontology graph
        /// </summary>
        public OntologyGraph OntologyGraph => _ontologyLoader.OntologyGraph;

        /// <summary>
        /// Creates a new OntologyService
        /// </summary>
        public OntologyService()
        {
            _ontologyLoader = new OntologyLoader();
        }

        /// <summary>
        /// Gets a class from the ontology by URI
        /// </summary>
        public OntologyClass GetClass(string uri)
        {
            return _ontologyLoader.GetClass(uri);
        }

        /// <summary>
        /// Loads an ontology from a file
        /// </summary>
        public void LoadOntology(string filePath)
        {
            _ontologyLoader.LoadFromFile(filePath);
        }

        /// <summary>
        /// Loads an ontology from a string
        /// </summary>
        public void LoadOntologyFromString(string ontologyContent, string baseUri = null)
        {
            _ontologyLoader.LoadFromString(ontologyContent, baseUri);
        }

        /// <summary>
        /// Validates if a relationship between two classes is valid according to the ontology
        /// </summary>
        public bool ValidateRelationship(string sourceClassUri, string targetClassUri, string relationshipUri)
        {
            var sourceClass = GetClass(sourceClassUri);
            var targetClass = GetClass(targetClassUri);

            if (sourceClass == null || targetClass == null)
                return false;

            // Check if relationship is defined for source class
            var relationships = OntologyGraph.OwlProperties
                .Where(p => p.Resource.ToString().Equals(relationshipUri, StringComparison.OrdinalIgnoreCase));

            // Get domain and range restrictions
            foreach (var relationship in relationships)
            {
                // Check domain (class that can have this property)
                var domains = relationship.Domains;
                if (domains.Any() && !domains.Any(d => IsClassOrSubclass(sourceClass, d)))
                    return false;

                // Check range (allowed values for this property)
                var ranges = relationship.Ranges;
                if (ranges.Any() && !ranges.Any(r => IsClassOrSubclass(targetClass, r)))
                    return false;
            }

            return true;
        }

        private bool IsClassOrSubclass(OntologyClass cls, OntologyResource parent)
        {
            if (cls.Resource.ToString().Equals(parent.Resource.ToString(), StringComparison.OrdinalIgnoreCase))
                return true;

            // Check subclass hierarchy
            return cls.SuperClasses.Any(sc =>
                sc.Resource.ToString().Equals(parent.Resource.ToString(), StringComparison.OrdinalIgnoreCase) ||
                IsClassOrSubclass(cls, sc));
        }

        /// <summary>
        /// Gets all properties available for a class
        /// </summary>
        public IEnumerable<OntologyProperty> GetPropertiesForClass(string classUri)
        {
            var cls = GetClass(classUri);
            if (cls == null)
                return Enumerable.Empty<OntologyProperty>();

            // Get properties that have this class in their domain
            return OntologyGraph.OwlProperties
                .Where(p => p.Domains.Any(d =>
                    d.Resource.ToString().Equals(classUri, StringComparison.OrdinalIgnoreCase)));
        }

        /// <summary>
        /// Executes a SPARQL query against the ontology
        /// </summary>
        public object ExecuteQuery(string sparqlQuery)
        {
            //TODO - fix this to be more generic

            //var parser = new SparqlQueryParser();
            //var query = parser.ParseFromString(sparqlQuery);

            //var processor = new LeviathanQueryProcessor(OntologyGraph);
            //var results = processor.ProcessQuery(query);

            //if (results is SparqlResultSet resultSet)
            //    return resultSet;

            //if (results is IGraph resultGraph)
            //    return resultGraph;

            return null;
        }
    }
}