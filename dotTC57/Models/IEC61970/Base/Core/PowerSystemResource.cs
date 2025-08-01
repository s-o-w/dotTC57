///////////////////////////////////////////////////////////
//  PowerSystemResource.cs
//  Implementation of the Class PowerSystemResource
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:14 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Core {
	/// <summary>
	/// A power system resource (PSR) can be an item of equipment such as a switch, an
	/// equipment container containing many individual items of equipment such as a
	/// substation, or an organisational entity such as sub-control area. Power system
	/// resources can have measurements associated.
	/// </summary>
	public class PowerSystemResource : IdentifiedObject {

		/// <summary>
		/// The controller outputs used to actually govern a regulating device, e.g. the
		/// magnetization of a synchronous machine or capacitor bank breaker actuator.
		/// </summary>
		public TC57CIM.IEC61970.Base.Meas.Control? Controls;
		/// <summary>
		/// The measurements associated with this power system resource.
		/// </summary>
		public TC57CIM.IEC61970.Base.Meas.Measurement? Measurements;
		/// <summary>
		/// Custom classification for this power system resource.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.PSRType? PSRType;
		/// <summary>
		/// All configuration events created for this Power System resource.
		/// </summary>
		public TC57CIM.IEC61968.Common.ConfigurationEvent? ConfigurationEvent;

		/// <summary>
		/// Initializes a new instance of the <see cref="PowerSystemResource"/> class
		/// </summary>
		public PowerSystemResource(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end PowerSystemResource

}//end namespace Core
