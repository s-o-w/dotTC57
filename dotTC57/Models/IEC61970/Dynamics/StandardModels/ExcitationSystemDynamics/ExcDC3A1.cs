///////////////////////////////////////////////////////////
//  ExcDC3A1.cs
//  Implementation of the Class ExcDC3A1
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:52 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// Modified old IEEE type 3 excitation system.
	/// </summary>
	public class ExcDC3A1 : ExcitationSystemDynamics {

		/// <summary>
		/// (<i>exclim</i>).
		/// true = lower limit of zero is applied to integrator output
		/// false = lower limit of zero not applied to integrator output.
		/// Typical value = true.
		/// </summary>
		public bool exclim;
		/// <summary>
		/// Voltage regulator gain (<i>Ka</i>) (> 0).  Typical value = 300.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ka;
		/// <summary>
		/// Exciter constant related to self-excited field (<i>Ke</i>).  Typical value = 1.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ke;
		/// <summary>
		/// Excitation control system stabilizer gain (<i>Kf</i>) (>= 0).  Typical value =
		/// 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kf;
		/// <summary>
		/// Potential circuit gain coefficient (<i>Ki</i>) (>= 0).  Typical value = 4,83.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ki;
		/// <summary>
		/// Potential circuit gain coefficient (<i>Kp</i>) (>= 0).  Typical value = 4,37.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kp;
		/// <summary>
		/// Voltage regulator time constant (<i>Ta</i>) (> 0).  Typical value = 0,01.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? ta;
		/// <summary>
		/// Exciter time constant, integration rate associated with exciter control
		/// (<i>Te</i>) (> 0).  Typical value = 1,83.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? te;
		/// <summary>
		/// Excitation control system stabilizer time constant (<i>Tf</i>) (>= 0).  Typical
		/// value = 0,675.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tf;
		/// <summary>
		/// Available exciter voltage limiter (<i>Vb1max</i>) (> 0).  Typical value = 11,63.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vb1max;
		/// <summary>
		/// Vb limiter indicator.
		/// true = exciter <i>Vbmax</i> limiter is active
		/// false = <i>Vb1max</i> is active.
		/// Typical value = true.
		/// </summary>
		public bool vblim;
		/// <summary>
		/// Available exciter voltage limiter (<i>Vbmax</i>) (> 0).  Typical value = 11,63.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vbmax;
		/// <summary>
		/// Maximum voltage regulator output (<i>Vrmax</i>) (&gt; ExcDC3A1.vrmin).  Typical
		/// value = 5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmax;
		/// <summary>
		/// Minimum voltage regulator output (<i>Vrmin</i>) (&lt; 0 and &lt; ExcDC3A1.vrmax).
		/// Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmin;

		/// <summary>
		/// Initializes a new instance of the <see cref="ExcDC3A1"/> class
		/// </summary>
		public ExcDC3A1(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ExcDC3A1

}//end namespace ExcitationSystemDynamics
