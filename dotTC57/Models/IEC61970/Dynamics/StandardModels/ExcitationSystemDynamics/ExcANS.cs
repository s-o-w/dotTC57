///////////////////////////////////////////////////////////
//  ExcANS.cs
//  Implementation of the Class ExcANS
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:52 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// Italian excitation system. It represents static field voltage or excitation
	/// current feedback excitation system.
	/// </summary>
	public class ExcANS : ExcitationSystemDynamics {

		/// <summary>
		/// Governor control flag (<i>BLINT</i>).
		/// 0 = lead-lag regulator
		/// 1 = proportional integral regulator.
		/// Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? blint;
		/// <summary>
		/// Minimum exciter current (<i>I</i><i><sub>FMN</sub></i>).  Typical value = -5,2.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ifmn;
		/// <summary>
		/// Maximum exciter current (<i>I</i><i><sub>FMX</sub></i>).  Typical value = 6,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ifmx;
		/// <summary>
		/// Exciter gain (<i>K</i><i><sub>2</sub></i>).  Typical value = 20.
		/// </summary>
		public float k2;
		/// <summary>
		/// AVR gain (<i>K</i><i><sub>3</sub></i>).  Typical value = 1000.
		/// </summary>
		public float k3;
		/// <summary>
		/// Ceiling factor (<i>K</i><i><sub>CE</sub></i>).  Typical value = 1.
		/// </summary>
		public float kce;
		/// <summary>
		/// Feedback enabling (<i>K</i><i><sub>RVECC</sub></i>).
		/// 0 = open loop control
		/// 1 = closed loop control.
		/// Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? krvecc;
		/// <summary>
		/// Rate feedback signal flag (<i>K</i><i><sub>VFIF</sub></i>).
		/// 0 = output voltage of the exciter
		/// 1 = exciter field current.
		/// Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? kvfif;
		/// <summary>
		/// Time constant (<i>T</i><i><sub>1</sub></i>) (>= 0).  Typical value = 20.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t1;
		/// <summary>
		/// Time constant (<i>T</i><i><sub>2</sub></i>) (>= 0).  Typical value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t2;
		/// <summary>
		/// Time constant (<i>T</i><i><sub>3</sub></i>) (>= 0).  Typical value = 1,6.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t3;
		/// <summary>
		/// Exciter time constant (<i>T</i><i><sub>B</sub></i>) (>= 0).  Typical value = 0,
		/// 04.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tb;
		/// <summary>
		/// Minimum AVR output (<i>V</i><i><sub>RMN</sub></i>).  Typical value = -5,2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmn;
		/// <summary>
		/// Maximum AVR output (<i>V</i><i><sub>RMX</sub></i>).  Typical value = 6,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmx;

		/// <summary>
		/// Initializes a new instance of the <see cref="ExcANS"/> class
		/// </summary>
		public ExcANS(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ExcANS

}//end namespace ExcitationSystemDynamics
