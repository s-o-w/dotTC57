using TC57CIM.Semantic.Services;
using TC57CIM.Semantic.Mapping;
using TC57CIM.IEC61970.Base.Core;
using VDS.RDF;
using TC57CIM.Semantic.Ontology;

namespace dotTC57.Tests.Semantic
{
    public class RdfMappingServiceTests
    {
        private readonly OntologyLoader _ontologyLoader = new OntologyLoader();
        private class DummyMapper : CimRdfMapper
        {
          public DummyMapper(OntologyLoader ontologyLoader) : base(ontologyLoader)
          {
          }

          public override IGraph MapToRdf(IdentifiedObject cimObject)
          {
            var graph = new Graph();
            graph.Assert(graph.CreateUriNode("ex:subject"), graph.CreateUriNode("ex:predicate"), graph.CreateLiteralNode("object"));
            return graph;
          }

          public override IGraph MapToRdf(IEnumerable<IdentifiedObject> cimObjects)
          {
            var graph = new Graph();
            graph.Assert(graph.CreateUriNode("ex:subject"), graph.CreateUriNode("ex:predicate"), graph.CreateLiteralNode("object"));
            return graph;
          }
        }

        [Fact]
        public void MapToRdf_SingleObject_ReturnsGraph()
        {
            var service = new RdfMappingService(new DummyMapper(_ontologyLoader));
            var obj = new IdentifiedObject();
            var graph = service.MapToRdf(obj);
            Assert.NotNull(graph);
            Assert.NotEmpty(graph.Triples);
        }

        [Fact]
        public void MapToRdf_MultipleObjects_ReturnsGraph()
        {
            var service = new RdfMappingService(new DummyMapper(_ontologyLoader));
            var objs = new List<IdentifiedObject> { new IdentifiedObject(), new IdentifiedObject() };
            var graph = service.MapToRdf(objs);
            Assert.NotNull(graph);
            Assert.NotEmpty(graph.Triples);
        }

        [Fact]
        public void ExportToRdfXml_ReturnsString()
        {
            var service = new RdfMappingService(new DummyMapper(_ontologyLoader));
            var graph = service.MapToRdf(new IdentifiedObject());
            var rdfXml = service.ExportToRdfXml(graph);
            Assert.False(string.IsNullOrWhiteSpace(rdfXml));
        }

        [Fact]
        public void ExportToTurtle_ReturnsString()
        {
            var service = new RdfMappingService(new DummyMapper(_ontologyLoader));
            var graph = service.MapToRdf(new IdentifiedObject());
            var turtle = service.ExportToTurtle(graph);
            Assert.False(string.IsNullOrWhiteSpace(turtle));
        }

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