///////////////////////////////////////////////////////////
//  DynamicsFunctionBlock.cs
//  Implementation of the Class DynamicsFunctionBlock
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:49 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Dynamics.StandardModels {
	/// <summary>
	/// Abstract parent class for all Dynamics function blocks.
	/// </summary>
	public class DynamicsFunctionBlock : IdentifiedObject {

		/// <summary>
		/// Function block used indicator.
		/// true = use of function block is enabled
		/// false = use of function block is disabled.
		/// </summary>
		public bool enabled;

		/// <summary>
		/// Constructor for DynamicsFunctionBlock.
		/// </summary>
		public DynamicsFunctionBlock(){

		}

    /// <summary>
    /// Dispose method for DynamicsFunctionBlock.
    /// </summary>
    public override void Dispose(){

		}

	}//end DynamicsFunctionBlock

}//end namespace StandardModels
