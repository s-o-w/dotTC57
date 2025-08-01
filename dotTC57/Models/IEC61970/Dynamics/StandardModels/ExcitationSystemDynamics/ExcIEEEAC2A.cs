///////////////////////////////////////////////////////////
//  ExcIEEEAC2A.cs
//  Implementation of the Class ExcIEEEAC2A
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:53 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// IEEE 421.5-2005 type AC2A model. The model represents a high initial response
	/// field-controlled alternator-rectifier excitation system. The alternator main
	/// exciter is used with non-controlled rectifiers. The type AC2A model is similar
	/// to that of type AC1A except for the inclusion of exciter time constant
	/// compensation and exciter field current limiting elements.
	/// Reference: IEEE 421.5-2005, 6.2.
	/// </summary>
	public class ExcIEEEAC2A : ExcitationSystemDynamics {

		/// <summary>
		/// Voltage regulator gain (<i>K</i><i><sub>A</sub></i>) (> 0).  Typical value =
		/// 400.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ka;
		/// <summary>
		/// Second stage regulator gain (<i>K</i><i><sub>B</sub></i>) (> 0).  Typical value
		/// = 25.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kb;
		/// <summary>
		/// Rectifier loading factor proportional to commutating reactance
		/// (<i>K</i><i><sub>C</sub></i>) (>= 0).  Typical value = 0,28.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kc;
		/// <summary>
		/// Demagnetizing factor, a function of exciter alternator reactances
		/// (<i>K</i><i><sub>D</sub></i>) (>= 0).  Typical value = 0,35.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kd;
		/// <summary>
		/// Exciter constant related to self-excited field (<i>K</i><i><sub>E</sub></i>)
		/// (>= 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ke;
		/// <summary>
		/// Excitation control system stabilizer gains (<i>K</i><i><sub>F</sub></i>) (>= 0).
		///  Typical value = 0,03.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kf;
		/// <summary>
		/// Exciter field current feedback gain (<i>K</i><i><sub>H</sub></i>) (>= 0).
		/// Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kh;
		/// <summary>
		/// Exciter saturation function value at the corresponding exciter voltage,
		/// <i>V</i><i><sub>E1</sub></i>, back of commutating reactance
		/// (<i>S</i><i><sub>E</sub></i><i>[V</i><i><sub>E1</sub></i><i>]</i>) (>= 0).
		/// Typical value = 0,037.
		/// </summary>
		public float seve1;
		/// <summary>
		/// Exciter saturation function value at the corresponding exciter voltage,
		/// <i>V</i><i><sub>E2</sub></i>, back of commutating reactance
		/// (<i>S</i><i><sub>E</sub></i><i>[V</i><i><sub>E2</sub></i><i>]</i>) (>= 0).
		/// Typical value = 0,012.
		/// </summary>
		public float seve2;
		/// <summary>
		/// Voltage regulator time constant (<i>T</i><i><sub>A</sub></i>) (> 0).  Typical
		/// value = 0,02.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? ta;
		/// <summary>
		/// Voltage regulator time constant (<i>T</i><i><sub>B</sub></i>) (>= 0).  Typical
		/// value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tb;
		/// <summary>
		/// Voltage regulator time constant (<i>T</i><i><sub>C</sub></i>) (>= 0).  Typical
		/// value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tc;
		/// <summary>
		/// Exciter time constant, integration rate associated with exciter control
		/// (<i>T</i><i><sub>E</sub></i>) (> 0).  Typical value = 0,6.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? te;
		/// <summary>
		/// Excitation control system stabilizer time constant
		/// (<i>T</i><i><sub>F</sub></i>) (> 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tf;
		/// <summary>
		/// Maximum voltage regulator output (<i>V</i><i><sub>AMAX</sub></i>) (greater than 0).
		/// Typical value = 8.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vamax;
		/// <summary>
		/// Minimum voltage regulator output (<i>V</i><i><sub>AMIN</sub></i>) (less than 0).
		/// Typical value = -8.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vamin;
		/// <summary>
		/// Exciter alternator output voltages back of commutating reactance at which
		/// saturation is defined (<i>V</i><i><sub>E1</sub></i>) (> 0).  Typical value = 4,
		/// 4.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ve1;
		/// <summary>
		/// Exciter alternator output voltages back of commutating reactance at which
		/// saturation is defined (<i>V</i><i><sub>E2</sub></i>) (> 0).  Typical value = 3,
		/// 3.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ve2;
		/// <summary>
		/// Exciter field current limit reference (<i>V</i><i><sub>FEMAX</sub></i>) (> 0).
		/// Typical value = 4,4.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vfemax;
		/// <summary>
		/// Maximum voltage regulator outputs (<i>V</i><i><sub>RMAX</sub></i>) (greater than 0).
		/// Typical value = 105.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmax;
		/// <summary>
		/// Minimum voltage regulator outputs (<i>V</i><i><sub>RMIN</sub></i>) (less than 0).
		/// Typical value = -95.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmin;

		/// <summary>
		/// Initializes a new instance of the <see cref="ExcIEEEAC2A"/> class
		/// </summary>
		public ExcIEEEAC2A(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ExcIEEEAC2A

}//end namespace ExcitationSystemDynamics
