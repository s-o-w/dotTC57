using TC57CIM.IEC61970.Base.Core;
using VDS.RDF;

namespace TC57CIM.Semantic.Services
{
    /// <summary>
    /// Service for mapping between CIM objects and RDF
    /// </summary>
    public interface IRdfMappingService
    {
        /// <summary>
        /// Maps a CIM object to an RDF graph
        /// </summary>
        IGraph MapToRdf(IdentifiedObject cimObject);

        /// <summary>
        /// Maps a collection of CIM objects to an RDF graph
        /// </summary>
        IGraph MapToRdf(IEnumerable<IdentifiedObject> cimObjects);

        /// <summary>
        /// Exports an RDF graph to RDF/XML format
        /// </summary>
        string ExportToRdfXml(IGraph graph);

        /// <summary>
        /// Exports an RDF graph to Turtle format
        /// </summary>
        string ExportToTurtle(IGraph graph);

        /// <summary>
        /// Exports an RDF graph to JSON-LD format
        /// </summary>
        string ExportToJsonLd(IGraph graph);
    }
}