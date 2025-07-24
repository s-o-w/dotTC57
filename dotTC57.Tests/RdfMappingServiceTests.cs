using TC57CIM.Semantic.Services;
using TC57CIM.Semantic.Mapping;
using TC57CIM.IEC61970.Base.Core;
using VDS.RDF;
using TC57CIM.Semantic.Ontology;

namespace dotTC57.Tests.Semantic
{
    /// <summary>
    /// The rdf mapping service tests class
    /// </summary>
    public class RdfMappingServiceTests
    {
        /// <summary>
        /// The ontology loader
        /// </summary>
        private readonly OntologyLoader _ontologyLoader = new OntologyLoader();
        /// <summary>
        /// The dummy mapper class
        /// </summary>
        /// <seealso cref="CimRdfMapper"/>
        private class DummyMapper : CimRdfMapper
        {
          /// <summary>
          /// Initializes a new instance of the <see cref="DummyMapper"/> class
          /// </summary>
          /// <param name="ontologyLoader">The ontology loader</param>
          public DummyMapper(OntologyLoader ontologyLoader) : base(ontologyLoader)
          {
          }

          /// <summary>
          /// Maps the to rdf using the specified cim object
          /// </summary>
          /// <param name="cimObject">The cim object</param>
          /// <returns>The graph</returns>
          public override IGraph MapToRdf(IdentifiedObject cimObject)
          {
            var graph = new Graph();
            graph.Assert(graph.CreateUriNode("ex:subject"), graph.CreateUriNode("ex:predicate"), graph.CreateLiteralNode("object"));
            return graph;
          }

          /// <summary>
          /// Maps the to rdf using the specified cim objects
          /// </summary>
          /// <param name="cimObjects">The cim objects</param>
          /// <returns>The graph</returns>
          public override IGraph MapToRdf(IEnumerable<IdentifiedObject> cimObjects)
          {
            var graph = new Graph();
            graph.Assert(graph.CreateUriNode("ex:subject"), graph.CreateUriNode("ex:predicate"), graph.CreateLiteralNode("object"));
            return graph;
          }
        }

        /// <summary>
        /// Tests that map to rdf single object returns graph
        /// </summary>
        [Fact]
        public void MapToRdf_SingleObject_ReturnsGraph()
        {
            var service = new RdfMappingService(new DummyMapper(_ontologyLoader));
            var obj = new IdentifiedObject();
            var graph = service.MapToRdf(obj);
            Assert.NotNull(graph);
            Assert.NotEmpty(graph.Triples);
        }

        /// <summary>
        /// Tests that map to rdf multiple objects returns graph
        /// </summary>
        [Fact]
        public void MapToRdf_MultipleObjects_ReturnsGraph()
        {
            var service = new RdfMappingService(new DummyMapper(_ontologyLoader));
            var objs = new List<IdentifiedObject> { new IdentifiedObject(), new IdentifiedObject() };
            var graph = service.MapToRdf(objs);
            Assert.NotNull(graph);
            Assert.NotEmpty(graph.Triples);
        }

        /// <summary>
        /// Tests that export to rdf xml returns string
        /// </summary>
        [Fact]
        public void ExportToRdfXml_ReturnsString()
        {
            var service = new RdfMappingService(new DummyMapper(_ontologyLoader));
            var graph = service.MapToRdf(new IdentifiedObject());
            var rdfXml = service.ExportToRdfXml(graph);
            Assert.False(string.IsNullOrWhiteSpace(rdfXml));
        }

        /// <summary>
        /// Tests that export to turtle returns string
        /// </summary>
        [Fact]
        public void ExportToTurtle_ReturnsString()
        {
            var service = new RdfMappingService(new DummyMapper(_ontologyLoader));
            var graph = service.MapToRdf(new IdentifiedObject());
            var turtle = service.ExportToTurtle(graph);
            Assert.False(string.IsNullOrWhiteSpace(turtle));
        }

        /// <summary>
        /// Tests that export to json ld returns string
        /// </summary>
        [Fact]
        public void ExportToJsonLd_ReturnsString()
        {
            var service = new RdfMappingService(new DummyMapper(_ontologyLoader));
            var graph = service.MapToRdf(new IdentifiedObject());
            var jsonLd = service.ExportToJsonLd(graph);
            Assert.False(string.IsNullOrWhiteSpace(jsonLd));
        }
    }
}