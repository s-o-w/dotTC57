///////////////////////////////////////////////////////////
//  AuxiliaryAccount.cs
//  Implementation of the Class AuxiliaryAccount
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:58 AM
///////////////////////////////////////////////////////////

using TC57CIM.IEC61968.Common;
namespace TC57CIM.IEC61968.PaymentMetering {
	/// <summary>
	/// Variable and dynamic part of auxiliary agreement, generally representing the
	/// current state of the account related to the outstanding balance defined in
	/// auxiliary agreement.
	/// </summary>
	public class AuxiliaryAccount : Document {

		/// <summary>
		/// The total amount currently remaining on this account that is required to be
		/// paid in order to settle the account to zero. This excludes any due amounts not
		/// yet paid.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money? balance;
		/// <summary>
		/// Current amounts now due for payment on this account.
		/// </summary>
		public Due? due;
		/// <summary>
		/// Details of the last credit transaction performed on this account.
		/// </summary>
		public AccountMovement? lastCredit;
		/// <summary>
		/// Details of the last debit transaction performed on this account.
		/// </summary>
		public AccountMovement? lastDebit;
		/// <summary>
		/// The initial principle amount, with which this account was instantiated.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money? principleAmount;
		/// <summary>
		/// All charges levied on this account.
		/// </summary>
		public TC57CIM.IEC61968.PaymentMetering.Charge? Charges;
		/// <summary>
		/// All payments against this account.
		/// </summary>
		public TC57CIM.IEC61968.PaymentMetering.Transaction? PaymentTransactions;

		/// <summary>
		/// Initializes a new instance of the <see cref="AuxiliaryAccount"/> class
		/// </summary>
		public AuxiliaryAccount(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end AuxiliaryAccount

}//end namespace PaymentMetering
