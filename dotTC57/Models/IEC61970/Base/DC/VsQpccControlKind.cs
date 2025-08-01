///////////////////////////////////////////////////////////
//  VsQpccControlKind.cs
//  Implementation of the Class VsQpccControlKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:30 AM
//  Original author: selaost1
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.DC {
	/// <summary>
	/// Kind of reactive power control at point of common coupling for a voltage source
	/// converter.
	/// </summary>
	public enum VsQpccControlKind : int {

		/// <summary>
		/// Control is reactive power at point of common coupling. Target is provided by
		/// VsConverter.targetQpcc.
		/// </summary>
		reactivePcc,
		/// <summary>
		/// Control is voltage at point of common coupling. Target is provided by
		/// VsConverter.targetUpcc.
		/// </summary>
		voltagePcc,
		/// <summary>
		/// Control is power factor at point of common coupling. Target is provided by
		/// VsConverter.targetPowerFactorPcc.
		/// </summary>
		powerFactorPcc,
		/// <summary>
		/// No explicit control. Pulse-modulation factor is directly set in magnitude
		/// (VsConverter.targetPWMfactor) and phase (VsConverter.targetPhasePcc).
		/// </summary>
		pulseWidthModulation

	}//end VsQpccControlKind

}//end namespace DC
