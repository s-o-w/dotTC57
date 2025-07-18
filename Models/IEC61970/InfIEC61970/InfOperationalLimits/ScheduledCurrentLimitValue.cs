﻿///////////////////////////////////////////////////////////
//  ScheduledCurrentLimitValue.cs
//  Implementation of the Class ScheduledCurrentLimitValue
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:20 AM
//  Original author: kdemaree
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.InfIEC61970.InfOperationalLimits {
	/// <summary>
	/// A current limit that is scheduled.
	/// </summary>
	public class ScheduledCurrentLimitValue : ScheduledLimitValue {

		/// <summary>
		/// The current flow limit value applicable at the scheduled time.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.CurrentFlow value;

		public ScheduledCurrentLimitValue(){

		}

		~ScheduledCurrentLimitValue(){

		}

		public override void Dispose(){

		}

	}//end ScheduledCurrentLimitValue

}//end namespace InfOperationalLimits