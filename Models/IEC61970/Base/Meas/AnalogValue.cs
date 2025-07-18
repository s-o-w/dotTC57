﻿///////////////////////////////////////////////////////////
//  AnalogValue.cs
//  Implementation of the Class AnalogValue
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:39 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Meas {
	/// <summary>
	/// AnalogValue represents an analog MeasurementValue.
	/// </summary>
	public class AnalogValue : MeasurementValue {

		/// <summary>
		/// The value to supervise.
		/// </summary>
		public float value;
		/// <summary>
		/// The Control variable associated with the MeasurementValue.
		/// </summary>
		public TC57CIM.IEC61970.Base.Meas.AnalogControl AnalogControl;

		public AnalogValue(){

		}

		~AnalogValue(){

		}

		public override void Dispose(){

		}

	}//end AnalogValue

}//end namespace Meas