///////////////////////////////////////////////////////////
//  LinearShuntCompensatorPhase.cs
//  Implementation of the Class LinearShuntCompensatorPhase
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:06 AM
//  Original author: selaost1
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Wires {
	/// <summary>
	/// A per phase linear shunt compensator has banks or sections with equal
	/// admittance values.
	/// </summary>
	public class LinearShuntCompensatorPhase : ShuntCompensatorPhase {

		/// <summary>
		/// Susceptance per section of the phase if shunt compensator is wye connected.
		/// Susceptance per section phase to phase if shunt compensator is delta connected.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Susceptance? bPerSection;
		/// <summary>
		/// Conductance per section for this phase if shunt compensator is wye connected.
		/// Conductance per section phase to phase if shunt compensator is delta connected.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Conductance? gPerSection;

		/// <summary>
		/// Initializes a new instance of the <see cref="LinearShuntCompensatorPhase"/> class
		/// </summary>
		public LinearShuntCompensatorPhase(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end LinearShuntCompensatorPhase

}//end namespace Wires
