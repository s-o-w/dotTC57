///////////////////////////////////////////////////////////
//  WindDynamicsLookupTable.cs
//  Implementation of the Class WindDynamicsLookupTable
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:31 AM
//  Original author: civanov
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics {
	/// <summary>
	/// Look up table for the purpose of wind standard models.
	/// </summary>
	public class WindDynamicsLookupTable : IdentifiedObject {

		/// <summary>
		/// Input value (<i>x</i>) for the lookup table function.
		/// </summary>
		public float input;
		/// <summary>
		/// Type of the lookup table function.
		/// </summary>
		public WindLookupTableFunctionKind lookupTableFunctionType;
		/// <summary>
		/// Output value (<i>y</i>) for the lookup table function.
		/// </summary>
		public float output;
		/// <summary>
		/// Sequence numbers of the pairs of the input (<i>x</i>) and the output (<i>y</i>)
		/// of the lookup table function.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? sequence;
		/// <summary>
		/// The frequency and active power wind plant control model with which this wind
		/// dynamics lookup table is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics.WindPlantFreqPcontrolIEC? WindPlantFreqPcontrolIEC;
		/// <summary>
		/// The voltage and reactive power wind plant control model with which this wind
		/// dynamics lookup table is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics.WindPlantReactiveControlIEC? WindPlantReactiveControlIEC;
		/// <summary>
		/// The grid protection model with which this wind dynamics lookup table is
		/// associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics.WindProtectionIEC? WindProtectionIEC;
		/// <summary>
		/// The QP and QU limitation model with which this wind dynamics lookup table is
		/// associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics.WindContQPQULimIEC? WindContQPQULimIEC;
		/// <summary>
		/// The current control limitation model with which this wind dynamics lookup table
		/// is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics.WindContCurrLimIEC? WindContCurrLimIEC;
		/// <summary>
		/// The P control type 3 model with which this wind dynamics lookup table is
		/// associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics.WindContPType3IEC? WindContPType3IEC;
		/// <summary>
		/// The rotor resistance control model with which this wind dynamics lookup table
		/// is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics.WindContRotorRIEC? WindContRotorRIEC;
		/// <summary>
		/// The pitch control power model with which this wind dynamics lookup table is
		/// associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics.WindPitchContPowerIEC? WindPitchContPowerIEC;
		/// <summary>
		/// The generator type 3B model with which this wind dynamics lookup table is
		/// associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics.WindGenType3bIEC? WindGenType3bIEC;

		/// <summary>
		/// Initializes a new instance of the <see cref="WindDynamicsLookupTable"/> class
		/// </summary>
		public WindDynamicsLookupTable(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end WindDynamicsLookupTable

}//end namespace WindDynamics
