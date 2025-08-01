///////////////////////////////////////////////////////////
//  GovSteamFV4.cs
//  Implementation of the Class GovSteamFV4
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:00 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.TurbineGovernorDynamics {
	/// <summary>
	/// Detailed electro-hydraulic governor for steam unit.
	/// </summary>
	public class GovSteamFV4 : TurbineGovernorDynamics {

		/// <summary>
		/// Minimum value of pressure regulator output (<i>Cpsmn</i>).  Typical value = -1.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? cpsmn;
		/// <summary>
		/// Maximum value of pressure regulator output (<i>Cpsmx</i>).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? cpsmx;
		/// <summary>
		/// Minimum value of regulator set-point (<i>Crmn</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? crmn;
		/// <summary>
		/// Maximum value of regulator set-point (<i>Crmx</i>).  Typical value = 1,2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? crmx;
		/// <summary>
		/// Derivative gain of pressure regulator (<i>Kdc</i>).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kdc;
		/// <summary>
		/// Frequency bias (reciprocal of droop) (<i>Kf1</i>).  Typical value = 20.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kf1;
		/// <summary>
		/// Frequency control (reciprocal of droop) (<i>Kf3</i>).  Typical value = 20.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kf3;
		/// <summary>
		/// Fraction  of total turbine output generated by HP part (<i>Khp</i>).  Typical
		/// value = 0,35.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? khp;
		/// <summary>
		/// Integral gain of pressure regulator (<i>Kic</i>).  Typical value = 0,0033.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kic;
		/// <summary>
		/// Integral gain of pressure feedback regulator (<i>Kip</i>).  Typical value = 0,5.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kip;
		/// <summary>
		/// Integral gain of electro-hydraulic regulator (<i>Kit</i>).  Typical value = 0,
		/// 04.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kit;
		/// <summary>
		/// First gain coefficient of  intercept valves characteristic (<i>Kmp1</i>).
		/// Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kmp1;
		/// <summary>
		/// Second gain coefficient of intercept valves characteristic (<i>Kmp2</i>).
		/// Typical value = 3,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kmp2;
		/// <summary>
		/// Proportional gain of pressure regulator (<i>Kpc</i>).  Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kpc;
		/// <summary>
		/// Proportional gain of pressure feedback regulator (<i>Kpp</i>).  Typical value =
		/// 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kpp;
		/// <summary>
		/// Proportional gain of electro-hydraulic regulator (<i>Kpt</i>).  Typical value =
		/// 0,3.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kpt;
		/// <summary>
		/// Maximum variation of fuel flow (<i>Krc</i>).  Typical value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? krc;
		/// <summary>
		/// Pressure loss due to flow friction in the boiler tubes (<i>Ksh</i>).  Typical
		/// value = 0,08.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ksh;
		/// <summary>
		/// Maximum negative power error (<i>Lpi</i>).  Typical value = -0,15.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? lpi;
		/// <summary>
		/// Maximum positive power error (<i>Lps</i>).  Typical value = 0,03.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? lps;
		/// <summary>
		/// Lower limit for frequency correction (<i>MN</i><i><sub>EF</sub></i>).  Typical
		/// value = -0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? mnef;
		/// <summary>
		/// Upper limit for frequency correction (<i>MX</i><i><sub>EF</sub></i>).  Typical
		/// value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? mxef;
		/// <summary>
		/// First value of pressure set point static characteristic (<i>Pr1</i>).  Typical
		/// value = 0,2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? pr1;
		/// <summary>
		/// Second value of pressure set point static characteristic, corresponding to
		/// <i>Ps0</i> = 1,0 PU (<i>Pr2</i>).  Typical value = 0,75.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? pr2;
		/// <summary>
		/// Minimum value of pressure set point static characteristic (<i>Psmn</i>).
		/// Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? psmn;
		/// <summary>
		/// Minimum value of integral regulator (<i>Rsmimn</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? rsmimn;
		/// <summary>
		/// Maximum value of integral regulator (<i>Rsmimx</i>).  Typical value = 1,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? rsmimx;
		/// <summary>
		/// Minimum value of integral regulator (<i>Rvgmn</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? rvgmn;
		/// <summary>
		/// Maximum value of integral regulator (<i>Rvgmx</i>).  Typical value = 1,2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? rvgmx;
		/// <summary>
		/// Minimum valve opening (<i>Srmn</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? srmn;
		/// <summary>
		/// Maximum valve opening (<i>Srmx</i>).  Typical value = 1,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? srmx;
		/// <summary>
		/// Intercept valves characteristic discontinuity point (<i>Srsmp</i>).  Typical
		/// value = 0,43.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? srsmp;
		/// <summary>
		/// Maximum regulator gate closing velocity (<i>Svmn</i>).  Typical value = -0,0333.
		///
		/// </summary>
		public float svmn;
		/// <summary>
		/// Maximum regulator gate opening velocity (<i>Svmx</i>).  Typical value = 0,0333.
		///
		/// </summary>
		public float svmx;
		/// <summary>
		/// Control valves rate opening time (<i>Ta</i>) (>= 0).  Typical value = 0,8.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? ta;
		/// <summary>
		/// Intercept valves rate opening time (<i>Tam</i>) (>= 0).  Typical value = 0,8.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tam;
		/// <summary>
		/// Control valves rate closing time (<i>Tc</i>) (>= 0).  Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tc;
		/// <summary>
		/// Intercept valves rate closing time (<i>Tcm</i>) (>= 0).  Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tcm;
		/// <summary>
		/// Derivative time constant of pressure regulator (<i>Tdc</i>) (>= 0).  Typical
		/// value = 90.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tdc;
		/// <summary>
		/// Time constant of fuel regulation (<i>Tf1</i>) (>= 0).  Typical value = 10.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tf1;
		/// <summary>
		/// Time constant of steam chest (<i>Tf2</i>) (>= 0).  Typical value = 10.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tf2;
		/// <summary>
		/// High pressure (HP) time constant of the turbine (<i>Thp</i>) (>= 0).  Typical
		/// value = 0,15.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? thp;
		/// <summary>
		/// Low pressure (LP) time constant of the turbine (<i>Tmp</i>) (>= 0).  Typical
		/// value = 0,4.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tmp;
		/// <summary>
		/// Reheater  time constant of the turbine (<i>Trh</i>) (>= 0).  Typical value = 10.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? trh;
		/// <summary>
		/// Boiler time constant (<i>Tv</i>) (>= 0).  Typical value = 60.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tv;
		/// <summary>
		/// Control valves servo time constant (<i>Ty</i>) (>= 0).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? ty;
		/// <summary>
		/// Coefficient of linearized equations of turbine (Stodola formulation) (<i>Y</i>).
		///  Typical value = 0,13.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? y;
		/// <summary>
		/// Minimum control valve position (<i>Yhpmn</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? yhpmn;
		/// <summary>
		/// Maximum control valve position (<i>Yhpmx</i>).  Typical value = 1,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? yhpmx;
		/// <summary>
		/// Minimum intercept valve position (<i>Ympmn</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ympmn;
		/// <summary>
		/// Maximum intercept valve position (<i>Ympmx</i>).  Typical value = 1,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ympmx;

		/// <summary>
		/// Initializes a new instance of the <see cref="GovSteamFV4"/> class
		/// </summary>
		public GovSteamFV4(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end GovSteamFV4

}//end namespace TurbineGovernorDynamics
