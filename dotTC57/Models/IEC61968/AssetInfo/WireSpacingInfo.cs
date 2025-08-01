///////////////////////////////////////////////////////////
//  WireSpacingInfo.cs
//  Implementation of the Class WireSpacingInfo
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:32 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.AssetInfo {
	/// <summary>
	/// Wire spacing data that associates multiple wire positions with the line segment,
	/// and allows to calculate line segment impedances. Number of phases can be
	/// derived from the number of associated wire positions whose phase is not neutral.
	///
	/// </summary>
	public class WireSpacingInfo : Assets.AssetInfo {

		/// <summary>
		/// If true, this spacing data describes a cable.
		/// </summary>
		public System.Boolean? isCable;
		/// <summary>
		/// Number of wire sub-conductors in the symmetrical bundle (typically between 1
		/// and 4).
		/// </summary>
		public System.Int32? phaseWireCount;
		/// <summary>
		/// Distance between wire sub-conductors in a symmetrical bundle.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Length? phaseWireSpacing;
		/// <summary>
		/// Usage of the associated wires.
		/// </summary>
		public WireUsageKind usage;
		/// <summary>
		/// The duct bank
		/// </summary>
		public TC57CIM.IEC61968.AssetInfo.Assets.DuctBank? DuctBank;
		/// <summary>
		/// The structures
		/// </summary>
		public TC57CIM.IEC61968.AssetInfo.Assets.Structure? Structures;
		/// <summary>
		/// All positions of single wires (phase or neutral) making the conductor.
		/// </summary>
		public TC57CIM.IEC61968.AssetInfo.WirePosition? WirePositions;

		/// <summary>
		/// Initializes a new instance of the <see cref="WireSpacingInfo"/> class
		/// </summary>
		public WireSpacingInfo(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end WireSpacingInfo

}//end namespace AssetInfo
