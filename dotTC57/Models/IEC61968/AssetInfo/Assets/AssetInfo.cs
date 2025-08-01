///////////////////////////////////////////////////////////
//  AssetInfo.cs
//  Implementation of the Class AssetInfo
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:57 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// Set of attributes of an asset, representing typical datasheet information of a
	/// physical device that can be instantiated and shared in different data exchange
	/// contexts:
	/// - as attributes of an asset instance (installed or in stock)
	/// - as attributes of an asset model (product by a manufacturer)
	/// - as attributes of a type asset (generic type of an asset as used in
	/// designs/extension planning).
	/// </summary>
	public class AssetInfo : IdentifiedObject {

		/// <summary>
		/// All power system resources with this datasheet information.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.PowerSystemResource? PowerSystemResources;
		/// <summary>
		/// Asset information (nameplate) for this catalog asset type.
		/// </summary>
		public TC57CIM.IEC61968.AssetInfo.Assets.CatalogAssetType? CatalogAssetType;

		/// <summary>
		/// Initializes a new instance of the <see cref="AssetInfo"/> class
		/// </summary>
		public AssetInfo(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end AssetInfo

}//end namespace Assets
