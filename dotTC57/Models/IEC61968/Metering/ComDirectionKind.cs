///////////////////////////////////////////////////////////
//  ComDirectionKind.cs
//  Implementation of the Class ComDirectionKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:01 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// Kind of communication direction.
	/// </summary>
	public enum ComDirectionKind : int {

		/// <summary>
		/// Communication is from device.
		/// </summary>
		fromDevice,
		/// <summary>
		/// Communication is to device.
		/// </summary>
		toDevice,
		/// <summary>
		/// Communication with the device is bi-directional.
		/// </summary>
		biDirectional

	}//end ComDirectionKind

}//end namespace Metering
