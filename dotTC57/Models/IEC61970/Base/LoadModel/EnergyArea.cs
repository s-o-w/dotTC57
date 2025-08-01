///////////////////////////////////////////////////////////
//  EnergyArea.cs
//  Implementation of the Class EnergyArea
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:49 AM
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.LoadModel {
	/// <summary>
	/// Describes an area having energy production or consumption.  Specializations are
	/// intended to support the load allocation function as typically required in
	/// energy management systems or planning studies to allocate hypothesized load
	/// levels to individual load points for power flow analysis.  Often the energy
	/// area can be linked to both measured and forecast load levels.
	/// </summary>
	public class EnergyArea : IdentifiedObject {

		/// <summary>
		/// Initializes a new instance of the <see cref="EnergyArea"/> class
		/// </summary>
		public EnergyArea(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end EnergyArea

}//end namespace LoadModel
