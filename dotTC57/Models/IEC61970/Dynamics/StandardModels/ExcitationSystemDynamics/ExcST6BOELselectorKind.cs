///////////////////////////////////////////////////////////
//  ExcST6BOELselectorKind.cs
//  Implementation of the Class ExcST6BOELselectorKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:55 AM
//  Original author: civanov
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// Types of connections for the OEL input used for static excitation systems type
	/// 6B.
	/// </summary>
	public enum ExcST6BOELselectorKind : int {

		/// <summary>
		/// No OEL input is used. Corresponds to <i>OELin</i> not = 1 and not = 2 on the
		/// ExcST6B diagram. Original ExcST6B model would have called this <i>OELin</i> = 0.
		/// 
		/// </summary>
		noOELinput,
		/// <summary>
		/// The connection is before UEL. Corresponds to <i>OELin</i> = 1 on the ExcST6B
		/// diagram.
		/// </summary>
		beforeUEL,
		/// <summary>
		/// The connection is after UEL. Corresponds to <i>OELin</i> = 2 on the ExcST6B
		/// diagram.
		/// </summary>
		afterUEL

	}//end ExcST6BOELselectorKind

}//end namespace ExcitationSystemDynamics
