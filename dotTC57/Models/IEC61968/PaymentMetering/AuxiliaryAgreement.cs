///////////////////////////////////////////////////////////
//  AuxiliaryAgreement.cs
//  Implementation of the Class AuxiliaryAgreement
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:58 AM
///////////////////////////////////////////////////////////

using TC57CIM.IEC61968.Common;
namespace TC57CIM.IEC61968.PaymentMetering {
	/// <summary>
	/// An ad-hoc auxiliary account agreement associated with a customer agreement, not
	/// part of the customer's account, but typically subject to formal agreement
	/// between customer and supplier (utility). Typically this is used to collect
	/// revenue owed by the customer for other services or arrears accrued with the
	/// utility for other services. It is typically linked to a prepaid token purchase
	/// transaction, thus forcing the customer to make a payment towards settlement of
	/// the auxiliary account balance whenever the customer needs to purchase a prepaid
	/// token for electricity.
	/// The present status of the auxiliary agreement can be defined in the context of
	/// the utility's business rules, for example: enabled, disabled, pending, over
	/// recovered, under recovered, written off, etc.
	/// </summary>
	public class AuxiliaryAgreement : Agreement {

		/// <summary>
		/// The interest per annum to be charged prorata on 'AuxiliaryAccount.dueArrears'
		/// at the end of each 'payCycle'.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PerCent? arrearsInterest;
		/// <summary>
		/// The frequency for automatically recurring auxiliary charges, where
		/// 'AuxiliaryAccount.initialCharge' is recursively added to 'AuxiliaryAccount.
		/// dueCurrent' at the start of each 'auxCycle'. For example: on a specified date
		/// and time; hourly; daily; weekly; monthly; 3-monthly; 6-monthly; 12-monthly; etc.
		///
		/// </summary>
		public string? auxCycle;
		/// <summary>
		/// The coded priority indicating the priority that this auxiliary agreement has
		/// above other auxiliary agreements (associated with the same customer agreement)
		/// when it comes to competing for settlement from a payment transaction or token
		/// purchase.
		/// </summary>
		public string? auxPriorityCode;
		/// <summary>
		/// The fixed amount that has to be collected from each vending transaction towards
		/// settlement of this auxiliary agreement. Note that there may be multiple tokens
		/// vended per vending transaction, but this is not relevant.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money? fixedAmount;
		/// <summary>
		/// The minimum amount that has to be paid at any transaction towards settling this
		/// auxiliary agreement or reducing the balance.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money? minAmount;
		/// <summary>
		/// The contractually expected payment frequency (by the customer). Examples are:
		/// ad-hoc; on specified date; hourly, daily, weekly, monthly. etc.
		/// </summary>
		public string? payCycle;
		/// <summary>
		/// Sub-classification of the inherited 'type' for this AuxiliaryAgreement.
		/// </summary>
		public string? subType;
		/// <summary>
		/// The percentage of the transaction amount that has to be collected from each
		/// vending transaction towards settlement of this auxiliary agreement when
		/// payments are not in arrears. Note that there may be multiple tokens vended per
		/// vending transaction, but this is not relevant.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PerCent? vendPortion;
		/// <summary>
		/// The percentage of the transaction amount that has to be collected from each
		/// vending transaction towards settlement of this auxiliary agreement when
		/// payments are in arrears. Note that there may be multiple tokens vended per
		/// vending transaction, but this is not relevant.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PerCent? vendPortionArrear;
		/// <summary>
		/// All auxiliary accounts regulated by this agreement.
		/// </summary>
		public TC57CIM.IEC61968.PaymentMetering.AuxiliaryAccount? AuxiliaryAccounts;

		/// <summary>
		/// Initializes a new instance of the <see cref="AuxiliaryAgreement"/> class
		/// </summary>
		public AuxiliaryAgreement(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end AuxiliaryAgreement

}//end namespace PaymentMetering
