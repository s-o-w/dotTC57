///////////////////////////////////////////////////////////
//  ExcIEEEAC4A.cs
//  Implementation of the Class ExcIEEEAC4A
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:53 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// IEEE 421.5-2005 type AC4A model. The model represents type AC4A alternator-
	/// supplied controlled-rectifier excitation system which is quite different from
	/// the other types of AC systems. This high initial response excitation system
	/// utilizes a full thyristor bridge in the exciter output circuit.  The voltage
	/// regulator controls the firing of the thyristor bridges. The exciter alternator
	/// uses an independent voltage regulator to control its output voltage to a
	/// constant value. These effects are not modelled; however, transient loading
	/// effects on the exciter alternator are included.
	/// Reference: IEEE 421.5-2005, 6.4.
	/// </summary>
	public class ExcIEEEAC4A : ExcitationSystemDynamics {

		/// <summary>
		/// Voltage regulator gain (<i>K</i><i><sub>A</sub></i>) (> 0).  Typical value =
		/// 200.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ka;
		/// <summary>
		/// Rectifier loading factor proportional to commutating reactance
		/// (<i>K</i><i><sub>C</sub></i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kc;
		/// <summary>
		/// Voltage regulator time constant (<i>T</i><i><sub>A</sub></i>) (> 0).  Typical
		/// value = 0,015.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? ta;
		/// <summary>
		/// Voltage regulator time constant (<i>T</i><i><sub>B</sub></i>) (>= 0).  Typical
		/// value = 10.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tb;
		/// <summary>
		/// Voltage regulator time constant (<i>T</i><i><sub>C</sub></i>) (>= 0).  Typical
		/// value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tc;
		/// <summary>
		/// Maximum voltage regulator input limit (<i>V</i><i><sub>IMAX</sub></i>) (greater than 0).
		/// Typical value = 10.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vimax;
		/// <summary>
		/// Minimum voltage regulator input limit (<i>V</i><i><sub>IMIN</sub></i>) (less than 0).
		/// Typical value = -10.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vimin;
		/// <summary>
		/// Maximum voltage regulator output (<i>V</i><i><sub>RMAX</sub></i>) (greater than 0).
		/// Typical value = 5,64.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmax;
		/// <summary>
		/// Minimum voltage regulator output (<i>V</i><i><sub>RMIN</sub></i>) (less than 0).
		/// Typical value = -4,53.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmin;

		/// <summary>
		/// Initializes a new instance of the <see cref="ExcIEEEAC4A"/> class
		/// </summary>
		public ExcIEEEAC4A(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ExcIEEEAC4A

}//end namespace ExcitationSystemDynamics
