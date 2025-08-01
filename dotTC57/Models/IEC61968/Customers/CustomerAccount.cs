///////////////////////////////////////////////////////////
//  CustomerAccount.cs
//  Implementation of the Class CustomerAccount
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:04 AM
///////////////////////////////////////////////////////////

using TC57CIM.IEC61968.Common;
namespace TC57CIM.IEC61968.Customers {
	/// <summary>
	/// Assignment of a group of products and services purchased by the customer
	/// through a customer agreement, used as a mechanism for customer billing and
	/// payment. It contains common information from the various types of customer
	/// agreements to create billings (invoices) for a customer and receive payment.
	/// </summary>
	public class CustomerAccount : Document {

		/// <summary>
		/// Cycle day on which the associated customer account will normally be billed,
		/// used to determine when to produce the billing.
		/// </summary>
		public string? billingCycle;
		/// <summary>
		/// Budget bill code.
		/// </summary>
		public string? budgetBill;
		/// <summary>
		/// The last amount that will be billed to the customer prior to shut off of the
		/// account.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money? lastBillAmount;
		/// <summary>
		/// All payment transactions for this customer account.
		/// </summary>
		public TC57CIM.IEC61968.PaymentMetering.Transaction? PaymentTransactions;
		/// <summary>
		/// All agreements for this customer account.
		/// </summary>
		public TC57CIM.IEC61968.Customers.CustomerAgreement? CustomerAgreements;
		/// <summary>
		/// The work billing infos
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfCustomers.WorkBillingInfo? WorkBillingInfos;
		/// <summary>
		/// The erp invoicees
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpInvoice? ErpInvoicees;
		/// <summary>
		/// The notification for the customer account.
		/// </summary>
		public TC57CIM.IEC61968.Customers.AccountNotification? AccountNotification;

		/// <summary>
		/// Initializes a new instance of the <see cref="CustomerAccount"/> class
		/// </summary>
		public CustomerAccount(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end CustomerAccount

}//end namespace Customers
