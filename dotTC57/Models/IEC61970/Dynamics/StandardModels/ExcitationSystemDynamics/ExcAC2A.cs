///////////////////////////////////////////////////////////
//  ExcAC2A.cs
//  Implementation of the Class ExcAC2A
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:51 AM
//  Original author: tsaxton
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// Modified IEEE AC2A alternator-supplied rectifier excitation system with
	/// different field current limit.
	/// </summary>
	public class ExcAC2A : ExcitationSystemDynamics {

		/// <summary>
		/// Indicates if HV gate is active (<i>HVgate</i>).
		/// true = gate is used
		/// false = gate is not used.
		/// Typical value = true.
		/// </summary>
		public bool hvgate;
		/// <summary>
		/// Voltage regulator gain (<i>Ka</i>) (> 0).  Typical value = 400.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ka;
		/// <summary>
		/// Second stage regulator gain (<i>Kb</i>) (> 0).  Exciter field current
		/// controller gain.  Typical value = 25.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kb;
		/// <summary>
		/// Second stage regulator gain (<i>Kb1</i>). It is exciter field current
		/// controller gain used as alternative to <i>Kb</i> to represent a variant of the
		/// ExcAC2A model.  Typical value = 25.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kb1;
		/// <summary>
		/// Rectifier loading factor proportional to commutating reactance (<i>Kc</i>) (>=
		/// 0).  Typical value = 0,28.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kc;
		/// <summary>
		/// Demagnetizing factor, a function of exciter alternator reactances (<i>Kd</i>)
		/// (>= 0).  Typical value = 0,35.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kd;
		/// <summary>
		/// Exciter constant related to self-excited field (<i>Ke</i>).  Typical value = 1.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ke;
		/// <summary>
		/// Excitation control system stabilizer gains (<i>Kf</i>) (>= 0).  Typical value =
		/// 0,03.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kf;
		/// <summary>
		/// Exciter field current feedback gain (<i>Kh</i>) (>= 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kh;
		/// <summary>
		/// Exciter field current limiter gain (<i>Kl</i>).  Typical value = 10.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kl;
		/// <summary>
		/// Coefficient to allow different usage of the model (<i>Kl1</i>).  Typical value
		/// = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kl1;
		/// <summary>
		/// Coefficient to allow different usage of the model-speed coefficient (<i>Ks</i>)
		/// (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ks;
		/// <summary>
		/// Indicates if LV gate is active (<i>LVgate</i>).
		/// true = gate is used
		/// false = gate is not used.
		/// Typical value = true.
		/// </summary>
		public bool lvgate;
		/// <summary>
		/// Exciter saturation function value at the corresponding exciter voltage,
		/// <i>Ve</i><i><sub>1</sub></i>, back of commutating reactance
		/// (<i>Se[Ve</i><i><sub>1</sub></i><i>]</i>) (>= 0).  Typical value = 0,037.
		/// </summary>
		public float seve1;
		/// <summary>
		/// Exciter saturation function value at the corresponding exciter voltage,
		/// <i>Ve</i><i><sub>2</sub></i>, back of commutating reactance
		/// (<i>Se[Ve</i><i><sub>2</sub></i><i>]</i>) (>= 0).  Typical value = 0,012.
		/// </summary>
		public float seve2;
		/// <summary>
		/// Voltage regulator time constant (<i>Ta</i>) (> 0).  Typical value = 0,02.
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
		/// (<i>Te</i>) (> 0).  Typical value = 0,6.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? te;
		/// <summary>
		/// Excitation control system stabilizer time constant (<i>Tf</i>) (> 0).  Typical
		/// value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tf;
		/// <summary>
		/// Maximum voltage regulator output (<i>Vamax</i>) (> 0).  Typical value = 8.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vamax;
		/// <summary>
		/// Minimum voltage regulator output (<i>Vamin</i>) (less than 0).  Typical value = -8.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vamin;
		/// <summary>
		/// Exciter alternator output voltages back of commutating reactance at which
		/// saturation is defined (<i>Ve</i><i><sub>1</sub></i>) (> 0).  Typical value = 4,
		/// 4.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ve1;
		/// <summary>
		/// Exciter alternator output voltages back of commutating reactance at which
		/// saturation is defined (<i>Ve</i><i><sub>2</sub></i>) (> 0).  Typical value = 3,
		/// 3.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ve2;
		/// <summary>
		/// Exciter field current limit reference (<i>Vfemax</i>) (>= 0).  Typical value =
		/// 4,4.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vfemax;
		/// <summary>
		/// Maximum exciter field current (<i>Vlr</i>) (> 0).  Typical value = 4,4.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vlr;
		/// <summary>
		/// Maximum voltage regulator outputs (<i>Vrmax</i>) (> 0).  Typical value = 105.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmax;
		/// <summary>
		/// Minimum voltage regulator outputs (<i>Vrmin</i>) (less than 0).  Typical value = -95.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmin;

		/// <summary>
		/// Constructor for ExcAC2A.
		/// </summary>
		public ExcAC2A(){

		}

    /// <summary>
    /// Dispose method for ExcAC2A.
    /// </summary>
    public override void Dispose(){

		}

	}//end ExcAC2A

}//end namespace ExcitationSystemDynamics
