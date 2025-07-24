using VDS.RDF.Ontology;

namespace TC57CIM.Semantic.Services
{
    /// <summary>
    /// Provides access to ontology-related functionality
    /// </summary>
    public interface IOntologyService
    {
        /// <summary>
        /// Gets the loaded ontology graph
        /// </summary>
        OntologyGraph OntologyGraph { get; }

        /// <summary>
        /// Gets a class from the ontology by URI
        /// </summary>
        OntologyClass GetClass(string uri);

        /// <summary>
        /// Loads an ontology from a file
        /// </summary>
        void LoadOntology(string filePath);

        /// <summary>
        /// Loads an ontology from a string
        /// </summary>
        void LoadOntologyFromString(string ontologyContent, string baseUri = null);

        /// <summary>
        /// Validates if a relationship between two classes is valid according to the ontology
        /// </summary>
        bool ValidateRelationship(string sourceClassUri, string targetClassUri, string relationshipUri);

        /// <summary>
        /// Gets all properties available for a class
        /// </summary>
        IEnumerable<OntologyProperty> GetPropertiesForClass(string classUri);

        /// <summary>
        /// Executes a SPARQL query against the ontology
        /// </summary>
        object ExecuteQuery(string sparqlQuery);
    }
}