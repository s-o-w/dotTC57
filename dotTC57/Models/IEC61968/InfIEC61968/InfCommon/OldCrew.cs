///////////////////////////////////////////////////////////
//  OldCrew.cs
//  Implementation of the Class OldCrew
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:17 AM
///////////////////////////////////////////////////////////

using TC57CIM.IEC61968.Common;
namespace TC57CIM.IEC61968.InfIEC61968.InfCommon {
	/// <summary>
	/// A crew is a group of people with specific skills, tools, and vehicles.
	/// </summary>
	public class OldCrew : Crew {

		/// <summary>
		/// Classification by utility's work management standards and practices.
		/// </summary>
		public string? type;
		/// <summary>
		/// The shift patterns
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfWork.ShiftPattern? ShiftPatterns;
		/// <summary>
		/// The route
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfLocations.Route? Route;
		/// <summary>
		/// The locations
		/// </summary>
		public TC57CIM.IEC61968.Common.Location? Locations;
		/// <summary>
		/// All Assignments for this Crew.
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfWork.Assignment? Assignments;

		/// <summary>
		/// Initializes a new instance of the <see cref="OldCrew"/> class
		/// </summary>
		public OldCrew(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end OldCrew

}//end namespace InfCommon
