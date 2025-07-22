using Microsoft.Extensions.DependencyInjection;
using TC57CIM.Semantic.Mapping;
using TC57CIM.Semantic.Ontology;
using TC57CIM.Semantic.Services;

namespace TC57CIM.Semantic.Extensions
{
    /// <summary>
    /// Extension methods for IServiceCollection for registering semantic services
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds TC57CIM semantic services to the service collection
        /// </summary>
        public static IServiceCollection AddTC57CIMSemanticServices(this IServiceCollection services)
        {
            // Register OntologyLoader as a singleton
            services.AddSingleton<OntologyLoader>();

            // Register mapper as a singleton
            services.AddSingleton<CimRdfMapper>();

            // Register services
            services.AddScoped<IOntologyService, OntologyService>();
            services.AddScoped<IRdfMappingService, RdfMappingService>();

            return services;
        }
    }
}