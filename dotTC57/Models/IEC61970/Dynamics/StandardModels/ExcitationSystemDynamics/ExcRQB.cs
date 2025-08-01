///////////////////////////////////////////////////////////
//  ExcRQB.cs
//  Implementation of the Class ExcRQB
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:55 AM
//  Original author: civanov
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// Excitation system type RQB (four-loop regulator, r?gulateur quatre boucles,
	/// developed in France) primarily used in nuclear or thermal generating units.
	/// This excitation system shall be always used together with power system
	/// stabilizer type PssRQB.
	/// </summary>
	public class ExcRQB : ExcitationSystemDynamics {

		/// <summary>
		/// Voltage reference input gain (<i>Ki0</i>).  Typical value = 12,7.
		/// </summary>
		public float ki0;
		/// <summary>
		/// Voltage input gain (<i>Ki1</i>).  Typical value = -16,8.
		/// </summary>
		public float ki1;
		/// <summary>
		/// OEL input gain (<i>KLIR</i>).  Typical value = 12,13.
		/// </summary>
		public float klir;
		/// <summary>
		/// Limiter gain (<i>KLUS</i>).  Typical value = 50.
		/// </summary>
		public float klus;
		/// <summary>
		/// Integrator limiter (<i>LSAT</i>).  Typical value = 5,73.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? lsat;
		/// <summary>
		/// Setpoint (<i>LUS</i>).  Typical value = 0,12.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? lus;
		/// <summary>
		/// Voltage input time constant (<i>MESU</i>) (>= 0).  Typical value = 0,02.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? mesu;
		/// <summary>
		/// Input time constant (<i>T4M</i>) (>= 0).  Typical value = 5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t4m;
		/// <summary>
		/// Lead lag time constant (<i>TC</i>) (>= 0).  Typical value = 0,02.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tc;
		/// <summary>
		/// Lead lag time constant (<i>TE</i>) (>= 0).  Typical value = 0,22.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? te;
		/// <summary>
		/// Exciter time constant (<i>TF</i>) (>= 0).  Typical value = 0,01.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tf;
		/// <summary>
		/// Maximum voltage reference limit (<i>UCMAX</i>) (&gt; ExcRQB.ucmin).  Typical value
		/// = 1,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ucmax;
		/// <summary>
		/// Minimum voltage reference limit (<i>UCMIN</i>) (&lt; ExcRQB.ucmax).  Typical value
		/// = 0,9.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ucmin;

		/// <summary>
		/// Initializes a new instance of the <see cref="ExcRQB"/> class
		/// </summary>
		public ExcRQB(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ExcRQB

}//end namespace ExcitationSystemDynamics
