///////////////////////////////////////////////////////////
//  MeasurementAction.cs
//  Implementation of the Class MeasurementAction
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:15 AM
//  Original author: marga
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.Operations {
	/// <summary>
	/// Measurement taken as a switching step.
	/// </summary>
	public class MeasurementAction : SwitchingAction {

		/// <summary>
		/// The measurement that the measurement action is performed on
		/// </summary>
		public TC57CIM.IEC61970.Base.Meas.Measurement? Measurement;

		/// <summary>
		/// Initializes a new instance of the <see cref="MeasurementAction"/> class
		/// </summary>
		public MeasurementAction(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end MeasurementAction

}//end namespace Operations
