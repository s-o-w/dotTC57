///////////////////////////////////////////////////////////
//  FaultIndicator.cs
//  Implementation of the Class FaultIndicator
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:56 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.AuxiliaryEquipment {
	/// <summary>
	/// A FaultIndicator is typically only an indicator (which may or may not be
	/// remotely monitored), and not a piece of equipment that actually initiates a
	/// protection event. It is used for FLISR (Fault Location, Isolation and
	/// Restoration) purposes, assisting with the dispatch of crews to "most likely"
	/// part of the network (i.e. assists with determining circuit section where the
	/// fault most likely happened).
	/// </summary>
	public class FaultIndicator : AuxiliaryEquipment {

		/// <summary>
		/// Initializes a new instance of the <see cref="FaultIndicator"/> class
		/// </summary>
		public FaultIndicator(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end FaultIndicator

}//end namespace AuxiliaryEquipment
