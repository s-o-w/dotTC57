///////////////////////////////////////////////////////////
//  Fault.cs
//  Implementation of the Class Fault
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:56 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Faults {
	/// <summary>
	/// Abnormal condition causing current flow through conducting equipment, such as
	/// caused by equipment failure or short circuits from objects not typically
	/// modelled (for example, a tree falling on a line).
	/// </summary>
	public class Fault : IdentifiedObject {

		/// <summary>
		/// Fault impedance. Its usage is described by 'kind'.
		/// </summary>
		public FaultImpedance? impedance;
		/// <summary>
		/// The kind of phase fault.
		/// </summary>
		public PhaseConnectedFaultKind kind;
		/// <summary>
		/// The date and time at which the fault occurred.
		/// </summary>
		public System.DateTime? occurredDateTime;
		/// <summary>
		/// The phases participating in the fault. The fault connections into these phases
		/// are further specified by the type of fault.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.PhaseCode? phases;
		/// <summary>
		/// Equipment carrying this fault.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.Equipment? FaultyEquipment;
		/// <summary>
		/// All types of fault cause.
		/// </summary>
		public TC57CIM.IEC61970.Base.Faults.FaultCauseType? FaultCauseTypes;
		/// <summary>
		/// Location of this fault.
		/// </summary>
		public TC57CIM.IEC61968.Common.Location? Location;

		/// <summary>
		/// Initializes a new instance of the <see cref="Fault"/> class
		/// </summary>
		public Fault(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end Fault

}//end namespace Faults
