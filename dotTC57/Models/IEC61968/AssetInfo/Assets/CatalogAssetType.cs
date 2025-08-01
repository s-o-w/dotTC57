///////////////////////////////////////////////////////////
//  CatalogAssetType.cs
//  Implementation of the Class CatalogAssetType
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:00 AM
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// a Assets that may be used for planning, work or design purposes.
	/// </summary>
	public class CatalogAssetType : IdentifiedObject {

		/// <summary>
		/// Estimated unit cost (or cost per unit length) of this type of asset. It does
		/// not include labor to install, construct or configure it.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money? estimatedUnitCost;
		/// <summary>
		/// Kind of asset (from enumerated list).
		/// </summary>
		public AssetKind kind;
		/// <summary>
		/// The value, unit of measure, and multiplier for the quantity.
		/// </summary>
		public string? quantity;
		/// <summary>
		/// True if item is a stock item (default).
		/// </summary>
		public bool stockItem;
		/// <summary>
		/// Description of type of asset.
		/// </summary>
		public string? type;
		/// <summary>
		/// The erp bom item datas
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpBomItemData? ErpBomItemDatas;
		/// <summary>
		/// The erp req line items
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpReqLineItem? ErpReqLineItems;
		/// <summary>
		/// The type asset catalogue
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfTypeAsset.TypeAssetCatalogue? TypeAssetCatalogue;

		/// <summary>
		/// Initializes a new instance of the <see cref="CatalogAssetType"/> class
		/// </summary>
		public CatalogAssetType(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end CatalogAssetType

}//end namespace Assets
