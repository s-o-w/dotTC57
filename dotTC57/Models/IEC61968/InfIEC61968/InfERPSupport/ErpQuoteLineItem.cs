///////////////////////////////////////////////////////////
//  ErpQuoteLineItem.cs
//  Implementation of the Class ErpQuoteLineItem
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:10 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.InfIEC61968.InfERPSupport {
	/// <summary>
	/// Of an ErpQuote, the item or product quoted along with quantity, price and other
	/// descriptive information.
	/// </summary>
	public class ErpQuoteLineItem : ErpIdentifiedObject {

		/// <summary>
		/// The status
		/// </summary>
		public TC57CIM.IEC61968.Common.Status? status;
		/// <summary>
		/// The erp quote
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpQuote? ErpQuote;
		/// <summary>
		/// Some utilities provide quotes to customer for services, where the customer
		/// accepts the quote by making a payment. An invoice is required for this to occur.
		///
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpInvoiceLineItem? ErpInvoiceLineItem;
		/// <summary>
		/// The erp req line item
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpReqLineItem? ErpReqLineItem;
		/// <summary>
		/// The design
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfWork.Design? Design;

		/// <summary>
		/// Initializes a new instance of the <see cref="ErpQuoteLineItem"/> class
		/// </summary>
		public ErpQuoteLineItem(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ErpQuoteLineItem

}//end namespace InfERPSupport
