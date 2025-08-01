///////////////////////////////////////////////////////////
//  Equipment.cs
//  Implementation of the Class Equipment
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:50 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Core {
	/// <summary>
	/// The parts of a power system that are physical devices, electronic or mechanical.
	///
	/// </summary>
	public class Equipment : PowerSystemResource {

		/// <summary>
		/// The aggregate flag provides an alternative way of representing an aggregated
		/// (equivalent) element. It is applicable in cases when the dedicated classes for
		/// equivalent equipment do not have all of the attributes necessary to represent
		/// the required level of detail.  In case the flag is set to �true� the single
		/// instance of equipment represents multiple pieces of equipment that have been
		/// modelled together as an aggregate equivalent obtained by a network reduction
		/// procedure. Examples would be power transformers or synchronous machines
		/// operating in parallel modelled as a single aggregate power transformer or
		/// aggregate synchronous machine.
		/// The attribute is not used for EquivalentBranch, EquivalentShunt and
		/// EquivalentInjection.
		/// </summary>
		public bool aggregate;
		/// <summary>
		/// Specifies the availability of the equipment. True means the equipment is
		/// available for topology processing, which determines if the equipment is
		/// energized or not. False means that the equipment is treated by network
		/// applications as if it is not in the model.
		/// </summary>
		public bool inService;
		/// <summary>
		/// The equipment is enabled to participate in network analysis.  If unspecified,
		/// the value is assumed to be true.
		/// </summary>
		public bool networkAnalysisEnabled;
		/// <summary>
		/// Specifies the availability of the equipment under normal operating conditions.
		/// True means the equipment is available for topology processing, which determines
		/// if the equipment is energized or not. False means that the equipment is treated
		/// by network applications as if it is not in the model.
		/// </summary>
		public bool normallyInService;
		/// <summary>
		/// The weather station
		/// </summary>
		public TC57CIM.IEC61970.InfIEC61970.InfOperationalLimits.WeatherStation? WeatherStation;
		/// <summary>
		/// Limit dependencymodels organized under this equipment as a means for organizing
		/// the model in a tree view.
		/// </summary>
		public TC57CIM.IEC61970.InfIEC61970.InfOperationalLimits.LimitDependency? LimitDependencyModel;

		/// <summary>
		/// Initializes a new instance of the <see cref="Equipment"/> class
		/// </summary>
		public Equipment(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end Equipment

}//end namespace Core
