///////////////////////////////////////////////////////////
//  ReportingSuperGroup.cs
//  Implementation of the Class ReportingSuperGroup
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:20 AM
//  Original author: kdd
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Core {
	/// <summary>
	/// A reporting super group, groups reporting groups for a higher level report.
	/// </summary>
	public class ReportingSuperGroup : IdentifiedObject {

		/// <summary>
		/// Reporting groups that are grouped under this super group.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.ReportingGroup? ReportingGroup;

		/// <summary>
		/// Initializes a new instance of the <see cref="ReportingSuperGroup"/> class
		/// </summary>
		public ReportingSuperGroup(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ReportingSuperGroup

}//end namespace Core
