///////////////////////////////////////////////////////////
//  Work.cs
//  Implementation of the Class Work
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:32 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.Work {
	/// <summary>
	/// Document used to request, initiate, track and record work.
	/// </summary>
	public class Work : BaseWork {

		/// <summary>
		/// Date and time work was requested.
		/// </summary>
		public System.DateTime? requestDateTime;
		/// <summary>
		/// Work order number (or other unique identifying information) for this work.
		/// </summary>
		public string? workOrderNumber;
		/// <summary>
		/// The erp project accounting
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpProjectAccounting? ErpProjectAccounting;
		/// <summary>
		/// All tasks in this work.
		/// </summary>
		public TC57CIM.IEC61968.Work.WorkTask? WorkTasks;
		/// <summary>
		/// The project
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfWork.Project? Project;

		/// <summary>
		/// Initializes a new instance of the <see cref="Work"/> class
		/// </summary>
		public Work(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end Work

}//end namespace Work
