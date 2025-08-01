///////////////////////////////////////////////////////////
//  JumperAction.cs
//  Implementation of the Class JumperAction
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:13 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.Operations {
	/// <summary>
	/// Action on jumper as a switching step.
	/// </summary>
	public class JumperAction : SwitchingAction {

		/// <summary>
		/// Switching action to perform.
		/// </summary>
		public TempEquipActionKind kind;
		/// <summary>
		/// Conducting equipment is affected when the jumper action connects one or both
		/// ends of a jumper to the conducting equipment. If the jumper action involves
		/// placing one or both ends of a jumper anywhere along a line segment, you must
		/// use the clamp (to get the distance from one terminal), using the explicit
		/// relation with clamp. In the case of placing one or both ends of the jumper at a
		/// line segment terminal, reference to one or more line segments is sufficient.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.ConductingEquipment? JumpedEquipments;
		/// <summary>
		/// The line segment that this jumper action will affect. This is the only way to
		/// access relationship to clamp in case the jumper needs to connect along the line
		/// segment.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.ACLineSegment? ACLineSegments;
		/// <summary>
		/// Jumper on which this action is taken.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.Jumper? Jumper;

		/// <summary>
		/// Initializes a new instance of the <see cref="JumperAction"/> class
		/// </summary>
		public JumperAction(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end JumperAction

}//end namespace Operations
