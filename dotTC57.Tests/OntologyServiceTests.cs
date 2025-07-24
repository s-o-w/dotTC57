using TC57CIM.Semantic.Services;

namespace dotTC57.Tests.Semantic
{
    /// <summary>
    /// The ontology service tests class
    /// </summary>
    public class OntologyServiceTests
    {
        /// <summary>
        /// Tests that constructor initializes ontology loader
        /// </summary>
        [Fact]
        public void Constructor_InitializesOntologyLoader()
        {
            var service = new OntologyService();
            Assert.NotNull(service.OntologyGraph);
        }

        /// <summary>
        /// Tests that load ontology does not throw
        /// </summary>
        [Fact]
        public void LoadOntology_DoesNotThrow()
        {
            var service = new OntologyService();
            // Should not throw even if file does not exist (method should handle gracefully)
            service.LoadOntology("nonexistent.owl");
        }

        /// <summary>
        /// Tests that load ontology from string does not throw
        /// </summary>
        [Fact]
        public void LoadOntologyFromString_DoesNotThrow()
        {
            var service = new OntologyService();
            string dummyOntology = @"<?xml version='1.0'?><rdf:RDF xmlns:rdf='http://www.w3.org/1999/02/22-rdf-syntax-ns#'></rdf:RDF>";
            service.LoadOntologyFromString(dummyOntology);
        }

        /// <summary>
        /// Tests that get class returns null for unknown uri
        /// </summary>
        [Fact]
        public void GetClass_ReturnsNullForUnknownUri()
        {
            var service = new OntologyService();
            var result = service.GetClass("http://example.org/unknown");
            Assert.Null(result);
        }

        /// <summary>
        /// Tests that validate relationship returns false for unknown classes
        /// </summary>
        [Fact]
        public void ValidateRelationship_ReturnsFalseForUnknownClasses()
        {
            var service = new OntologyService();
            bool valid = service.ValidateRelationship("http://example.org/source", "http://example.org/target", "http://example.org/rel");
            Assert.False(valid);
        }

        /// <summary>
        /// Tests that get properties for class returns empty for unknown
        /// </summary>
        [Fact]
        public void GetPropertiesForClass_ReturnsEmptyForUnknownClass()
        {
            var service = new OntologyService();
            var props = service.GetPropertiesForClass("http://example.org/unknown");
            Assert.Empty(props);
        }

        /// <summary>
        /// Tests that execute query returns null
        /// </summary>
        [Fact]
        public void ExecuteQuery_ReturnsNull()
        {
            var service = new OntologyService();
            var result = service.ExecuteQuery("SELECT * WHERE {?s ?p ?o}");
            Assert.Null(result);
        }
    }
}