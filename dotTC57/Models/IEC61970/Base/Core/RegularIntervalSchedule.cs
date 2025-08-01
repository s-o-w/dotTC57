///////////////////////////////////////////////////////////
//  RegularIntervalSchedule.cs
//  Implementation of the Class RegularIntervalSchedule
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:19 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Core {
	/// <summary>
	/// The schedule has time points where the time between them is constant.
	/// </summary>
	public class RegularIntervalSchedule : BasicIntervalSchedule {

		/// <summary>
		/// The time for the last time point.  The value can be a time of day, not a
		/// specific date.
		/// </summary>
		public System.DateTime? endTime;
		/// <summary>
		/// The time between each pair of subsequent regular time points in sequence order.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? timeStep;
		/// <summary>
		/// The regular interval time point data values that define this schedule.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.RegularTimePoint? TimePoints;

		/// <summary>
		/// Initializes a new instance of the <see cref="RegularIntervalSchedule"/> class
		/// </summary>
		public RegularIntervalSchedule(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end RegularIntervalSchedule

}//end namespace Core
