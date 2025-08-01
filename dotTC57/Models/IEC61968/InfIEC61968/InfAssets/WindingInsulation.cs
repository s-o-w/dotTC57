///////////////////////////////////////////////////////////
//  WindingInsulation.cs
//  Implementation of the Class WindingInsulation
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:31 AM
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.InfIEC61968.InfAssets {
	/// <summary>
	/// Winding insulation condition as a result of a test.
	/// </summary>
	public class WindingInsulation : IdentifiedObject {

		/// <summary>
		/// Status of Winding Insulation Power Factor as of statusDate: Acceptable, Minor
		/// Deterioration or Moisture Absorption, Major Deterioration or Moisture
		/// Absorption, Failed.
		/// </summary>
		public string? insulationPFStatus;
		/// <summary>
		/// For testType, status of Winding Insulation Resistance as of statusDate. Typical
		/// values are: Acceptable, Questionable, Failed.
		/// </summary>
		public string? insulationResistance;
		/// <summary>
		/// As of statusDate, the leakage reactance measured at the "from" winding with the
		/// "to" winding short-circuited and all other windings open-circuited.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Reactance? leakageReactance;
		/// <summary>
		/// The status
		/// </summary>
		public TC57CIM.IEC61968.Common.Status? status;
		/// <summary>
		/// The from winding
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.TransformerEnd? FromWinding;
		/// <summary>
		/// The to winding
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.TransformerEnd? ToWinding;

		/// <summary>
		/// Initializes a new instance of the <see cref="WindingInsulation"/> class
		/// </summary>
		public WindingInsulation(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end WindingInsulation

}//end namespace InfAssets
