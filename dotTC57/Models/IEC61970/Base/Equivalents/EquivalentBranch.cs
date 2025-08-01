///////////////////////////////////////////////////////////
//  EquivalentBranch.cs
//  Implementation of the Class EquivalentBranch
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:51 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Equivalents {
	/// <summary>
	/// The class represents equivalent branches. In cases where a transformer phase
	/// shift is modelled and the EquivalentBranch is spanning the same nodes, the
	/// impedance quantities for the EquivalentBranch shall consider the needed phase
	/// shift.
	/// </summary>
	public class EquivalentBranch : EquivalentEquipment {

		/// <summary>
		/// Negative sequence series resistance from terminal sequence  1 to terminal
		/// sequence 2. Used for short circuit data exchange according to IEC 60909.
		/// EquivalentBranch is a result of network reduction prior to the data exchange.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Resistance? negativeR12;
		/// <summary>
		/// Negative sequence series resistance from terminal sequence 2 to terminal
		/// sequence 1. Used for short circuit data exchange according to IEC 60909.
		/// EquivalentBranch is a result of network reduction prior to the data exchange.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Resistance? negativeR21;
		/// <summary>
		/// Negative sequence series reactance from terminal sequence  1 to terminal
		/// sequence 2. Used for short circuit data exchange according to IEC 60909.
		/// Usage : EquivalentBranch is a result of network reduction prior to the data
		/// exchange.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Reactance? negativeX12;
		/// <summary>
		/// Negative sequence series reactance from terminal sequence 2 to terminal
		/// sequence 1. Used for short circuit data exchange according to IEC 60909.
		/// Usage: EquivalentBranch is a result of network reduction prior to the data
		/// exchange.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Reactance? negativeX21;
		/// <summary>
		/// Positive sequence series resistance from terminal sequence  1 to terminal
		/// sequence 2 . Used for short circuit data exchange according to IEC 60909.
		/// EquivalentBranch is a result of network reduction prior to the data exchange.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Resistance? positiveR12;
		/// <summary>
		/// Positive sequence series resistance from terminal sequence 2 to terminal
		/// sequence 1. Used for short circuit data exchange according to IEC 60909.
		/// EquivalentBranch is a result of network reduction prior to the data exchange.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Resistance? positiveR21;
		/// <summary>
		/// Positive sequence series reactance from terminal sequence  1 to terminal
		/// sequence 2. Used for short circuit data exchange according to IEC 60909.
		/// Usage : EquivalentBranch is a result of network reduction prior to the data
		/// exchange.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Reactance? positiveX12;
		/// <summary>
		/// Positive sequence series reactance from terminal sequence 2 to terminal
		/// sequence 1. Used for short circuit data exchange according to IEC 60909.
		/// Usage : EquivalentBranch is a result of network reduction prior to the data
		/// exchange.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Reactance? positiveX21;
		/// <summary>
		/// Positive sequence series resistance of the reduced branch.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Resistance? r;
		/// <summary>
		/// Resistance from terminal sequence 2 to terminal sequence 1 .Used for steady
		/// state power flow. This attribute is optional and represent unbalanced network
		/// such as off-nominal phase shifter. If only EquivalentBranch.r is given, then
		/// EquivalentBranch.r21 is assumed equal to EquivalentBranch.r.
		/// Usage rule : EquivalentBranch is a result of network reduction prior to the
		/// data exchange.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Resistance? r21;
		/// <summary>
		/// Positive sequence series reactance of the reduced branch.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Reactance? x;
		/// <summary>
		/// Reactance from terminal sequence 2 to terminal sequence 1. Used for steady
		/// state power flow. This attribute is optional and represents an unbalanced
		/// network such as off-nominal phase shifter. If only EquivalentBranch.x is given,
		/// then EquivalentBranch.x21 is assumed equal to EquivalentBranch.x.
		/// Usage rule: EquivalentBranch is a result of network reduction prior to the data
		/// exchange.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Reactance? x21;
		/// <summary>
		/// Zero sequence series resistance from terminal sequence  1 to terminal sequence
		/// 2. Used for short circuit data exchange according to IEC 60909.
		/// EquivalentBranch is a result of network reduction prior to the data exchange.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Resistance? zeroR12;
		/// <summary>
		/// Zero sequence series resistance from terminal sequence  2 to terminal sequence
		/// 1. Used for short circuit data exchange according to IEC 60909.
		/// Usage : EquivalentBranch is a result of network reduction prior to the data
		/// exchange.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Resistance? zeroR21;
		/// <summary>
		/// Zero sequence series reactance from terminal sequence  1 to terminal sequence 2.
		/// Used for short circuit data exchange according to IEC 60909.
		/// Usage : EquivalentBranch is a result of network reduction prior to the data
		/// exchange.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Reactance? zeroX12;
		/// <summary>
		/// Zero sequence series reactance from terminal sequence 2 to terminal sequence 1.
		/// Used for short circuit data exchange according to IEC 60909.
		/// Usage : EquivalentBranch is a result of network reduction prior to the data
		/// exchange.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Reactance? zeroX21;

		/// <summary>
		/// Initializes a new instance of the <see cref="EquivalentBranch"/> class
		/// </summary>
		public EquivalentBranch(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end EquivalentBranch

}//end namespace Equivalents
