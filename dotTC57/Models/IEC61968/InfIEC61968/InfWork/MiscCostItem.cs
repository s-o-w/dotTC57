///////////////////////////////////////////////////////////
//  MiscCostItem.cs
//  Implementation of the Class MiscCostItem
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:16 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.InfIEC61968.InfWork {
	/// <summary>
	/// Various cost items that are not associated with compatible units. Examples
	/// include rental equipment, labor, materials, contractor costs, permits -
	/// anything not covered in a CU.
	/// </summary>
	public class MiscCostItem : WorkIdentifiedObject {

		/// <summary>
		/// This drives the accounting treatment for this misc. item.
		/// </summary>
		public string? account;
		/// <summary>
		/// The cost per unit for this misc. item.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money? costPerUnit;
		/// <summary>
		/// The cost type for accounting, such as material, labor, vehicle, contractor,
		/// equipment, overhead.
		/// </summary>
		public string? costType;
		/// <summary>
		/// External reference identifier (e.g. purchase order number, serial number) .
		/// </summary>
		public string? externalRefID;
		/// <summary>
		/// The quantity of the misc. item being assigned to this location.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.IntegerQuantity? quantity;
		/// <summary>
		/// The status
		/// </summary>
		public TC57CIM.IEC61968.Common.Status? status;
		/// <summary>
		/// The work cost detail
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfWork.WorkCostDetail? WorkCostDetail;

		/// <summary>
		/// Initializes a new instance of the <see cref="MiscCostItem"/> class
		/// </summary>
		public MiscCostItem(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end MiscCostItem

}//end namespace InfWork
