///////////////////////////////////////////////////////////
//  FieldSafetySupervisor.cs
//  Implementation of the Class FieldSafetySupervisor
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:11 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using TC57CIM.IEC61968.Common;
namespace TC57CIM.IEC61968.Operations {
	/// <summary>
	/// Crew member on work site responsible for all local safety measures for the work
	/// crew doing maintenance, construction and repair in a substation or on a power
	/// line/cable.
	/// </summary>
	public class FieldSafetySupervisor : CrewMember {

		/// <summary>
		/// All safety documents issued to this supervisor.
		/// </summary>
		public TC57CIM.IEC61968.Operations.SafetyDocument? IssuedSafetyDocuments;
		/// <summary>
		/// All safety documents released by this supervisor.
		/// </summary>
		public TC57CIM.IEC61968.Operations.SafetyDocument? ReleasedSafetyDocuments;

		/// <summary>
		/// Initializes a new instance of the <see cref="FieldSafetySupervisor"/> class
		/// </summary>
		public FieldSafetySupervisor(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end FieldSafetySupervisor

}//end namespace Operations
