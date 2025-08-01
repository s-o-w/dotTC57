///////////////////////////////////////////////////////////
//  ExcBBC.cs
//  Implementation of the Class ExcBBC
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:52 AM
//  Original author: tsaxton
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// Transformer fed static excitation system (static with ABB regulator). This
	/// model represents a static excitation system in which a gated thyristor bridge
	/// fed by a transformer at the main generator terminals feeds the main generator
	/// directly.
	/// </summary>
	public class ExcBBC : ExcitationSystemDynamics {

		/// <summary>
		/// Maximum open circuit exciter voltage (<i>Efdmax</i>) (> ExcBBC.efdmin).
		/// Typical value = 5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? efdmax;
		/// <summary>
		/// Minimum open circuit exciter voltage (<i>Efdmin</i>) (less than ExcBBC.efdmax).
		/// Typical value = -5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? efdmin;
		/// <summary>
		/// Steady state gain (<i>K</i>) (not = 0).  Typical value = 300.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? k;
		/// <summary>
		/// Supplementary signal routing selector (<i>switch</i>).
		/// true = <i>Vs</i> connected to 3rd summing point
		/// false =  <i>Vs</i> connected to 1st summing point (see diagram).
		/// Typical value = false.
		/// </summary>
		public bool signalSwitch;
		/// <summary>
		/// Controller time constant (<i>T1</i>) (>= 0).  Typical value = 6.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t1;
		/// <summary>
		/// Controller time constant (<i>T2</i>) (>= 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t2;
		/// <summary>
		/// Lead/lag time constant (<i>T3</i>) (>= 0).  If = 0, block is bypassed.  Typical
		/// value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t3;
		/// <summary>
		/// Lead/lag time constant (<i>T4</i>) (>= 0).  If = 0, block is bypassed.  Typical
		/// value = 0,01.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t4;
		/// <summary>
		/// Maximum control element output (<i>Vrmax</i>) (> ExcBBC.vrmin).  Typical value
		/// = 5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmax;
		/// <summary>
		/// Minimum control element output (<i>Vrmin</i>) (less than ExcBBC.vrmax).  Typical value = -5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vrmin;
		/// <summary>
		/// Effective excitation transformer reactance (<i>Xe</i>) (>= 0).  <i>Xe</i>
		/// models the regulation of the transformer/rectifier unit.  Typical value = 0,05.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? xe;

		/// <summary>
		/// Constructor for ExcBBC.
		/// </summary>
		public ExcBBC(){

		}

    /// <summary>
    /// Dispose method for ExcBBC.
    /// </summary>
    public override void Dispose(){

		}

	}//end ExcBBC

}//end namespace ExcitationSystemDynamics
