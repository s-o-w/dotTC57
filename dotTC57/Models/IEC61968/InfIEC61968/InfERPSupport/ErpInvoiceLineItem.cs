///////////////////////////////////////////////////////////
//  ErpInvoiceLineItem.cs
//  Implementation of the Class ErpInvoiceLineItem
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:09 AM
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61968.InfIEC61968.InfERPSupport {
	/// <summary>
	/// An individual line item on an invoice.
	/// </summary>
	public class ErpInvoiceLineItem : ErpDocument {

		/// <summary>
		/// Bill period for the line item.
		/// </summary>
		public DateTimeInterval? billPeriod;
		/// <summary>
		/// General Ledger account code, must be a valid combination.
		/// </summary>
		public string? glAccount;
		/// <summary>
		/// Date and time line item will be posted to the General Ledger.
		/// </summary>
		public System.DateTime? glDateTime;
		/// <summary>
		/// Kind of line item.
		/// </summary>
		public ErpInvoiceLineItemKind kind;
		/// <summary>
		/// Amount due for this line item.
		/// </summary>
		public float lineAmount;
		/// <summary>
		/// Line item number on invoice statement.
		/// </summary>
		public string? lineNumber;
		/// <summary>
		/// Version number of the bill run.
		/// </summary>
		public string? lineVersion;
		/// <summary>
		/// Net line item charge amount.
		/// </summary>
		public float netAmount;
		/// <summary>
		/// Previous line item charge amount.
		/// </summary>
		public float previousAmount;
		/// <summary>
		/// The erp payable line item
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpPayableLineItem? ErpPayableLineItem;
		/// <summary>
		/// The erp payments
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpPayment? ErpPayments;
		/// <summary>
		/// The erp rec line item
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpRecLineItem? ErpRecLineItem;
		/// <summary>
		/// The container erp invoice line item
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpInvoiceLineItem? ContainerErpInvoiceLineItem;
		/// <summary>
		/// The user attributes
		/// </summary>
		public TC57CIM.IEC61968.Common.UserAttribute? UserAttributes;
		/// <summary>
		/// The erp journal entries
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpJournalEntry? ErpJournalEntries;
		/// <summary>
		/// The erp invoice
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpInvoice? ErpInvoice;

		/// <summary>
		/// Initializes a new instance of the <see cref="ErpInvoiceLineItem"/> class
		/// </summary>
		public ErpInvoiceLineItem(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ErpInvoiceLineItem

}//end namespace InfERPSupport
