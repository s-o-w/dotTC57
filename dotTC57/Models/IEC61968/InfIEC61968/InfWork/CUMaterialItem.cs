///////////////////////////////////////////////////////////
//  CUMaterialItem.cs
//  Implementation of the Class CUMaterialItem
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:03 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.InfIEC61968.InfWork {
	/// <summary>
	/// Compatible unit of a consumable supply item. For example, nuts, bolts, brackets,
	/// glue, etc.
	/// </summary>
	public class CUMaterialItem : WorkIdentifiedObject {

		/// <summary>
		/// Code for material.
		/// </summary>
		public string? corporateCode;
		/// <summary>
		/// Quantity of the TypeMaterial for this CU, used to determine estimated costs
		/// based on a per unit cost or a cost per unit length specified in the
		/// TypeMaterial.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.IntegerQuantity? quantity;
		/// <summary>
		/// The status
		/// </summary>
		public TC57CIM.IEC61968.Common.Status? status;
		/// <summary>
		/// The type material
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfWork.TypeMaterial? TypeMaterial;
		/// <summary>
		/// The compatible units
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfWork.CompatibleUnit? CompatibleUnits;

		/// <summary>
		/// Initializes a new instance of the <see cref="CUMaterialItem"/> class
		/// </summary>
		public CUMaterialItem(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end CUMaterialItem

}//end namespace InfWork
