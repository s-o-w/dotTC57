///////////////////////////////////////////////////////////
//  PssWECC.cs
//  Implementation of the Class PssWECC
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:17 AM
//  Original author: tsaxton
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.PowerSystemStabilizerDynamics {
	/// <summary>
	/// Dual input power system stabilizer, based on IEEE type 2, with modified output
	/// limiter defined by WECC (Western Electricity Coordinating Council, USA).
	/// </summary>
	public class PssWECC : PowerSystemStabilizerDynamics {

		/// <summary>
		/// Type of input signal #1 (rotorAngularFrequencyDeviation, busFrequencyDeviation,
		/// generatorElectricalPower, generatorAcceleratingPower, busVoltage, or
		/// busVoltageDerivative - shall be different than PssWECC.inputSignal2Type).
		/// Typical value = rotorAngularFrequencyDeviation.
		/// </summary>
		public InputSignalKind inputSignal1Type;
		/// <summary>
		/// Type of input signal #2 (rotorAngularFrequencyDeviation, busFrequencyDeviation,
		/// generatorElectricalPower, generatorAcceleratingPower, busVoltage,
		/// busVoltageDerivative - shall be different than PssWECC.inputSignal1Type).
		/// Typical value = busVoltageDerivative.
		/// </summary>
		public InputSignalKind inputSignal2Type;
		/// <summary>
		/// Input signal 1 gain (<i>K</i><i><sub>1</sub></i>).  Typical value = 1,13.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? k1;
		/// <summary>
		/// Input signal 2 gain (<i>K</i><i><sub>2</sub></i>).  Typical value = 0,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? k2;
		/// <summary>
		/// Input signal 1 transducer time constant (<i>T</i><i><sub>1</sub></i>) (>= 0).
		/// Typical value = 0,037.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t1;
		/// <summary>
		/// Lag time constant (<i>T</i><i><sub>10</sub></i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t10;
		/// <summary>
		/// Input signal 2 transducer time constant (<i>T</i><i><sub>2</sub></i>) (>= 0).
		/// Typical value = 0,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t2;
		/// <summary>
		/// Stabilizer washout time constant (<i>T</i><i><sub>3</sub></i>) (>= 0).  Typical
		/// value = 9,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t3;
		/// <summary>
		/// Stabilizer washout time lag constant (<i>T</i><i><sub>4</sub></i>) (>= 0).
		/// Typical value = 9,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t4;
		/// <summary>
		/// Lead time constant (<i>T</i><i><sub>5</sub></i>) (>= 0).  Typical value = 1,7.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t5;
		/// <summary>
		/// Lag time constant (<i>T</i><i><sub>6</sub></i>) (>= 0).  Typical value = 1,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t6;
		/// <summary>
		/// Lead time constant (<i>T</i><i><sub>7</sub></i>) (>= 0).  Typical value = 1,7.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t7;
		/// <summary>
		/// Lag time constant (<i>T</i><i><sub>8</sub></i>) (>= 0).  Typical value = 1,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t8;
		/// <summary>
		/// Lead time constant (<i>T</i><i><sub>9</sub></i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t9;
		/// <summary>
		/// Minimum value for voltage compensator output (<i>V</i><i><sub>CL</sub></i>).
		/// Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vcl;
		/// <summary>
		/// Maximum value for voltage compensator output (<i>V</i><i><sub>CU</sub></i>).
		/// Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vcu;
		/// <summary>
		/// Maximum output signal (<i>Vsmax</i>) (greater than PssWECC.vsmin). Typical value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vsmax;
		/// <summary>
		/// Minimum output signal (<i>Vsmin</i>) (less than PssWECC.vsmax). Typical value = -0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vsmin;

		/// <summary>
		/// Initializes a new instance of the <see cref="PssWECC"/> class
		/// </summary>
		public PssWECC(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end PssWECC

}//end namespace PowerSystemStabilizerDynamics
