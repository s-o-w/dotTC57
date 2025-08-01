///////////////////////////////////////////////////////////
//  Terminal.cs
//  Implementation of the Class Terminal
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:25 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Core {
	/// <summary>
	/// An AC electrical connection point to a piece of conducting equipment. Terminals
	/// are connected at physical connection points called connectivity nodes.
	/// </summary>
	public class Terminal : ACDCTerminal {

		/// <summary>
		/// Represents the normal network phasing condition. If the attribute is missing,
		/// three phases (ABC) shall be assumed, except for terminals of grounding classes
		/// (specializations of EarthFaultCompensator, GroundDisconnector, and Ground)
		/// which will be assumed to be N. Therefore, phase code ABCN is explicitly
		/// declared when needed, e.g. for star point grounding equipment.
		/// The phase code on terminals connecting same ConnectivityNode or same
		/// TopologicalNode as well as for equipment between two terminals shall be
		/// consistent.
		/// </summary>
		public PhaseCode phases;
		/// <summary>
		/// The connectivity node to which this terminal connects with zero impedance.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.ConnectivityNode? ConnectivityNode;
		/// <summary>
		/// The conducting equipment of the terminal.  Conducting equipment have  terminals
		/// that may be connected to other conducting equipment terminals via connectivity
		/// nodes or topological nodes.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.ConductingEquipment? ConductingEquipment;
		/// <summary>
		/// The controls regulating this terminal.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.RegulatingControl? RegulatingControl;

		/// <summary>
		/// Initializes a new instance of the <see cref="Terminal"/> class
		/// </summary>
		public Terminal(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end Terminal

}//end namespace Core
