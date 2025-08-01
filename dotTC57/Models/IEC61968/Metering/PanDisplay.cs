///////////////////////////////////////////////////////////
//  PanDisplay.cs
//  Implementation of the Class PanDisplay
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:19 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// PAN action/command used to issue the displaying of text messages on PAN devices.
	///
	/// </summary>
	public class PanDisplay : EndDeviceAction {

		/// <summary>
		/// If true, the requesting entity (e.g. retail electric provider) requires
		/// confirmation of the successful display of the text message.
		/// </summary>
		public bool confirmationRequired;
		/// <summary>
		/// Priority associated with the text message to be displayed.
		/// </summary>
		public string? priority;
		/// <summary>
		/// Text to be displayed by a PAN device.
		/// </summary>
		public string? textMessage;
		/// <summary>
		/// Transmission mode to be used for this PAN display control.
		/// </summary>
		public TransmissionModeKind transmissionMode;

		/// <summary>
		/// Initializes a new instance of the <see cref="PanDisplay"/> class
		/// </summary>
		public PanDisplay(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end PanDisplay

}//end namespace Metering
