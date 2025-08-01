///////////////////////////////////////////////////////////
//  PinTerminal.cs
//  Implementation of the Class PinTerminal
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:13 AM
//  Original author: sveinols
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.InfIEC61970.InfSIPS {
	/// <summary>
	/// Value associated with Terminal is used as compare.
	/// </summary>
	public class PinTerminal : GateInputPin {

		/// <summary>
		/// The compare operation done on the terminal.
		/// </summary>
		public PinTerminalKind kind;
		/// <summary>
		/// The Terminal that should be used in compare.
		/// </summary>
		/// <summary>
		/// The Terminal that should be used in compare.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.Terminal? Terminal;

		/// <summary>
		/// Initializes a new instance of the <see cref="PinTerminal"/> class.
		/// </summary>
		public PinTerminal(){

		}

    /// <summary>
    /// Releases resources used by the <see cref="PinTerminal"/> class.
    /// </summary>
    public override void Dispose(){

		}

	}//end PinTerminal

}//end namespace InfSIPS
