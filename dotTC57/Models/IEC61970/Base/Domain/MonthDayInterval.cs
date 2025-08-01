///////////////////////////////////////////////////////////
//  MonthDayInterval.cs
//  Implementation of the Class MonthDayInterval
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:08 AM
//  Original author: selaost1
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Interval between two times specified as month and day.
	/// </summary>
	public class MonthDayInterval {

		/// <summary>
		/// End time of this interval.
		/// </summary>
		public MonthDay? end;
		/// <summary>
		/// Start time of this interval.
		/// </summary>
		public MonthDay? start;

		/// <summary>
		/// Initializes a new instance of the <see cref="MonthDayInterval"/> class
		/// </summary>
		public MonthDayInterval(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public virtual void Dispose(){

		}

	}//end MonthDayInterval

}//end namespace Domain
