///////////////////////////////////////////////////////////
//  TestDataSet.cs
//  Implementation of the Class TestDataSet
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:27 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// Test results, usually obtained by a lab or other independent organisation.
	/// </summary>
	public class TestDataSet : ProcedureDataSet {

		/// <summary>
		/// Conclusion drawn from test results.
		/// </summary>
		public string? conclusion;
		/// <summary>
		/// Identifier of specimen used in inspection or test.
		/// </summary>
		public string? specimenID;
		/// <summary>
		/// Date and time the specimen was received by the lab.
		/// </summary>
		public System.DateTime? specimenToLabDateTime;

		/// <summary>
		/// Initializes a new instance of the <see cref="TestDataSet"/> class
		/// </summary>
		public TestDataSet(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end TestDataSet

}//end namespace Assets
