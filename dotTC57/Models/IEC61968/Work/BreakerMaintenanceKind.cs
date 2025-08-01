///////////////////////////////////////////////////////////
//  BreakerMaintenanceKind.cs
//  Implementation of the Class BreakerMaintenanceKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:59 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.Work {
	/// <summary>
	/// Possible types of breaker maintenance work.
	/// </summary>
	public enum BreakerMaintenanceKind : int {

		/// <summary>
		/// External out-of-service inspection and maintenance.
		/// </summary>
		externalOutOfService,
		/// <summary>
		/// Internal (interrupter) inspection and maintenance (breaker out of service).
		/// </summary>
		internalOutOfService,
		/// <summary>
		/// Overhaul of breaker interrupter unit.
		/// </summary>
		interrupterOverhaul

	}//end BreakerMaintenanceKind

}//end namespace Work
