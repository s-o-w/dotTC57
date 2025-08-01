///////////////////////////////////////////////////////////
//  ErpLedBudLineItem.cs
//  Implementation of the Class ErpLedBudLineItem
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:09 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.InfIEC61968.InfERPSupport {
	/// <summary>
	/// Individual entry of a given Ledger Budget, typically containing information
	/// such as amount, accounting date, accounting period, and is associated with the
	/// applicable general ledger account.
	/// </summary>
	public class ErpLedBudLineItem : ErpIdentifiedObject {

		/// <summary>
		/// The status
		/// </summary>
		public TC57CIM.IEC61968.Common.Status? status;
		/// <summary>
		/// The erp ledger budget
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpLedgerBudget? ErpLedgerBudget;

		/// <summary>
		/// Initializes a new instance of the <see cref="ErpLedBudLineItem"/> class
		/// </summary>
		public ErpLedBudLineItem(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ErpLedBudLineItem

}//end namespace InfERPSupport
