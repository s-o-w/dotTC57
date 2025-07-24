namespace TC57CIM.Semantic.Attributes
{
    /// <summary>
    /// Indicates that a property maps to an RDF property in the ontology
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class RdfPropertyAttribute : Attribute
    {
        /// <summary>
        /// The URI of the RDF property
        /// </summary>
        public string Uri { get; }

        /// <summary>
        /// Creates a new RdfPropertyAttribute
        /// </summary>
        public RdfPropertyAttribute(string uri)
        {
            Uri = uri;
        }
    }
}