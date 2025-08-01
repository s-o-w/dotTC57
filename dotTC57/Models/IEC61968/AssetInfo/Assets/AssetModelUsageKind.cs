///////////////////////////////////////////////////////////
//  AssetModelUsageKind.cs
//  Implementation of the Class AssetModelUsageKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:57 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// Usage for an asset model.
	/// </summary>
	public enum AssetModelUsageKind : int {

		/// <summary>
		/// Asset model is intended for use in distribution overhead network.
		/// </summary>
		distributionOverhead,
		/// <summary>
		/// Asset model is intended for use in underground distribution network.
		/// </summary>
		distributionUnderground,
		/// <summary>
		/// Asset model is intended for use in transmission network.
		/// </summary>
		transmission,
		/// <summary>
		/// Asset model is intended for use in substation.
		/// </summary>
		substation,
		/// <summary>
		/// Asset model is intended for use as streetlight.
		/// </summary>
		streetlight,
		/// <summary>
		/// Asset model is intended for use in customer substation.
		/// </summary>
		customerSubstation,
		/// <summary>
		/// Usage of the asset model is unknown.
		/// </summary>
		unknown,
		/// <summary>
		/// Other kind of asset model usage.
		/// </summary>
		other

	}//end AssetModelUsageKind

}//end namespace Assets
