///////////////////////////////////////////////////////////
//  ACLineSegmentPhase.cs
//  Implementation of the Class ACLineSegmentPhase
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:38 AM
//  Original author: kdemaree
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Wires {
	/// <summary>
	/// Represents a single wire of an alternating current line segment.
	/// </summary>
	public class ACLineSegmentPhase : PowerSystemResource {

		/// <summary>
		/// The phase connection of the wire at both ends.
		/// </summary>
		public SinglePhaseKind phase;
		/// <summary>
		/// Number designation for this line segment phase. Each line segment phase within
		/// a line segment should have a unique sequence number. This is useful for
		/// unbalanced modelling to bind the mathematical model (PhaseImpedanceData of
		/// PerLengthPhaseImpedance) with the connectivity model (this class) and the
		/// physical model (WirePosition) without tight coupling.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? sequenceNumber;
		/// <summary>
		/// The line segment to which the phase belongs.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.ACLineSegment? ACLineSegment;
		/// <summary>
		/// Wire information contributing to this AC line segment phase information.
		/// </summary>
		public TC57CIM.IEC61968.AssetInfo.WireInfo? WireInfo;

		/// <summary>
		/// Initializes a new instance of the <see cref="ACLineSegmentPhase"/> class
		/// </summary>
		public ACLineSegmentPhase(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ACLineSegmentPhase

}//end namespace Wires
