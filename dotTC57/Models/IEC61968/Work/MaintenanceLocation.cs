///////////////////////////////////////////////////////////
//  MaintenanceLocation.cs
//  Implementation of the Class MaintenanceLocation
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:14 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.Work {
	/// <summary>
	/// Location where to perform maintenance work.
	/// </summary>
	public class MaintenanceLocation : WorkLocation {

		/// <summary>
		/// (if applicable) Name, identifier, or description of the block in which work is
		/// to occur.
		/// </summary>
		public string? block;
		/// <summary>
		/// (if applicable) Name, identifier, or description of the lot in which work is to
		/// occur.
		/// </summary>
		public string? lot;
		/// <summary>
		/// The names of streets at the nearest intersection to work area.
		/// </summary>
		public string? nearestIntersection;
		/// <summary>
		/// (if applicable) Name, identifier, or description of the subdivision in which
		/// work is to occur.
		/// </summary>
		public string? subdivision;

		/// <summary>
		/// Initializes a new instance of the <see cref="MaintenanceLocation"/> class
		/// </summary>
		public MaintenanceLocation(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end MaintenanceLocation

}//end namespace Work
