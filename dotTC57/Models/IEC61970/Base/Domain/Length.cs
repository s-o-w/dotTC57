///////////////////////////////////////////////////////////
//  Length.cs
//  Implementation of the Class Length
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:05 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Unit of length. It shall be a positive value or zero.
	/// </summary>
	public class Length {

		/// <summary>
		/// The multiplier
		/// </summary>
		public UnitMultiplier multiplier;
		/// <summary>
		/// The
		/// </summary>
		public static readonly UnitSymbol unit = UnitSymbol.m;
		/// <summary>
		/// The value
		/// </summary>
		public System.Single? value;

		/// <summary>
		/// Initializes a new instance of the <see cref="Length"/> class
		/// </summary>
		public Length(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public virtual void Dispose(){

		}

	}//end Length

}//end namespace Domain
