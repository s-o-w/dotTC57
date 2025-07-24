# dotTC57

dotTC57 is a pure .NET implementation of IEC Technical Committee (TC) 57 standards for power systems management and information exchange. This library provides a comprehensive set of C# models representing the IEC 61970 and IEC 61968 Common Information Model (CIM).

## Overview

This library focuses on providing:
1. A complete and well-documented object model representing the IEC TC57 electrical standards
2. Fully-typed C# classes with XML documentation
3. Models suitable for integration into power system applications

The core models are derived from the UML model available at the [CIM User Group](https://cimug.ucaiug.org/CIM%20Model%20Releases/Forms/AllItems.aspx). The original EAP files from that site can be viewed with [Sparx Enterprise Architect](https://sparxsystems.com/).

## Model Structure

The library contains models organized according to the IEC standards structure:

### IEC61970 Models
- **Base**: Core power system resource models, measurements, and domain types
- **Dynamics**: Dynamic behavior models including:
  - Excitation systems
  - Power system stabilizers
  - Turbine-governors
  - Synchronous and asynchronous machine dynamics
- **Generation**: Generation models
- **Topology**: Network topology models
- **Wires**: Transmission and distribution equipment models

### IEC61968 Models
- **AssetInfo**: Information about physical assets including:
  - Equipment standards (ASTM, DIN, IEC, IEEE, ISO, TAPPI)
  - Cable and wire specifications
  - Power transformer specifications
- **Assets**: Asset models and asset containers
- **Common**: Common components shared across the model
- **Customers**: Customer models and agreements
- **Metering**: Metering components and readings
- **Operations**: Operational models
- **Work**: Work management and scheduling

## Usage

These models can be used as the foundation for:

```csharp
// Create power system components
var transformer = new PowerTransformer
{
    mRID = Guid.NewGuid().ToString(),
    name = "Transformer 1",
    description = "Main power transformer"
};

// Link components together
var terminal = new Terminal
{
    mRID = Guid.NewGuid().ToString(),
    name = "Terminal 1",
    ConductingEquipment = transformer
};

// Add specifications
var transformerInfo = new PowerTransformerInfo
{
    mRID = Guid.NewGuid().ToString(),
    name = "100MVA Transformer Spec"
};
```
## Documentation

The library includes comprehensive XML documentation that can be used to generate API documentation using standard .NET documentation tools like DocFX:

```bash
# Install DocFX
dotnet tool install -g docfx

# Create documentation project
mkdir -p docs
cd docs
docfx init

# Configure docfx.json to point to your project
# Build documentation
docfx metadata
docfx build
docfx serve _site
```

## Model Implementation Details

- **Complete Implementation**: All classes from the IEC 61970 and IEC 61968 standards are included
- **Strongly Typed**: Native .NET types used throughout (string, double, int, etc.)
- **Well Documented**: XML documentation comments on all classes, properties, and enumerations
- **Namespace Organization**: Clear namespace hierarchy matching the IEC standard structure

## Future Development

These models provide the foundation for:
- Integration with data persistence layers
- Power system analysis applications
- RDF/semantic web implementations
- Import/export to industry standard formats

## Contributing

Contributions to improve the models are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License.
