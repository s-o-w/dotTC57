using Microsoft.Extensions.DependencyInjection;
using TC57CIM.IEC61970.Base.Wires;
using TC57CIM.Semantic.Extensions;
using TC57CIM.Semantic.Services;
using VDS.RDF;

namespace TC57CIM.Semantic.Examples
{
    /// <summary>
    /// Examples of using the semantic capabilities
    /// </summary>
    public static class Usage
    {
        /// <summary>
        /// Example of setting up the services
        /// </summary>
        public static void SetupExample()
        {
            // Setup services
            // NOTE: In a real application, the ServiceCollection and BuildServiceProvider
            // would typically be in the host application (like PowerGraphAPI), not in the library.
            // This example is for demonstration purposes only.
            var services = new ServiceCollection();
            services.AddTC57CIMSemanticServices();
            var serviceProvider = services.BuildServiceProvider();

            // Get services
            var ontologyService = serviceProvider.GetRequiredService<IOntologyService>();
            var mappingService = serviceProvider.GetRequiredService<IRdfMappingService>();

            // Create a CIM object
            var transformer = new PowerTransformer
            {
                mRID = Guid.NewGuid(),
                name = "Transformer 1",
                description = "Main power transformer"
            };

            // Convert to RDF
            IGraph graph = transformer.ToRdf(mappingService);

            // Export to different formats
            string rdfXml = transformer.ToRdfXml(mappingService);
            string turtle = transformer.ToTurtle(mappingService);
            string jsonLd = transformer.ToJsonLd(mappingService);

            // Query the ontology
            var properties = ontologyService.GetPropertiesForClass("http://iec.ch/TC57/CIM#PowerTransformer");

            // Validate a relationship
            bool isValid = ontologyService.ValidateRelationship(
                "http://iec.ch/TC57/CIM#PowerTransformer",
                "http://iec.ch/TC57/CIM#Terminal",
                "http://iec.ch/TC57/CIM#PowerTransformer.Terminal");
        }
    }
}