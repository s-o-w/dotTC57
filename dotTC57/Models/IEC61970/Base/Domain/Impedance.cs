///////////////////////////////////////////////////////////
//  Impedance.cs
//  Implementation of the Class Impedance
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:04 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Ratio of voltage to current.
	/// </summary>
	public class Impedance {

		/// <summary>
		/// The multiplier
		/// </summary>
		public UnitMultiplier multiplier;
		/// <summary>
		/// The ohm
		/// </summary>
		public static readonly UnitSymbol unit = UnitSymbol.ohm;
		/// <summary>
		/// The value
		/// </summary>
		public Float? value;

		/// <summary>
		/// Initializes a new instance of the <see cref="Impedance"/> class
		/// </summary>
		public Impedance(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public virtual void Dispose(){

		}

	}//end Impedance

}//end namespace Domain
