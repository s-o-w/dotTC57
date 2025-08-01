///////////////////////////////////////////////////////////
//  WindGenType4IEC.cs
//  Implementation of the Class WindGenType4IEC
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:31 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics {
	/// <summary>
	/// IEC type 4 generator set model.
	/// Reference: IEC 61400-27-1:2015, 5.6.3.4.
	/// </summary>
	public class WindGenType4IEC : IdentifiedObject {

		/// <summary>
		/// Maximum active current ramp rate (<i>di</i><i><sub>pmax</sub></i>). It is a
		/// project-dependent parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? dipmax;
		/// <summary>
		/// Maximum reactive current ramp rate (<i>di</i><i><sub>qmax</sub></i>). It is a
		/// project-dependent parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? diqmax;
		/// <summary>
		/// Minimum reactive current ramp rate (<i>di</i><i><sub>qmin</sub></i>). It is a
		/// project-dependent parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? diqmin;
		/// <summary>
		/// Time constant (<i>T</i><i><sub>g</sub></i>) (>= 0). It is a type-dependent
		/// parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? tg;
		/// <summary>
		/// Wind turbine type 4B model with which this wind generator type 4 model is
		/// associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics.WindTurbineType4bIEC? WindTurbineType4bIEC;
		/// <summary>
		/// Wind turbine type 4A model with which this wind generator type 4 model is
		/// associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics.WindTurbineType4aIEC? WindTurbineType4aIEC;

		/// <summary>
		/// Initializes a new instance of the <see cref="WindGenType4IEC"/> class
		/// </summary>
		public WindGenType4IEC(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end WindGenType4IEC

}//end namespace WindDynamics
