///////////////////////////////////////////////////////////
//  WorkFlowStep.cs
//  Implementation of the Class WorkFlowStep
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:33 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.InfIEC61968.InfWork {
	/// <summary>
	/// A pre-defined set of work steps for a given type of work.
	/// </summary>
	public class WorkFlowStep : WorkIdentifiedObject {

		/// <summary>
		/// Used to define dependencies of each work flow step, which is for the instance
		/// of WorkTask associated with a given instance of WorkFlow.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? sequenceNumber;
		/// <summary>
		/// The status
		/// </summary>
		public TC57CIM.IEC61968.Common.Status? status;
		/// <summary>
		/// The work
		/// </summary>
		public TC57CIM.IEC61968.Work.Work? Work;
		/// <summary>
		/// The work tasks
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfWork.OldWorkTask? WorkTasks;

		/// <summary>
		/// Initializes a new instance of the <see cref="WorkFlowStep"/> class
		/// </summary>
		public WorkFlowStep(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end WorkFlowStep

}//end namespace InfWork
