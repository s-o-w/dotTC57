///////////////////////////////////////////////////////////
//  ErpReqLineItem.cs
//  Implementation of the Class ErpReqLineItem
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:10 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.InfIEC61968.InfERPSupport {
	/// <summary>
	/// Information that describes a requested item and its attributes.
	/// </summary>
	public class ErpReqLineItem : ErpIdentifiedObject {

		/// <summary>
		/// The code
		/// </summary>
		public string? code;
		/// <summary>
		/// Cost of material.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money? cost;
		/// <summary>
		/// The delivery date
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Date? deliveryDate;
		/// <summary>
		/// Quantity of item requisitioned.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? quantity;
		/// <summary>
		/// The status
		/// </summary>
		public TC57CIM.IEC61968.Common.Status? status;
		/// <summary>
		/// The erp requisition
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpRequisition? ErpRequisition;
		/// <summary>
		/// The erp po line item
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpPOLineItem? ErpPOLineItem;

		/// <summary>
		/// Initializes a new instance of the <see cref="ErpReqLineItem"/> class
		/// </summary>
		public ErpReqLineItem(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ErpReqLineItem

}//end namespace InfERPSupport
