///////////////////////////////////////////////////////////
//  MacroPeriodKind.cs
//  Implementation of the Class MacroPeriodKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:14 AM
//  Original author: Marty
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// Kind of macro period for calculations on read / measured values.
	/// </summary>
	public enum MacroPeriodKind : int {

		/// <summary>
		/// Not applicable.
		/// </summary>
		none = 0,
		/// <summary>
		/// Captured during the billing period starting at midnight of the first day of the
		/// billing period (as defined by the billing cycle day). If during the current
		/// billing period, it specifies a period from the start of the current billing
		/// period until "now".
		/// </summary>
		billingPeriod = 8,
		/// <summary>
		/// Daily period starting at midnight. If for the current day, this specifies the
		/// time from midnight to "now".
		/// </summary>
		daily = 11,
		/// <summary>
		/// Monthly period starting at midnight on the first day of the month. If within
		/// the current month, this specifies the period from the start of the month until
		/// "now."
		/// </summary>
		monthly = 13,
		/// <summary>
		/// A season of time spanning multiple months. E.g. "Summer," "Spring," "Fall," and
		/// "Winter" based cycle. If within the current season, it specifies the period
		/// from the start of the current season until "now."
		/// </summary>
		seasonal = 22,
		/// <summary>
		/// Weekly period starting at midnight on the first day of the week and ending the
		/// instant before midnight the last day of the week. If within the current week,
		/// it specifies the period from the start of the week until "now."
		/// </summary>
		weekly = 24,
		/// <summary>
		/// For the period defined by the start and end of the TimePeriod element in the
		/// message.
		/// </summary>
		specifiedPeriod = 32

	}//end MacroPeriodKind

}//end namespace Metering
