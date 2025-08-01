///////////////////////////////////////////////////////////
//  EnergyTypeReference.cs
//  Implementation of the Class EnergyTypeReference
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:50 AM
//  Original author: selaost1
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.InfIEC61970.EnergyArea {
	/// <summary>
	/// Represents an energy type reference in the energy area.
	/// </summary>
	public class EnergyTypeReference : IdentifiedObject {

		/// <summary>
		/// The kind of energy type referenced.
		/// </summary>
		public EnergyTypeKind kind;

		/// <summary>
		/// Initializes a new instance of the <see cref="EnergyTypeReference"/> class.
		/// </summary>
		public EnergyTypeReference(){

		}

    /// <summary>
    /// Releases resources used by the <see cref="EnergyTypeReference"/> class.
    /// </summary>
    public override void Dispose(){

		}

	}//end EnergyTypeReference

}//end namespace EnergyArea
