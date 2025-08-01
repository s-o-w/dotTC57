///////////////////////////////////////////////////////////
//  UnavailabilitySwitchAction.cs
//  Implementation of the Class UnavailabilitySwitchAction
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:27 AM
//  Original author: 222206
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.InfIEC61970.InfAvailabilityPlans {
	/// <summary>
	/// Relevant switching action for supporting the availability (or unavailability)
	/// plans.  This could open or close a switch that is not directly connected to the
	/// unavailable equipment .
	/// </summary>
	public class UnavailabilitySwitchAction : IdentifiedObject {

		/// <summary>
		/// The switch is to be open during the scheduled period.
		/// </summary>
		public bool open;
		/// <summary>
		/// The equipment unavailability schedule associated with this switch action.
		/// </summary>
		public TC57CIM.IEC61970.InfIEC61970.InfAvailabilityPlans.EquipmentUnavailabilitySchedule? m_EquipmentUnavailabilitySchedule;
		/// <summary>
		/// The switch associated with this unavailability switch action.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.Switch? m_Switch;

		/// <summary>
		/// Initializes a new instance of the <see cref="UnavailabilitySwitchAction"/> class.
		/// </summary>
		public UnavailabilitySwitchAction(){

		}

    /// <summary>
    /// Releases resources used by the <see cref="UnavailabilitySwitchAction"/> class.
    /// </summary>
    public override void Dispose(){

		}

	}//end UnavailabilitySwitchAction

}//end namespace InfAvailabilityPlans
