///////////////////////////////////////////////////////////
//  GovCT2.cs
//  Implementation of the Class GovCT2
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:58 AM
//  Original author: tsaxton
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.TurbineGovernorDynamics {
	/// <summary>
	/// General governor with frequency-dependent fuel flow limit.  This model is a
	/// modification of the GovCT1<b> </b>model in order to represent the frequency-
	/// dependent fuel flow limit of a specific gas turbine manufacturer.
	/// </summary>
	public class GovCT2 : TurbineGovernorDynamics {

		/// <summary>
		/// Acceleration limiter setpoint (<i>Aset</i>).  Unit = PU / s.  Typical value =
		/// 10.
		/// </summary>
		public float aset;
		/// <summary>
		/// Speed governor deadband in PU speed (<i>db</i>).  In the majority of
		/// applications, it is recommended that this value be set to zero.  Typical value
		/// = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? db;
		/// <summary>
		/// Speed sensitivity coefficient (<i>Dm</i>).  <i>Dm</i> can represent either the
		/// variation of the engine power with the shaft speed or the variation of maximum
		/// power capability with shaft speed.  If it is positive it describes the falling
		/// slope of the engine speed verses power characteristic as speed increases. A
		/// slightly falling characteristic is typical for reciprocating engines and some
		/// aero-derivative turbines.  If it is negative the engine power is assumed to be
		/// unaffected by the shaft speed, but the maximum permissible fuel flow is taken
		/// to fall with falling shaft speed. This is characteristic of single-shaft
		/// industrial turbines due to exhaust temperature limits.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? dm;
		/// <summary>
		/// Frequency threshold 1 (<i>Flim1</i>).  Unit = Hz.  Typical value = 59.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Frequency? flim1;
		/// <summary>
		/// Frequency threshold 10 (<i>Flim10</i>).  Unit = Hz.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Frequency? flim10;
		/// <summary>
		/// Frequency threshold 2 (<i>Flim2</i>).  Unit = Hz.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Frequency? flim2;
		/// <summary>
		/// Frequency threshold 3 (<i>Flim3</i>).  Unit = Hz.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Frequency? flim3;
		/// <summary>
		/// Frequency threshold 4 (<i>Flim4</i>).  Unit = Hz.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Frequency? flim4;
		/// <summary>
		/// Frequency threshold 5 (<i>Flim5</i>).  Unit = Hz.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Frequency? flim5;
		/// <summary>
		/// Frequency threshold 6 (<i>Flim6</i>).  Unit = Hz.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Frequency? flim6;
		/// <summary>
		/// Frequency threshold 7 (<i>Flim7</i>).  Unit = Hz.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Frequency? flim7;
		/// <summary>
		/// Frequency threshold 8 (<i>Flim8</i>).  Unit = Hz.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Frequency? flim8;
		/// <summary>
		/// Frequency threshold 9 (<i>Flim9</i>).  Unit = Hz.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Frequency? flim9;
		/// <summary>
		/// Acceleration limiter gain (<i>Ka</i>).  Typical value = 10.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ka;
		/// <summary>
		/// Governor derivative gain (<i>Kdgov</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kdgov;
		/// <summary>
		/// Governor integral gain (<i>Kigov</i>).  Typical value = 0,45.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kigov;
		/// <summary>
		/// Load limiter integral gain for PI controller (<i>Kiload</i>).  Typical value =
		/// 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kiload;
		/// <summary>
		/// Power controller (reset) gain (<i>Kimw</i>).  The default value of 0,01
		/// corresponds to a reset time of 100 seconds.  A value of 0,001 corresponds to a
		/// relatively slow-acting load controller.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kimw;
		/// <summary>
		/// Governor proportional gain (<i>Kpgov</i>).  Typical value = 4.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kpgov;
		/// <summary>
		/// Load limiter proportional gain for PI controller (<i>Kpload</i>).  Typical
		/// value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kpload;
		/// <summary>
		/// Turbine gain (<i>Kturb</i>).  Typical value = 1,9168.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kturb;
		/// <summary>
		/// Load limiter reference value (<i>Ldref</i>).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ldref;
		/// <summary>
		/// Maximum value for speed error signal (<i>Maxerr</i>) (greater than GovCT2.minerr).
		/// Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? maxerr;
		/// <summary>
		/// Minimum value for speed error signal (<i>Minerr</i>) (less than GovCT2.maxerr).
		/// Typical value = -1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? minerr;
		/// <summary>
		/// Base for power values (<i>MWbase</i>) (> 0).  Unit = MW.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower? mwbase;
		/// <summary>
		/// Power limit 1 (<i>Plim1</i>).  Typical value = 0,8325.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? plim1;
		/// <summary>
		/// Power limit 10 (<i>Plim10</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? plim10;
		/// <summary>
		/// Power limit 2 (Plim2).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? plim2;
		/// <summary>
		/// Power limit 3 (<i>Plim3</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? plim3;
		/// <summary>
		/// Power limit 4 (<i>Plim4</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? plim4;
		/// <summary>
		/// Power limit 5 (<i>Plim5</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? plim5;
		/// <summary>
		/// Power limit 6 (<i>Plim6</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? plim6;
		/// <summary>
		/// Power limit 7 (<i>Plim7</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? plim7;
		/// <summary>
		/// Power limit 8 (<i>Plim8</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? plim8;
		/// <summary>
		/// Power Limit 9 (<i>Plim9</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? plim9;
		/// <summary>
		/// Ramp rate for frequency-dependent power limit (<i>Prate</i>).  Typical value =
		/// 0,017.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? prate;
		/// <summary>
		/// Permanent droop (<i>R</i>).  Typical value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? r;
		/// <summary>
		/// Minimum valve closing rate (<i>Rclose</i>).  Unit = PU / s.  Typical value = -
		/// 99.
		/// </summary>
		public float rclose;
		/// <summary>
		/// Maximum rate of load limit decrease (<i>Rdown</i>).  Typical value = -99.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? rdown;
		/// <summary>
		/// Maximum valve opening rate (<i>Ropen</i>).  Unit = PU / s.  Typical value = 99.
		///
		/// </summary>
		public float ropen;
		/// <summary>
		/// Feedback signal for droop (<i>Rselect</i>).  Typical value = electricalPower.
		/// </summary>
		public DroopSignalFeedbackKind rselect;
		/// <summary>
		/// Maximum rate of load limit increase (<i>Rup</i>).  Typical value = 99.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? rup;
		/// <summary>
		/// Acceleration limiter time constant (<i>Ta</i>) (>= 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? ta;
		/// <summary>
		/// Actuator time constant (<i>Tact</i>) (>= 0).  Typical value = 0,4.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tact;
		/// <summary>
		/// Turbine lag time constant (<i>Tb</i>) (>= 0).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tb;
		/// <summary>
		/// Turbine lead time constant (<i>Tc</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tc;
		/// <summary>
		/// Governor derivative controller time constant (<i>Tdgov</i>) (>= 0).  Typical
		/// value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tdgov;
		/// <summary>
		/// Transport time delay for diesel engine used in representing diesel engines
		/// where there is a small but measurable transport delay between a change in fuel
		/// flow setting and the development of torque (<i>Teng</i>) (>= 0).  <i>Teng</i>
		/// should be zero in all but special cases where this transport delay is of
		/// particular concern.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? teng;
		/// <summary>
		/// Load limiter time constant (<i>Tfload</i>) (>= 0).  Typical value = 3.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tfload;
		/// <summary>
		/// Electrical power transducer time constant (<i>Tpelec</i>) (>= 0).  Typical
		/// value = 2,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tpelec;
		/// <summary>
		/// Temperature detection lead time constant (<i>Tsa</i>) (>= 0).  Typical value =
		/// 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tsa;
		/// <summary>
		/// Temperature detection lag time constant (<i>Tsb</i>) (>= 0).  Typical value =
		/// 50.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tsb;
		/// <summary>
		/// Maximum valve position limit (<i>Vmax</i>) (greater than GovCT2.vmin).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vmax;
		/// <summary>
		/// Minimum valve position limit (<i>Vmin</i>) (less than GovCT2.vmax).  Typical value = 0,175.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vmin;
		/// <summary>
		/// No load fuel flow (<i>Wfnl</i>).  Typical value = 0,187.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? wfnl;
		/// <summary>
		/// Switch for fuel source characteristic to recognize that fuel flow, for a given
		/// fuel valve stroke, can be proportional to engine speed (<i>Wfspd</i>).
		/// true = fuel flow proportional to speed (for some gas turbines and diesel
		/// engines with positive displacement fuel injectors)
		/// false = fuel control system keeps fuel flow independent of engine speed.
		/// Typical value = false.
		/// </summary>
		public bool wfspd;

		/// <summary>
		/// Initializes a new instance of the <see cref="GovCT2"/> class
		/// </summary>
		public GovCT2(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end GovCT2

}//end namespace TurbineGovernorDynamics
