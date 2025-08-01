///////////////////////////////////////////////////////////
//  Temperature.cs
//  Implementation of the Class Temperature
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:25 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Value of temperature in degrees Celsius.
	/// </summary>
	public class Temperature {

		/// <summary>
		/// The none
		/// </summary>
		public static readonly UnitMultiplier multiplier = UnitMultiplier.none;
		/// <summary>
		/// The deg
		/// </summary>
		public static readonly UnitSymbol unit = UnitSymbol.degC;
		/// <summary>
		/// The value
		/// </summary>
		public System.Single? value;

		/// <summary>
		/// Initializes a new instance of the <see cref="Temperature"/> class
		/// </summary>
		public Temperature(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public virtual void Dispose(){

		}

	}//end Temperature

}//end namespace Domain
