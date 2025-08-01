///////////////////////////////////////////////////////////
//  ActivePower.cs
//  Implementation of the Class ActivePower
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:38 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Product of RMS value of the voltage and the RMS value of the in-phase component
	/// of the current.
	/// </summary>
	public class ActivePower {

		/// <summary>
		/// The multiplier
		/// </summary>
		public UnitMultiplier multiplier;
		/// <summary>
		/// The
		/// </summary>
		public static readonly UnitSymbol unit = UnitSymbol.W;
		/// <summary>
		/// The value
		/// </summary>
		public Float? value;

		/// <summary>
		/// Initializes a new instance of the <see cref="ActivePower"/> class
		/// </summary>
		public ActivePower(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public virtual void Dispose(){

		}

	}//end ActivePower

}//end namespace Domain
