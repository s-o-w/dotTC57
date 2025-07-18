﻿///////////////////////////////////////////////////////////
//  PowerSystemStabilizerUserDefined.cs
//  Implementation of the Class PowerSystemStabilizerUserDefined
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:15 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Dynamics.StandardModels.PowerSystemStabilizerDynamics;
namespace TC57CIM.IEC61970.Dynamics.UserDefinedModels {
	/// <summary>
	/// <font color="#0f0f0f">Power system stabilizer</font> function block whose
	/// dynamic behaviour is described by <font color="#0f0f0f">a user-defined model.
	/// </font>
	/// </summary>
	public class PowerSystemStabilizerUserDefined : PowerSystemStabilizerDynamics {

		/// <summary>
		/// Behaviour is based on a proprietary model as opposed to a detailed model.
		/// true = user-defined model is proprietary with behaviour mutually understood by
		/// sending and receiving applications and parameters passed as general attributes
		/// false = user-defined model is explicitly defined in terms of control blocks and
		/// their input and output signals.
		/// </summary>
		public bool proprietary;

		public PowerSystemStabilizerUserDefined(){

		}

		~PowerSystemStabilizerUserDefined(){

		}

		public override void Dispose(){

		}

	}//end PowerSystemStabilizerUserDefined

}//end namespace UserDefinedModels