namespace TC57CIM.Semantic.Attributes
{
    /// <summary>
    /// Indicates that a class maps to an RDF class in the ontology
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class RdfClassAttribute : Attribute
    {
        /// <summary>
        /// The URI of the RDF class
        /// </summary>
        public string Uri { get; }

        /// <summary>
        /// Creates a new RdfClassAttribute
        /// </summary>
        public RdfClassAttribute(string uri)
        {
            Uri = uri;
        }
    }
}