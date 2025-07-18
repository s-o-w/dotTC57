﻿///////////////////////////////////////////////////////////
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
		public TC57CIM.IEC61970.InfIEC61970.InfAvailabilityPlans.EquipmentUnavailabilitySchedule m_EquipmentUnavailabilitySchedule;
		public TC57CIM.IEC61970.Base.Wires.Switch m_Switch;

		public UnavailabilitySwitchAction(){

		}

		~UnavailabilitySwitchAction(){

		}

		public override void Dispose(){

		}

	}//end UnavailabilitySwitchAction

}//end namespace InfAvailabilityPlans