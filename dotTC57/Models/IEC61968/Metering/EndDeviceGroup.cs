///////////////////////////////////////////////////////////
//  EndDeviceGroup.cs
//  Implementation of the Class EndDeviceGroup
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:07 AM
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// Abstraction for management of group communications within a two-way AMR system
	/// or the data for a group of related end devices. Commands can be issued to all
	/// of the end devices that belong to the group using a defined group address and
	/// the underlying AMR communication infrastructure. A DERGroup and a
	/// PANDeviceGroup is an EndDeviceGroup.
	/// </summary>
	public class EndDeviceGroup : IdentifiedObject {

		/// <summary>
		/// Current status information relevant to a group.
		/// </summary>
		public TC57CIM.IEC61968.Common.Status? status;
		/// <summary>
		/// Type of this group.
		/// </summary>
		public string? type;
		/// <summary>
		/// version of this group
		/// </summary>
		public TC57CIM.IEC61968.Common.Version? version;
		/// <summary>
		/// An individual dispatch for a DER Group.
		/// </summary>
		public TC57CIM.IEC61968.DER.DERGroupDispatch? DERGroupDispatch;
		/// <summary>
		/// All end device controls sending commands to this end device group.
		/// </summary>
		public TC57CIM.IEC61968.Metering.EndDeviceControl? EndDeviceControls;
		/// <summary>
		/// The DER monitorable parameters associated with a DER Group.
		/// </summary>
		public TC57CIM.IEC61968.DER.DERMonitorableParameter? DERMonitorableParameter;
		/// <summary>
		/// The DER functions that are applied to the DER Group.
		/// </summary>
		public TC57CIM.IEC61968.DER.DERFunction? DERFunction;
		/// <summary>
		/// All end devices this end device group refers to.
		/// </summary>
		public TC57CIM.IEC61968.Metering.EndDevice? EndDevices;

		/// <summary>
		/// Initializes a new instance of the <see cref="EndDeviceGroup"/> class
		/// </summary>
		public EndDeviceGroup(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end EndDeviceGroup

}//end namespace Metering
