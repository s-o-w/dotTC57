///////////////////////////////////////////////////////////
//  DCConverterUnit.cs
//  Implementation of the Class DCConverterUnit
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:46 AM
//  Original author: selaost1
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.DC {
	/// <summary>
	/// Indivisible operative unit comprising all equipment between the point of common
	/// coupling on the AC side and the point of common coupling � DC side, essentially
	/// one or more converters, together with one or more converter transformers,
	/// converter control equipment, essential protective and switching devices and
	/// auxiliaries, if any, used for conversion.
	/// </summary>
	public class DCConverterUnit : DCEquipmentContainer {

		/// <summary>
		/// The operating mode of an HVDC bipole (bipolar, monopolar metallic return, etc).
		///
		/// </summary>
		public DCConverterOperatingModeKind operationMode;

		/// <summary>
		/// Initializes a new instance of the <see cref="DCConverterUnit"/> class
		/// </summary>
		public DCConverterUnit(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end DCConverterUnit

}//end namespace DC
