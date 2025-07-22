# dotTC57

dotTC57 is a pure .NET/C# library that implements the IEC 61970 and IEC 61968 electrical standards with semantic capabilities. These standards, developed by the IEC TC57 working group, define the Common Information Model (CIM) for power systems.

## Overview

This library provides:
1. A complete object model representing IEC TC57 electrical standards
2. Semantic capabilities via OWL ontology support powered by dotNetRDF
3. Conversion of CIM objects to RDF, RDF/XML, Turtle, and JSON-LD formats
4. Ontology-based validation and reasoning for electrical models

The core model is derived from the UML model available at the [CIM User Group](https://cimug.ucaiug.org/CIM%20Model%20Releases/Forms/AllItems.aspx). You'll need [Sparx Enterprise Architect](https://sparxsystems.com/) to view the original EAP files from that site. You can use a temporary license to generate the base class files for use in your project (which is where I started).

## Getting Started

### Installation
dotnet add package dotTC57
### Basic Usage
```csharp

// Register services
var services = new ServiceCollection();
services.AddTC57CIMSemanticServices();
var serviceProvider = services.BuildServiceProvider();

// Get required services
var ontologyService = serviceProvider.GetRequiredService<IOntologyService>();
var mappingService = serviceProvider.GetRequiredService<IRdfMappingService>();

// Create a CIM object
var transformer = new PowerTransformer
{
    mRID = Guid.NewGuid(),
    name = "Transformer 1",
    description = "Main power transformer"
};

// Convert to RDF and export to different formats
IGraph graph = transformer.ToRdf(mappingService);
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

```
## Features

### CIM Object Model
- Complete implementation of IEC 61970 and IEC 61968 standards
- Native .NET types (string, double, etc.) replacing CIM primitive types for better usability
- Strongly-typed model with full documentation

### Semantic Capabilities
- Built-in OWL ontology support via embedded ontology file
- RDF conversion with URI mapping and namespace handling
- Export to multiple RDF serialization formats
- Ontology-based validation and relationship checking
- Extension methods for easy object-to-RDF conversion

### Integration Support
- Dependency Injection support via `AddTC57CIMSemanticServices()`
- Compatible with knowledge graph databases and SPARQL endpoints
- Interoperability with other RDF-based systems

## Library Structure

- **TC57CIM.IEC61970**: Core power system object model
- **TC57CIM.IEC61968**: Distribution management object model
- **TC57CIM.Semantic**: RDF mapping and ontology services
- **TC57CIM.Semantic.Extensions**: Extension methods for CIM-to-RDF conversion
- **TC57CIM.Semantic.Services**: Interfaces for semantic services

## Future Development

Future versions of this library will expand into IEC 61850 (communication networks and systems for power utility automation), which is also part of the TC57 working group's standards.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License.
