///////////////////////////////////////////////////////////
//  TransformerCoreAdmittance.cs
//  Implementation of the Class TransformerCoreAdmittance
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:26 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Wires {
	/// <summary>
	/// The transformer core admittance.  Used to specify the core admittance of a
	/// transformer in a manner that can be shared among power transformers.
	/// </summary>
	public class TransformerCoreAdmittance : IdentifiedObject {

		/// <summary>
		/// Magnetizing branch susceptance (B mag).  The value can be positive or negative.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Susceptance? b;
		/// <summary>
		/// Zero sequence magnetizing branch susceptance.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Susceptance? b0;
		/// <summary>
		/// Magnetizing branch conductance (G mag).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Conductance? g;
		/// <summary>
		/// Zero sequence magnetizing branch conductance.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Conductance? g0;
		/// <summary>
		/// All transformer ends having this core admittance.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.TransformerEnd? TransformerEnd;

		/// <summary>
		/// Initializes a new instance of the <see cref="TransformerCoreAdmittance"/> class
		/// </summary>
		public TransformerCoreAdmittance(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end TransformerCoreAdmittance

}//end namespace Wires
