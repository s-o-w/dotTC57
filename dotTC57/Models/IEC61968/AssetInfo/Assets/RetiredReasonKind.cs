///////////////////////////////////////////////////////////
//  RetiredReasonKind.cs
//  Implementation of the Class RetiredReasonKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:23 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// Reason asset retired.
	/// </summary>
	public enum RetiredReasonKind : int {

		/// <summary>
		/// Retired due to environmental reasons.
		/// </summary>
		environmental,
		/// <summary>
		/// Retired due to excessive maintainance issues.
		/// </summary>
		excessiveMaintenance,
		/// <summary>
		/// Retired due to facility upgrade.
		/// </summary>
		facilitiesUpgrade,
		/// <summary>
		/// Retired because of failure.
		/// </summary>
		failed,
		/// <summary>
		/// Retired due to obsolescence.
		/// </summary>
		obsolescence,
		/// <summary>
		/// Retired due to other reasons.
		/// </summary>
		other,
		/// <summary>
		/// Retired and sold.
		/// </summary>
		sold

	}//end RetiredReasonKind

}//end namespace Assets
