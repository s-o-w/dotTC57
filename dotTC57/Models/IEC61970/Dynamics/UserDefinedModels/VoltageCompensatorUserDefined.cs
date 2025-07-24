///////////////////////////////////////////////////////////
//  VoltageCompensatorUserDefined.cs
//  Implementation of the Class VoltageCompensatorUserDefined
//  Created on:      23-Jul-2025
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Dynamics.StandardModels.VoltageCompensatorDynamics;
namespace TC57CIM.IEC61970.Dynamics.UserDefinedModels {
	/// <summary>
	/// Voltage compensator function block whose dynamic
	/// behaviour is described by a user-defined model.
	/// </summary>
	public class VoltageCompensatorUserDefined : VoltageCompensatorDynamics {

		/// <summary>
		/// Behaviour is based on a proprietary model as opposed to a detailed model.
		/// true = user-defined model is proprietary with behaviour mutually understood by
		/// sending and receiving applications and parameters passed as general attributes
		/// false = user-defined model is explicitly defined in terms of control blocks and
		/// their input and output signals.
		/// </summary>
		public bool proprietary;

		/// <summary>
		/// Constructor for VoltageCompensatorUserDefined.
		/// </summary>
		public VoltageCompensatorUserDefined(){

		}

		/// <summary>
		/// Dispose method for VoltageCompensatorUserDefined.
		/// </summary>
		public override void Dispose(){

		}

	}//end VoltageCompensatorUserDefined
}
