///////////////////////////////////////////////////////////
//  SynchrocheckRelay.cs
//  Implementation of the Class SynchrocheckRelay
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:24 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Protection {
	/// <summary>
	/// A device that operates when two AC circuits are within the desired limits of
	/// frequency, phase angle, and voltage, to permit or to cause the paralleling of
	/// these two circuits. Used to prevent the paralleling of non-synchronous
	/// topological islands.
	/// </summary>
	public class SynchrocheckRelay : ProtectionEquipment {

		/// <summary>
		/// The maximum allowable voltage vector phase angle difference across the open
		/// device.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.AngleRadians? maxAngleDiff;
		/// <summary>
		/// The maximum allowable frequency difference across the open device.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Frequency? maxFreqDiff;
		/// <summary>
		/// The maximum allowable difference voltage across the open device.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Voltage? maxVoltDiff;

		/// <summary>
		/// Initializes a new instance of the <see cref="SynchrocheckRelay"/> class
		/// </summary>
		public SynchrocheckRelay(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end SynchrocheckRelay

}//end namespace Protection
