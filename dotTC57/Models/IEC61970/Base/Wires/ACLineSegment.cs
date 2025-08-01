///////////////////////////////////////////////////////////
//  ACLineSegment.cs
//  Implementation of the Class ACLineSegment
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:38 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Wires {
	/// <summary>
	/// A wire or combination of wires, with consistent electrical characteristics,
	/// building a single electrical system, used to carry alternating current between
	/// points in the power system.
	/// For symmetrical, transposed three phase lines, it is sufficient to use
	/// attributes of the line segment, which describe impedances and admittances for
	/// the entire length of the segment.  Additionally impedances can be computed by
	/// using length and associated per length impedances.
	/// The BaseVoltage at the two ends of ACLineSegments in a Line shall have the same
	/// BaseVoltage.nominalVoltage. However, boundary lines may have slightly different
	/// BaseVoltage.nominalVoltages and variation is allowed. Larger voltage difference
	/// in general requires use of an equivalent branch.
	/// </summary>
	public class ACLineSegment : Conductor {

		/// <summary>
		/// Zero sequence shunt (charging) susceptance, uniformly distributed, of the
		/// entire line section.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Susceptance? b0ch;
		/// <summary>
		/// Positive sequence shunt (charging) susceptance, uniformly distributed, of the
		/// entire line section.  This value represents the full charging over the full
		/// length of the line.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Susceptance? bch;
		/// <summary>
		/// Zero sequence shunt (charging) conductance, uniformly distributed, of the
		/// entire line section.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Conductance? g0ch;
		/// <summary>
		/// Positive sequence shunt (charging) conductance, uniformly distributed, of the
		/// entire line section.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Conductance? gch;
		/// <summary>
		/// Positive sequence series resistance of the entire line section.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Resistance? r;
		/// <summary>
		/// Zero sequence series resistance of the entire line section.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Resistance? r0;
		/// <summary>
		/// Maximum permitted temperature at the end of SC for the calculation of minimum
		/// short-circuit currents. Used for short circuit data exchange according to IEC
		/// 60909.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Temperature? shortCircuitEndTemperature;
		/// <summary>
		/// Positive sequence series reactance of the entire line section.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Reactance? x;
		/// <summary>
		/// Zero sequence series reactance of the entire line section.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Reactance? x0;
		/// <summary>
		/// The clamps connected to the line segment.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.Clamp? Clamp;
		/// <summary>
		/// The wire spacing information that applies to this AC line segment
		/// </summary>
		public TC57CIM.IEC61968.AssetInfo.WireSpacingInfo? WireSpacingInfo;

		/// <summary>
		/// Initializes a new instance of the <see cref="ACLineSegment"/> class
		/// </summary>
		public ACLineSegment(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ACLineSegment

}//end namespace Wires
