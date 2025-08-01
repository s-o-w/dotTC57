///////////////////////////////////////////////////////////
//  AssetModelCatalogue.cs
//  Implementation of the Class AssetModelCatalogue
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:57 AM
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.InfIEC61968.InfAssetInfo {
	/// <summary>
	/// Catalogue of available types of products and materials that are used to build
	/// or install, maintain or operate an Asset. Each catalogue item is for a specific
	/// product (AssetModel) available from a specific supplier.
	/// </summary>
	public class AssetModelCatalogue : IdentifiedObject {

		/// <summary>
		/// The status
		/// </summary>
		public TC57CIM.IEC61968.Common.Status? status;

		/// <summary>
		/// Initializes a new instance of the <see cref="AssetModelCatalogue"/> class
		/// </summary>
		public AssetModelCatalogue(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end AssetModelCatalogue

}//end namespace InfAssetInfo
