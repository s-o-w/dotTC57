using VDS.RDF;

namespace TC57CIM.Semantic.Ontology
{
    /// <summary>
    /// Common namespaces used in the CIM ontology
    /// </summary>
    public static class CimOntologyNamespaces
    {
        /// <summary>
        /// CIM base namespace
        /// </summary>
        public static readonly Uri CIM = new Uri("http://iec.ch/TC57/CIM#");

        /// <summary>
        /// CIM IEC61970 namespace
        /// </summary>
        public static readonly Uri CIM61970 = new Uri("http://iec.ch/TC57/61970-300#");

        /// <summary>
        /// CIM IEC61968 namespace
        /// </summary>
        public static readonly Uri CIM61968 = new Uri("http://iec.ch/TC57/61968-11#");

        /// <summary>
        /// RDF namespace
        /// </summary>
        public static readonly Uri RDF = new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#");

        /// <summary>
        /// RDFS namespace
        /// </summary>
        public static readonly Uri RDFS = new Uri("http://www.w3.org/2000/01/rdf-schema#");

        /// <summary>
        /// OWL namespace
        /// </summary>
        public static readonly Uri OWL = new Uri("http://www.w3.org/2002/07/owl#");

        /// <summary>
        /// XSD namespace
        /// </summary>
        public static readonly Uri XSD = new Uri("http://www.w3.org/2001/XMLSchema#");

        /// <summary>
        /// Adds standard namespaces to a graph
        /// </summary>
        public static void AddNamespacesToGraph(IGraph graph)
        {
            graph.NamespaceMap.AddNamespace("cim", CIM);
            graph.NamespaceMap.AddNamespace("cim61970", CIM61970);
            graph.NamespaceMap.AddNamespace("cim61968", CIM61968);
            graph.NamespaceMap.AddNamespace("rdf", RDF);
            graph.NamespaceMap.AddNamespace("rdfs", RDFS);
            graph.NamespaceMap.AddNamespace("owl", OWL);
            graph.NamespaceMap.AddNamespace("xsd", XSD);
        }
    }
}