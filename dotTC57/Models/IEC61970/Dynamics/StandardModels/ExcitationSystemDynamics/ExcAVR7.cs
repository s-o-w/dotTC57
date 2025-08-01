///////////////////////////////////////////////////////////
//  ExcAVR7.cs
//  Implementation of the Class ExcAVR7
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:52 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// IVO excitation system.
	/// </summary>
	public class ExcAVR7 : ExcitationSystemDynamics {

		/// <summary>
		/// Lead coefficient (<i>A</i><i><sub>1</sub></i>).  Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? a1;
		/// <summary>
		/// Lag coefficient (<i>A</i><i><sub>2</sub></i>).  Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? a2;
		/// <summary>
		/// Lead coefficient (<i>A</i><i><sub>3</sub></i>).  Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? a3;
		/// <summary>
		/// Lag coefficient (<i>A</i><i><sub>4</sub></i>).  Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? a4;
		/// <summary>
		/// Lead coefficient (<i>A</i><i><sub>5</sub></i>).  Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? a5;
		/// <summary>
		/// Lag coefficient (<i>A</i><i><sub>6</sub></i>).  Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? a6;
		/// <summary>
		/// Gain (<i>K</i><i><sub>1</sub></i>).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? k1;
		/// <summary>
		/// Gain (<i>K</i><i><sub>3</sub></i>).  Typical value = 3.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? k3;
		/// <summary>
		/// Gain (<i>K</i><i><sub>5</sub></i>).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? k5;
		/// <summary>
		/// Lead time constant (<i>T</i><i><sub>1</sub></i>) (greater than or equal to 0).  Typical value = 0,05.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t1;
		/// <summary>
		/// Lag time constant (<i>T</i><i><sub>2</sub></i>) (greater than or equal to 0).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t2;
		/// <summary>
		/// Lead time constant (<i>T</i><i><sub>3</sub></i>) (greater than or equal to 0).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t3;
		/// <summary>
		/// Lag time constant (<i>T</i><i><sub>4</sub></i>) (greater than or equal to 0).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t4;
		/// <summary>
		/// Lead time constant (<i>T</i><i><sub>5</sub></i>) (greater than or equal to 0).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t5;
		/// <summary>
		/// Lag time constant (<i>T</i><i><sub>6</sub></i>) (greater than or equal to 0).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t6;
		/// <summary>
		/// Lead-lag maximum limit (<i>Vmax1</i>) (greater than ExcAVR7.vmin1).  Typical value = 5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vmax1;
		/// <summary>
		/// Lead-lag maximum limit (<i>Vmax3</i>) (greater than ExcAVR7.vmin3).  Typical value = 5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vmax3;
		/// <summary>
		/// Lead-lag maximum limit (<i>Vmax5</i>) (greater than ExcAVR7.vmin5).  Typical value = 5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vmax5;
		/// <summary>
		/// Lead-lag minimum limit (<i>Vmin1</i>) (&lt; ExcAVR7.vmax1).  Typical value = -5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vmin1;
		/// <summary>
		/// Lead-lag minimum limit (<i>Vmin3</i>) (&lt; ExcAVR7.vmax3).  Typical value = -5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vmin3;
		/// <summary>
		/// Lead-lag minimum limit (<i>Vmin5</i>) (&lt; ExcAVR7.vmax5).  Typical value = -2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vmin5;

		/// <summary>
		/// Initializes a new instance of the <see cref="ExcAVR7"/> class
		/// </summary>
		public ExcAVR7(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ExcAVR7

}//end namespace ExcitationSystemDynamics
