///////////////////////////////////////////////////////////
//  WindType1or2UserDefined.cs
//  Implementation of the Class WindType1or2UserDefined
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:33 AM
//  Original author: civanov
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics;
namespace TC57CIM.IEC61970.Dynamics.UserDefinedModels {
	/// <summary>
	/// Wind type 1 or type 2 function block whose dynamic behaviour is described by
	/// a user-defined model.
	/// </summary>
	public class WindType1or2UserDefined : WindTurbineType1or2Dynamics {

		/// <summary>
		/// Behaviour is based on a proprietary model as opposed to a detailed model.
		/// true = user-defined model is proprietary with behaviour mutually understood by
		/// sending and receiving applications and parameters passed as general attributes
		/// false = user-defined model is explicitly defined in terms of control blocks and
		/// their input and output signals.
		/// </summary>
		public bool proprietary;
		/// <summary>
		/// Parameter of this proprietary user-defined model.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.UserDefinedModels.ProprietaryParameterDynamics? ProprietaryParameterDynamics;

		/// <summary>
		/// Constructor for WindType1or2UserDefined.
		/// </summary>
		public WindType1or2UserDefined(){

		}

    /// <summary>
    /// Dispose method for WindType1or2UserDefined.
    /// </summary>
    public override void Dispose(){

		}

	}//end WindType1or2UserDefined

}//end namespace UserDefinedModels
