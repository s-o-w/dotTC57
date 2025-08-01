///////////////////////////////////////////////////////////
//  GovHydroWPID.cs
//  Implementation of the Class GovHydroWPID
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:59 AM
//  Original author: tsaxton
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.TurbineGovernorDynamics {
	/// <summary>
	/// Woodward<sup>TM</sup> PID hydro governor.
	/// [Footnote: Woodward PID hydro governors are an example of suitable products
	/// available commercially. This information is given for the convenience of users
	/// of this document and does not constitute an endorsement by IEC of these
	/// products.]
	/// </summary>
	public class GovHydroWPID : TurbineGovernorDynamics {

		/// <summary>
		/// Turbine damping factor (<i>D</i>).  Unit = delta P / delta speed.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? d;
		/// <summary>
		/// Gate opening limit maximum (<i>Gatmax</i>) (> GovHydroWPID.gatmin).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? gatmax;
		/// <summary>
		/// Gate opening limit minimum (<i>Gatmin</i>) (&lt; GovHydroWPID.gatmax).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? gatmin;
		/// <summary>
		/// Gate position 1 (<i>Gv1</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? gv1;
		/// <summary>
		/// Gate position 2 (<i>Gv2</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? gv2;
		/// <summary>
		/// Gate position 3 (<i>Gv3</i>) (= 1,0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? gv3;
		/// <summary>
		/// Derivative gain (<i>Kd</i>).  Typical value = 1,11.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kd;
		/// <summary>
		/// Reset gain (<i>Ki</i>).  Typical value = 0,36.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ki;
		/// <summary>
		/// Proportional gain (<i>Kp</i>).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kp;
		/// <summary>
		/// Base for power values  (<i>MWbase</i>) (> 0).  Unit = MW.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower? mwbase;
		/// <summary>
		/// Output at <i>Gv1</i> PU of <i>MWbase</i> (<i>Pgv1</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? pgv1;
		/// <summary>
		/// Output at <i>Gv2</i> PU of <i>MWbase</i> (<i>Pgv2</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? pgv2;
		/// <summary>
		/// Output at <i>Gv3</i> PU of <i>MWbase</i> (<i>Pgv3</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? pgv3;
		/// <summary>
		/// Maximum power output (<i>Pmax</i>) (> GovHydroWPID.pmin).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? pmax;
		/// <summary>
		/// Minimum power output (<i>Pmin</i>) (&lt; GovHydroWPID.pmax).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? pmin;
		/// <summary>
		/// Permanent drop (<i>Reg</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? reg;
		/// <summary>
		/// Controller time constant (<i>Ta</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? ta;
		/// <summary>
		/// Gate servo time constant (<i>Tb</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tb;
		/// <summary>
		/// Speed detector time constant (<i>Treg</i>) (>= 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? treg;
		/// <summary>
		/// Water inertia time constant (<i>Tw</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tw;
		/// <summary>
		/// Maximum gate opening velocity (<i>Velmax</i>) (> GovHydroWPID.velmin).  Unit =
		/// PU / s.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? velmax;
		/// <summary>
		/// Maximum gate closing velocity (<i>Velmin</i>) (&lt; GovHydroWPID.velmax).  Unit =
		/// PU / s.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? velmin;

		/// <summary>
		/// Initializes a new instance of the <see cref="GovHydroWPID"/> class
		/// </summary>
		public GovHydroWPID(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end GovHydroWPID

}//end namespace TurbineGovernorDynamics
