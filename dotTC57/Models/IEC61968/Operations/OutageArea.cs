///////////////////////////////////////////////////////////
//  OutageArea.cs
//  Implementation of the Class OutageArea
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:19 AM
//  Original author: Margaret
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.Operations {
	/// <summary>
	/// This defines the area covered by the Outage.
	/// </summary>
	public class OutageArea {

		/// <summary>
		/// This is the reported time of the first outage report
		/// </summary>
		public System.DateTime? earliestReportedTime;
		/// <summary>
		/// defines the number of meters served in the defined area.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? metersServed;
		/// <summary>
		/// defines the type of area that has the outage - county, state, zipcode, etc.
		/// </summary>
		public AreaKind outageAreaKind;
		/// <summary>
		/// The outage associated with the outage area.
		/// </summary>
		public TC57CIM.IEC61968.Operations.Outage? Outage;

		/// <summary>
		/// Initializes a new instance of the <see cref="OutageArea"/> class
		/// </summary>
		public OutageArea(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public virtual void Dispose(){

		}

	}//end OutageArea

}//end namespace Operations
