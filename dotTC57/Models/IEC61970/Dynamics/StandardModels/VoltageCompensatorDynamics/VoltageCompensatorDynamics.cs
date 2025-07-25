///////////////////////////////////////////////////////////
//  VoltageCompensatorDynamics.cs
//  Implementation of the Class VoltageCompensatorDynamics
//  Created on:      23-Jul-2025
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Dynamics.StandardModels;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.VoltageCompensatorDynamics {
	/// <summary>
	/// Voltage compensator function block whose behaviour is described by reference to a
	/// standard model or by definition of a user-defined model.
	/// </summary>
	public class VoltageCompensatorDynamics : DynamicsFunctionBlock {

		/// <summary>
		/// Power factor or VAr controller type 2 model with which this voltage compensator is
		/// associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.StandardModels.PFVArControllerType2Dynamics.PFVArControllerType2Dynamics? PFVArControllerType2Dynamics;

		/// <summary>
		/// Constructor for VoltageCompensatorDynamics.
		/// </summary>
		public VoltageCompensatorDynamics(){

		}

		/// <summary>
		/// Dispose method for VoltageCompensatorDynamics.
		/// </summary>
		public override void Dispose(){

		}

	}//end VoltageCompensatorDynamics

}//end namespace VoltageCompensatorDynamics
