///////////////////////////////////////////////////////////
//  OperationalLimitDirectionKind.cs
//  Implementation of the Class OperationalLimitDirectionKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:10 AM
//  Original author: kdd
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.OperationalLimits {
	/// <summary>
	/// The direction attribute describes the side of  a limit that is a violation.
	/// </summary>
	public enum OperationalLimitDirectionKind : int {

		/// <summary>
		/// High means that a monitored value above the limit value is a violation.   If
		/// applied to a terminal flow, the positive direction is into the terminal.
		/// </summary>
		high,
		/// <summary>
		/// Low means a monitored value below the limit is a violation.  If applied to a
		/// terminal flow, the positive direction is into the terminal.
		/// </summary>
		low,
		/// <summary>
		/// An absoluteValue limit means that a monitored absolute value above the limit
		/// value is a violation.
		/// </summary>
		absoluteValue

	}//end OperationalLimitDirectionKind

}//end namespace OperationalLimits
