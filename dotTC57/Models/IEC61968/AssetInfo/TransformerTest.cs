///////////////////////////////////////////////////////////
//  TransformerTest.cs
//  Implementation of the Class TransformerTest
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:29 AM
//  Original author: Tom
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.AssetInfo {
	/// <summary>
	/// Test result for transformer ends, such as short-circuit, open-circuit
	/// (excitation) or no-load test.
	/// </summary>
	public class TransformerTest : IdentifiedObject {

		/// <summary>
		/// Base power at which the tests are conducted, usually equal to the rateds of one
		/// of the involved transformer ends.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ApparentPower? basePower;
		/// <summary>
		/// Temperature at which the test is conducted.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Temperature? temperature;

		/// <summary>
		/// Initializes a new instance of the <see cref="TransformerTest"/> class
		/// </summary>
		public TransformerTest(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end TransformerTest

}//end namespace AssetInfo
