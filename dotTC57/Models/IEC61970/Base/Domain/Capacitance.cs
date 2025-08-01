///////////////////////////////////////////////////////////
//  Capacitance.cs
//  Implementation of the Class Capacitance
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:42 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Capacitive part of reactance (imaginary part of impedance), at rated frequency.
	///
	/// </summary>
	public class Capacitance {

		/// <summary>
		/// The multiplier
		/// </summary>
		public UnitMultiplier multiplier;
		/// <summary>
		/// The
		/// </summary>
		public static readonly UnitSymbol unit = UnitSymbol.F;
		/// <summary>
		/// The value
		/// </summary>
		public Float? value;

		/// <summary>
		/// Initializes a new instance of the <see cref="Capacitance"/> class
		/// </summary>
		public Capacitance(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public virtual void Dispose(){

		}

	}//end Capacitance

}//end namespace Domain
