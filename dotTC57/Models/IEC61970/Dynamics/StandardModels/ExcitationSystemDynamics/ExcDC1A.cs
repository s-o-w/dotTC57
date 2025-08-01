///////////////////////////////////////////////////////////
//  ExcDC1A.cs
//  Implementation of the Class ExcDC1A
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:52 AM
//  Original author: tsaxton
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// Modified IEEE DC1A direct current commutator exciter with speed input and
	/// without underexcitation limiters (UEL) inputs.
	/// </summary>
	public class ExcDC1A : ExcitationSystemDynamics {

		/// <summary>
		/// Exciter voltage at which exciter saturation is defined
		/// (<i>Efd</i><i><sub>1</sub></i>) (> 0).  Typical value = 3,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? efd1;
		/// <summary>
		/// Exciter voltage at which exciter saturation is defined
		/// (<i>Efd</i><i><sub>2</sub></i>) (> 0).  Typical value = 2,3.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? efd2;
		/// <summary>
		/// Maximum voltage exciter output limiter (<i>Efdmax</i>) (> ExcDC1A.efdmin).
		/// Typical value = 99.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? efdmax;
		/// <summary>
		/// Minimum voltage exciter output limiter (<i>Efdmin</i>) (less than ExcDC1A.efdmax).
		/// Typical value = -99.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? efdmin;
		/// <summary>
		/// (<i>exclim</i>).  IEEE standard is ambiguous about lower limit on exciter
		/// output.
		/// true = a lower limit of zero is applied to integrator output
		/// false = a lower limit of zero is not applied to integrator output.
		/// Typical value = true.
		/// </summary>
		public bool exclim;
		/// <summary>
		/// Voltage regulator gain (<i>Ka</i>) (> 0).  Typical value = 46.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ka;
		/// <summary>
		/// Exciter constant related to self-excited field (<i>Ke</i>).  Typical value = 0.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ke;
		/// <summary>
		/// Excitation control system stabilizer gain (<i>Kf</i>) (>= 0).  Typical value =
		/// 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kf;
		/// <summary>
		/// Coefficient to allow different usage of the model-speed coefficient (<i>Ks</i>).
		///  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ks;
		/// <summary>
		/// Exciter saturation function value at the corresponding exciter voltage,
		/// <i>Efd</i><i><sub>1</sub></i> (<i>Se[Eefd</i><i><sub>1</sub></i><i>]</i>) (>=
		/// 0).  Typical value = 0,33.
		/// </summary>
		public float seefd1;
		/// <summary>
		/// Exciter saturation function value at the corresponding exciter voltage,
		/// <i>Efd</i><i><sub>2</sub></i> (<i>Se[Eefd</i><i><sub>2</sub></i><i>]</i>) (>=
		/// 0).  Typical value = 0,1.
		/// </summary>
		public float seefd2;
		/// <summary>
		/// Voltage regulator time constant (<i>Ta</i>) (> 0).  Typical value = 0,06.
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
		/// (<i>Te</i>) (> 0).  Typical value = 0,46.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? te;
		/// <summary>
		/// Excitation control system stabilizer time constant (<i>Tf</i>) (> 0).  Typical
		/// value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tf;
		/// <summary>
		/// Maximum voltage regulator output (<i>Vrmax</i>) (> ExcDC1A.vrmin).  Typical
		/// value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmax;
		/// <summary>
		/// Minimum voltage regulator output (<i>Vrmin</i>) (less than 0 and less than ExcDC1A.vrmax).
		/// Typical value = -0,9.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmin;

		/// <summary>
		/// Constructor for ExcDC1A.
		/// </summary>
		public ExcDC1A(){

		}

    /// <summary>
    /// Dispose method for ExcDC1A.
    /// </summary>
    public override void Dispose(){

		}

	}//end ExcDC1A

}//end namespace ExcitationSystemDynamics
