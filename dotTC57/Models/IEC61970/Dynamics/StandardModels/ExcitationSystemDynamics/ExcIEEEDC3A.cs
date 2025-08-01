///////////////////////////////////////////////////////////
//  ExcIEEEDC3A.cs
//  Implementation of the Class ExcIEEEDC3A
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:53 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// IEEE 421.5-2005 type DC3A model. This model represents older systems, in
	/// particular those DC commutator exciters with non-continuously acting regulators
	/// that were commonly used before the development of the continuously acting
	/// varieties.  These systems respond at basically two different rates, depending
	/// upon the magnitude of voltage error. For small errors, adjustment is made
	/// periodically with a signal to a motor-operated rheostat. Larger errors cause
	/// resistors to be quickly shorted or inserted and a strong forcing signal applied
	/// to the exciter. Continuous motion of the motor-operated rheostat occurs for
	/// these larger error signals, even though it is bypassed by contactor action.
	/// Reference: IEEE 421.5-2005, 5.3.
	/// </summary>
	public class ExcIEEEDC3A : ExcitationSystemDynamics {

		/// <summary>
		/// Exciter voltage at which exciter saturation is defined
		/// (<i>E</i><i><sub>FD1</sub></i>) (> 0).  Typical value = 3,375.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? efd1;
		/// <summary>
		/// Exciter voltage at which exciter saturation is defined
		/// (<i>E</i><i><sub>FD2</sub></i>) (> 0).  Typical value = 3,15.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? efd2;
		/// <summary>
		/// (<i>exclim</i>).  IEEE standard is ambiguous about lower limit on exciter
		/// output.
		/// true = a lower limit of zero is applied to integrator output
		/// false = a lower limit of zero is not applied to integrator output.
		/// Typical value = true.
		/// </summary>
		public bool exclim;
		/// <summary>
		/// Exciter constant related to self-excited field (<i>K</i><i><sub>E</sub></i>).
		/// Typical value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ke;
		/// <summary>
		/// Fast raise/lower contact setting (<i>K</i><i><sub>V</sub></i>) (> 0).  Typical
		/// value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kv;
		/// <summary>
		/// Exciter saturation function value at the corresponding exciter voltage,
		/// <i>E</i><i><sub>FD1</sub></i>
		/// (<i>S</i><i><sub>E</sub></i><i>[E</i><i><sub>FD1</sub></i><i>]</i>) (>= 0).
		/// Typical value = 0,267.
		/// </summary>
		public float seefd1;
		/// <summary>
		/// Exciter saturation function value at the corresponding exciter voltage,
		/// <i>E</i><i><sub>FD2</sub></i>
		/// (<i>S</i><i><sub>E</sub></i><i>[E</i><i><sub>FD2</sub></i><i>]</i>) (>= 0).
		/// Typical value = 0,068.
		/// </summary>
		public float seefd2;
		/// <summary>
		/// Exciter time constant, integration rate associated with exciter control
		/// (<i>T</i><i><sub>E</sub></i>) (> 0).  Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? te;
		/// <summary>
		/// Rheostat travel time (<i>T</i><i><sub>RH</sub></i>) (> 0).  Typical value = 20.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? trh;
		/// <summary>
		/// Maximum voltage regulator output (<i>V</i><i><sub>RMAX</sub></i>) (greater than 0).
		/// Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmax;
		/// <summary>
		/// Minimum voltage regulator output (<i>V</i><i><sub>RMIN</sub></i>) (less than or equal to 0).
		/// Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmin;

		/// <summary>
		/// Initializes a new instance of the <see cref="ExcIEEEDC3A"/> class
		/// </summary>
		public ExcIEEEDC3A(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ExcIEEEDC3A

}//end namespace ExcitationSystemDynamics
