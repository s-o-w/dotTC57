using System.Text;
using TC57CIM.IEC61970.Base.Core;
using TC57CIM.Semantic.Mapping;
using VDS.RDF;
using VDS.RDF.Writing;

namespace TC57CIM.Semantic.Services
{
    /// <summary>
    /// Implementation of the IRdfMappingService
    /// </summary>
    public class RdfMappingService : IRdfMappingService
    {
        private readonly CimRdfMapper _mapper;

        /// <summary>
        /// Creates a new RdfMappingService
        /// </summary>
        public RdfMappingService(CimRdfMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// Maps a CIM object to an RDF graph
        /// </summary>
        public IGraph MapToRdf(IdentifiedObject cimObject)
        {
            return _mapper.MapToRdf(cimObject);
        }

        /// <summary>
        /// Maps a collection of CIM objects to an RDF graph
        /// </summary>
        public IGraph MapToRdf(IEnumerable<IdentifiedObject> cimObjects)
        {
            return _mapper.MapToRdf(cimObjects);
        }

        /// <summary>
        /// Exports an RDF graph to RDF/XML format
        /// </summary>
        public string ExportToRdfXml(IGraph graph)
        {
            return ExportGraph(graph, new RdfXmlWriter());
        }

        /// <summary>
        /// Exports an RDF graph to Turtle format
        /// </summary>
        public string ExportToTurtle(IGraph graph)
        {
            return ExportGraph(graph, new CompressingTurtleWriter());
        }

        /// <summary>
        /// Exports an RDF graph to JSON-LD format
        /// </summary>
        public string ExportToJsonLd(IGraph graph)
        {
            var sb = new StringBuilder();
            using (var sw = new System.IO.StringWriter(sb))
            {
                try
                {
                    var store = new TripleStore();
                    store.Add(graph);
                    var jsonLdWriter = new VDS.RDF.Writing.JsonLdWriter();
                    jsonLdWriter.Save(store, sw);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error using JsonLdWriter: {ex.Message}");
                }
            }
            return sb.ToString();
        }

        private string ExportGraph(IGraph graph, IRdfWriter writer)
        {
            var sb = new StringBuilder();
            using (var sw = new System.IO.StringWriter(sb))
            {
                writer.Save(graph, sw);
            }
            return sb.ToString();
        }
    }
}