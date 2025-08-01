///////////////////////////////////////////////////////////
//  MechanicalLoadUserDefined.cs
//  Implementation of the Class MechanicalLoadUserDefined
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:07 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Dynamics.StandardModels.MechanicalLoadDynamics;
namespace TC57CIM.IEC61970.Dynamics.UserDefinedModels
{
    /// <summary>
    /// Mechanical load function block whose dynamic behaviour is described by
    /// a user-defined model.
    /// </summary>
    public class MechanicalLoadUserDefined : MechanicalLoadDynamics {

		/// <summary>
		/// Behaviour is based on a proprietary model as opposed to a detailed model.
		/// true = user-defined model is proprietary with behaviour mutually understood by
		/// sending and receiving applications and parameters passed as general attributes
		/// false = user-defined model is explicitly defined in terms of control blocks and
		/// their input and output signals.
		/// </summary>
		public bool proprietary;

		/// <summary>
		/// Constructor for MechanicalLoadUserDefined.
		/// </summary>
		public MechanicalLoadUserDefined(){

		}

    /// <summary>
    /// Dispose method for MechanicalLoadUserDefined.
    /// </summary>
    public override void Dispose(){

		}

	}//end MechanicalLoadUserDefined

}//end namespace UserDefinedModels
