///////////////////////////////////////////////////////////
//  ClearanceAction.cs
//  Implementation of the Class ClearanceAction
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:01 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.Operations {
	/// <summary>
	/// Action on clearance document as a switching step.
	/// </summary>
	public class ClearanceAction : SwitchingAction {

		/// <summary>
		/// Clearance action to perform.
		/// </summary>
		public ClearanceActionKind kind;
		/// <summary>
		/// Clearance associated with this clearance action.
		/// </summary>
		public TC57CIM.IEC61968.Operations.ClearanceDocument? Clearance;

		/// <summary>
		/// Initializes a new instance of the <see cref="ClearanceAction"/> class
		/// </summary>
		public ClearanceAction(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ClearanceAction

}//end namespace Operations
