///////////////////////////////////////////////////////////
//  MaintenanceDataSet.cs
//  Implementation of the Class MaintenanceDataSet
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:14 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// The result of a maintenance activity, a type of Procedure, for a given
	/// attribute of an asset.
	/// </summary>
	public class MaintenanceDataSet : ProcedureDataSet {

		/// <summary>
		/// Condition of asset just following maintenance procedure.
		/// </summary>
		public string? conditionAfter;
		/// <summary>
		/// Description of the condition of the asset just prior to maintenance being
		/// performed.
		/// </summary>
		public string? conditionBefore;
		/// <summary>
		/// Code for the type of maintenance performed.
		/// </summary>
		public string? maintCode;

		/// <summary>
		/// Initializes a new instance of the <see cref="MaintenanceDataSet"/> class
		/// </summary>
		public MaintenanceDataSet(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end MaintenanceDataSet

}//end namespace Assets
