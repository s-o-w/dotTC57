///////////////////////////////////////////////////////////
//  InternalLocation.cs
//  Implementation of the Class InternalLocation
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:13 AM
//  Original author: marga
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.Work {
	/// <summary>
	/// Description of location internal to a building.
	/// </summary>
	public class InternalLocation : WorkLocation {

		/// <summary>
		/// Name of building where location is.
		/// </summary>
		public string? buildingName;
		/// <summary>
		/// Number of building where location is.
		/// </summary>
		public string? buildingNumber;
		/// <summary>
		/// Floor of location.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? floor;
		/// <summary>
		/// Room number of location.
		/// </summary>
		public string? roomNumber;

		/// <summary>
		/// Initializes a new instance of the <see cref="InternalLocation"/> class
		/// </summary>
		public InternalLocation(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end InternalLocation

}//end namespace Work
