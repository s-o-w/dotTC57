///////////////////////////////////////////////////////////
//  ErpLedgerEntry.cs
//  Implementation of the Class ErpLedgerEntry
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:09 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.InfIEC61968.InfERPSupport {
	/// <summary>
	/// Details of an individual entry in a ledger, which was posted from a journal on
	/// the posted date.
	/// </summary>
	public class ErpLedgerEntry : ErpIdentifiedObject {

		/// <summary>
		/// Account identifier for this entry.
		/// </summary>
		public string? accountID;
		/// <summary>
		/// Kind of account for this entry.
		/// </summary>
		public ErpAccountKind accountKind;
		/// <summary>
		/// The amount of the debit or credit for this account.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money? amount;
		/// <summary>
		/// Date and time this entry was posted to the ledger.
		/// </summary>
		public System.DateTime? postedDateTime;
		/// <summary>
		/// The status
		/// </summary>
		public TC57CIM.IEC61968.Common.Status? status;
		/// <summary>
		/// Date and time journal entry was recorded.
		/// </summary>
		public System.DateTime? transactionDateTime;
		/// <summary>
		/// The erp jounal entry
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpJournalEntry? ErpJounalEntry;
		/// <summary>
		/// The user attributes
		/// </summary>
		public TC57CIM.IEC61968.Common.UserAttribute? UserAttributes;
		/// <summary>
		/// The erp ledger entry line item
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpLedBudLineItem? ErpLedgerEntryLineItem;

		/// <summary>
		/// Initializes a new instance of the <see cref="ErpLedgerEntry"/> class
		/// </summary>
		public ErpLedgerEntry(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ErpLedgerEntry

}//end namespace InfERPSupport
