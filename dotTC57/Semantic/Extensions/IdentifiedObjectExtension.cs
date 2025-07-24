using TC57CIM.IEC61970.Base.Core;
using TC57CIM.Semantic.Services;
using VDS.RDF;

namespace TC57CIM.Semantic.Extensions
{
    /// <summary>
    /// Extension methods for IdentifiedObject for semantic capabilities
    /// </summary>
    public static class IdentifiedObjectExtensions
    {
        /// <summary>
        /// Converts a CIM object to RDF
        /// </summary>
        public static IGraph ToRdf(this IdentifiedObject obj, IRdfMappingService mappingService)
        {
            return mappingService.MapToRdf(obj);
        }

        /// <summary>
        /// Converts a CIM object to RDF/XML
        /// </summary>
        public static string ToRdfXml(this IdentifiedObject obj, IRdfMappingService mappingService)
        {
            var graph = mappingService.MapToRdf(obj);
            return mappingService.ExportToRdfXml(graph);
        }

        /// <summary>
        /// Converts a CIM object to Turtle
        /// </summary>
        public static string ToTurtle(this IdentifiedObject obj, IRdfMappingService mappingService)
        {
            var graph = mappingService.MapToRdf(obj);
            return mappingService.ExportToTurtle(graph);
        }

        /// <summary>
        /// Converts a CIM object to JSON-LD
        /// </summary>
        public static string ToJsonLd(this IdentifiedObject obj, IRdfMappingService mappingService)
        {
            var graph = mappingService.MapToRdf(obj);
            return mappingService.ExportToJsonLd(graph);
        }

        /// <summary>
        /// Converts a collection of CIM objects to RDF
        /// </summary>
        public static IGraph ToRdf(this IEnumerable<IdentifiedObject> objects, IRdfMappingService mappingService)
        {
            return mappingService.MapToRdf(objects);
        }
    }
}