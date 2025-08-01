///////////////////////////////////////////////////////////
//  SwitchingStepGroup.cs
//  Implementation of the Class SwitchingStepGroup
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:27 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.Operations {
	/// <summary>
	/// A logical step, grouping atomic switching steps that are important to
	/// distinguish when they may change topology (e.g. placing a jumper between two
	/// cuts).
	/// </summary>
	public class SwitchingStepGroup {

		/// <summary>
		/// Descriptive information concerning the switching step group.
		/// </summary>
		public string? description;
		/// <summary>
		/// If true, the sequence number serves for presentation purposes only, and the
		/// activity itself may be executed at any time.
		/// </summary>
		public bool isFreeSequence;
		/// <summary>
		/// Describes the overall purpose of the steps in this switching step group.
		/// </summary>
		public string? purpose;
		/// <summary>
		/// Order of this activity in the sequence of activities within the switching plan.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? sequenceNumber;

		/// <summary>
		/// Initializes a new instance of the <see cref="SwitchingStepGroup"/> class
		/// </summary>
		public SwitchingStepGroup(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public virtual void Dispose(){

		}

	}//end SwitchingStepGroup

}//end namespace Operations
