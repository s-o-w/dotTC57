///////////////////////////////////////////////////////////
//  ExcAVR3.cs
//  Implementation of the Class ExcAVR3
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:52 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// Italian excitation system. It represents an exciter dynamo and electric
	/// regulator.
	/// </summary>
	public class ExcAVR3 : ExcitationSystemDynamics {

		/// <summary>
		/// Field voltage value 1 (<i>E</i><i><sub>1</sub></i>).  Typical value = 4,18.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? e1;
		/// <summary>
		/// Field voltage value 2 (<i>E</i><i><sub>2</sub></i>).  Typical value = 3,14.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? e2;
		/// <summary>
		/// AVR gain (<i>K</i><i><sub>A</sub></i>).  Typical value = 100.
		/// </summary>
		public float ka;
		/// <summary>
		/// Saturation factor at <i>E</i><i><sub>1</sub></i><i>
		/// </i>(<i>S[E</i><i><sub>1</sub></i><i>]</i>).  Typical value = 0,1.
		/// </summary>
		public float se1;
		/// <summary>
		/// Saturation factor at <i>E</i><i><sub>2</sub></i><i>
		/// </i>(<i>S[E</i><i><sub>2</sub></i><i>]</i>).  Typical value = 0,03.
		/// </summary>
		public float se2;
		/// <summary>
		/// AVR time constant (<i>T</i><i><sub>1</sub></i>) (>= 0).  Typical value = 20.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t1;
		/// <summary>
		/// AVR time constant (<i>T</i><i><sub>2</sub></i>) (>= 0).  Typical value = 1,6.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t2;
		/// <summary>
		/// AVR time constant (<i>T</i><i><sub>3</sub></i>) (>= 0).  Typical value = 0,66.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t3;
		/// <summary>
		/// AVR time constant (<i>T</i><i><sub>4</sub></i>) (>= 0).  Typical value = 0,07.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t4;
		/// <summary>
		/// Exciter time constant (<i>T</i><i><sub>E</sub></i>) (>= 0).  Typical value = 1.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? te;
		/// <summary>
		/// Minimum AVR output (<i>V</i><i><sub>RMN</sub></i>).  Typical value = -7,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmn;
		/// <summary>
		/// Maximum AVR output (<i>V</i><i><sub>RMX</sub></i>).  Typical value = 7,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmx;

		/// <summary>
		/// Constructor for ExcAVR3.
		/// </summary>
		public ExcAVR3(){

		}

    /// <summary>
    /// Dispose method for ExcAVR3.
    /// </summary>
    public override void Dispose(){

		}

	}//end ExcAVR3

}//end namespace ExcitationSystemDynamics
