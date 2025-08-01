///////////////////////////////////////////////////////////
//  WirePosition.cs
//  Implementation of the Class WirePosition
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:32 AM
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.AssetInfo {
	/// <summary>
	/// Identification, spacing and configuration of the wires of a conductor with
	/// respect to a structure.
	/// </summary>
	public class WirePosition : IdentifiedObject {

		/// <summary>
		/// Numbering for wires on a WireSpacingInfo. Neutrals should be numbered last.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? sequenceNumber;
		/// <summary>
		/// Signed horizontal distance from the wire at this position to a common reference
		/// point.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Displacement? xCoord;
		/// <summary>
		/// Signed vertical distance from the wire at this position: above ground (positive
		/// value) or burial depth below ground (negative value).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Displacement? yCoord;
		/// <summary>
		/// Wire phase information for this wire position.
		/// </summary>
		public TC57CIM.IEC61968.AssetInfo.WirePhaseInfo? WirePhaseInfo;

		/// <summary>
		/// Initializes a new instance of the <see cref="WirePosition"/> class
		/// </summary>
		public WirePosition(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end WirePosition

}//end namespace AssetInfo
