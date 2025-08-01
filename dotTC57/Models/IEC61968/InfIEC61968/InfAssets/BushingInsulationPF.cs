///////////////////////////////////////////////////////////
//  BushingInsulationPF.cs
//  Implementation of the Class BushingInsulationPF
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:59 AM
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.InfIEC61968.InfAssets {
	/// <summary>
	/// Bushing insulation power factor condition as a result of a test.
	/// Typical status values are: Acceptable, Minor Deterioration or Moisture
	/// Absorption, Major Deterioration or Moisture Absorption, Failed.
	/// </summary>
	public class BushingInsulationPF : IdentifiedObject {

		/// <summary>
		/// The status
		/// </summary>
		public TC57CIM.IEC61968.Common.Status? status;
		/// <summary>
		/// Kind of test for this bushing.
		/// </summary>
		public BushingInsulationPfTestKind testKind;
		/// <summary>
		/// The transformer observation
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfAssets.TransformerObservation? TransformerObservation;

		/// <summary>
		/// Initializes a new instance of the <see cref="BushingInsulationPF"/> class
		/// </summary>
		public BushingInsulationPF(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end BushingInsulationPF

}//end namespace InfAssets
