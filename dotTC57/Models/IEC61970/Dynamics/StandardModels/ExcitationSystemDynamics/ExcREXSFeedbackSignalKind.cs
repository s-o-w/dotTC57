///////////////////////////////////////////////////////////
//  ExcREXSFeedbackSignalKind.cs
//  Implementation of the Class ExcREXSFeedbackSignalKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:55 AM
//  Original author: civanov
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// Types of rate feedback signals.
	/// </summary>
	public enum ExcREXSFeedbackSignalKind : int {

		/// <summary>
		/// The voltage regulator output voltage is used. It is the same as exciter field
		/// voltage.
		/// </summary>
		fieldVoltage,
		/// <summary>
		/// The exciter field current is used.
		/// </summary>
		fieldCurrent,
		/// <summary>
		/// The output voltage of the exciter is used.
		/// </summary>
		outputVoltage

	}//end ExcREXSFeedbackSignalKind

}//end namespace ExcitationSystemDynamics
