using TC57CIM.Semantic.Services;

namespace dotTC57.Tests.Semantic
{
    public class OntologyServiceTests
    {
        [Fact]
        public void Constructor_InitializesOntologyLoader()
        {
            var service = new OntologyService();
            Assert.NotNull(service.OntologyGraph);
        }

        [Fact]
        public void LoadOntology_DoesNotThrow()
        {
            var service = new OntologyService();
            // Should not throw even if file does not exist (method should handle gracefully)
            service.LoadOntology("nonexistent.owl");
        }

        [Fact]
        public void LoadOntologyFromString_DoesNotThrow()
        {
            var service = new OntologyService();
            string dummyOntology = @"<?xml version='1.0'?><rdf:RDF xmlns:rdf='http://www.w3.org/1999/02/22-rdf-syntax-ns#'></rdf:RDF>";
            service.LoadOntologyFromString(dummyOntology);
        }

        [Fact]
        public void GetClass_ReturnsNullForUnknownUri()
        {
            var service = new OntologyService();
            var result = service.GetClass("http://example.org/unknown");
            Assert.Null(result);
        }

        [Fact]
        public void ValidateRelationship_ReturnsFalseForUnknownClasses()
        {
            var service = new OntologyService();
            bool valid = service.ValidateRelationship("http://example.org/source", "http://example.org/target", "http://example.org/rel");
            Assert.False(valid);
        }

        [Fact]
        public void GetPropertiesForClass_ReturnsEmptyForUnknownClass()
        {
            var service = new OntologyService();
            var props = service.GetPropertiesForClass("http://example.org/unknown");
            Assert.Empty(props);
        }

        [Fact]
        public void ExecuteQuery_ReturnsNull()
        {
            var service = new OntologyService();
            var result = service.ExecuteQuery("SELECT * WHERE {?s ?p ?o}");
            Assert.Null(result);
        }
    }
}