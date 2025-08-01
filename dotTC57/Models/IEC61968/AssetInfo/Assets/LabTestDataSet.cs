///////////////////////////////////////////////////////////
//  LabTestDataSet.cs
//  Implementation of the Class LabTestDataSet
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:14 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// Results of testing done by a lab.
	/// </summary>
	public class LabTestDataSet : ProcedureDataSet {

		/// <summary>
		/// Conclusion drawn from test results.
		/// </summary>
		public string? conclusion;
		/// <summary>
		/// Description of confidence in conclusion.
		/// </summary>
		public string? conclusionConfidence;
		/// <summary>
		/// Reason for performing test.
		/// </summary>
		public TestReason reasonForTest;
		/// <summary>
		/// Identity of lab equipment used to perform test.
		/// </summary>
		public string? testEquipmentID;
		/// <summary>
		/// Test lab which produced this set of lab test results.
		/// </summary>
		public TC57CIM.IEC61968.AssetInfo.Assets.AssetTestLab? AssetTestLab;
		/// <summary>
		/// Specimen on which lab testing done in determining results.
		/// </summary>
		public TC57CIM.IEC61968.AssetInfo.Assets.Specimen? Specimen;

		/// <summary>
		/// Initializes a new instance of the <see cref="LabTestDataSet"/> class
		/// </summary>
		public LabTestDataSet(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end LabTestDataSet

}//end namespace Assets
