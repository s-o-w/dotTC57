///////////////////////////////////////////////////////////
//  Charge.cs
//  Implementation of the Class Charge
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:00 AM
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.PaymentMetering {
	/// <summary>
	/// A charge element associated with other entities such as tariff structures,
	/// auxiliary agreements or other charge elements. The total charge amount
	/// applicable to this instance of charge is the sum of fixed and variable portion.
	///
	/// </summary>
	public class Charge : IdentifiedObject {

		/// <summary>
		/// The fixed portion of this charge element.
		/// </summary>
		public AccountingUnit? fixedPortion;
		/// <summary>
		/// The kind of charge to be applied.
		/// </summary>
		public ChargeKind kind;
		/// <summary>
		/// The variable portion of this charge element, calculated as a percentage of the
		/// total amount of a parent charge.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PerCent? variablePortion;
		/// <summary>
		/// All sub-components of this complex charge.
		/// </summary>
		public TC57CIM.IEC61968.PaymentMetering.Charge? ChildCharges;

		/// <summary>
		/// Initializes a new instance of the <see cref="Charge"/> class
		/// </summary>
		public Charge(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end Charge

}//end namespace PaymentMetering
