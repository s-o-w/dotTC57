///////////////////////////////////////////////////////////
//  WireAssemblyInfo.cs
//  Implementation of the Class WireAssemblyInfo
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:31 AM
//  Original author: marga
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.AssetInfo {
	/// <summary>
	/// Describes the construction of a multi-conductor wire.
	/// </summary>
	public class WireAssemblyInfo : Assets.AssetInfo {

		/// <summary>
		/// Per length line parameter associated with this wire assembly.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.PerLengthLineParameter? PerLengthLineParameter;

		/// <summary>
		/// Initializes a new instance of the <see cref="WireAssemblyInfo"/> class
		/// </summary>
		public WireAssemblyInfo(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end WireAssemblyInfo

}//end namespace AssetInfo
