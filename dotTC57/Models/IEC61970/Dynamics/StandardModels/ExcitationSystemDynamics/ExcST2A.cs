///////////////////////////////////////////////////////////
//  ExcST2A.cs
//  Implementation of the Class ExcST2A
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:55 AM
//  Original author: tsaxton
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// Modified IEEE ST2A static excitation system with another lead-lag block added
	/// to match the model defined by WECC.
	/// </summary>
	public class ExcST2A : ExcitationSystemDynamics {

		/// <summary>
		/// Maximum field voltage (<i>Efdmax</i>) (>= 0).  Typical value = 99.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? efdmax;
		/// <summary>
		/// Voltage regulator gain (<i>Ka</i>) (> 0).  Typical value = 120.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ka;
		/// <summary>
		/// Rectifier loading factor proportional to commutating reactance (<i>Kc</i>) (>=
		/// 0).  Typical value = 1,82.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kc;
		/// <summary>
		/// Exciter constant related to self-excited field (<i>Ke</i>).  Typical value = 1.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ke;
		/// <summary>
		/// Excitation control system stabilizer gains (<i>kf</i>) (>= 0).  Typical value =
		/// 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kf;
		/// <summary>
		/// Potential circuit gain coefficient (<i>K</i><i><sub>i</sub></i>) (>= 0).
		/// Typical value = 8.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ki;
		/// <summary>
		/// Potential circuit gain coefficient (<i>K</i><i><sub>p</sub></i>) (>= 0).
		/// Typical value = 4,88.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kp;
		/// <summary>
		/// Voltage regulator time constant (<i>Ta</i>) (> 0).  Typical value = 0,15.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? ta;
		/// <summary>
		/// Voltage regulator time constant (<i>Tb</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tb;
		/// <summary>
		/// Voltage regulator time constant (<i>Tc</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tc;
		/// <summary>
		/// Exciter time constant, integration rate associated with exciter control
		/// (<i>Te</i>) (> 0).  Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? te;
		/// <summary>
		/// Excitation control system stabilizer time constant (<i>Tf</i>) (>= 0).  Typical
		/// value = 0,7.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tf;
		/// <summary>
		/// UEL input (<i>UELin</i>).
		/// true = HV gate
		/// false = add to error signal.
		/// Typical value = false.
		/// </summary>
		public bool uelin;
		/// <summary>
		/// Maximum voltage regulator outputs (<i>Vrmax</i>) (> 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmax;
		/// <summary>
		/// Minimum voltage regulator outputs (<i>Vrmin</i>) (less than 0).  Typical value = -1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmin;

		/// <summary>
		/// Initializes a new instance of the <see cref="ExcST2A"/> class
		/// </summary>
		public ExcST2A(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ExcST2A

}//end namespace ExcitationSystemDynamics
