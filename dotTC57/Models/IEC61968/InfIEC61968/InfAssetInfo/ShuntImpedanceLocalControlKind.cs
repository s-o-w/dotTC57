///////////////////////////////////////////////////////////
//  ShuntImpedanceLocalControlKind.cs
//  Implementation of the Class ShuntImpedanceLocalControlKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:25 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.InfIEC61968.InfAssetInfo {
	/// <summary>
	/// Kind of local control for shunt impedance.
	/// </summary>
	public enum ShuntImpedanceLocalControlKind : int {

		/// <summary>
		/// The none shunt impedance local control kind
		/// </summary>
		none,
		/// <summary>
		/// The power factor shunt impedance local control kind
		/// </summary>
		powerFactor,
		/// <summary>
		/// The time shunt impedance local control kind
		/// </summary>
		time,
		/// <summary>
		/// The temperature shunt impedance local control kind
		/// </summary>
		temperature,
		/// <summary>
		/// The reactive power shunt impedance local control kind
		/// </summary>
		reactivePower,
		/// <summary>
		/// The current shunt impedance local control kind
		/// </summary>
		current,
		/// <summary>
		/// The voltage shunt impedance local control kind
		/// </summary>
		voltage

	}//end ShuntImpedanceLocalControlKind

}//end namespace InfAssetInfo
