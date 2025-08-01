///////////////////////////////////////////////////////////
//  TapSchedule.cs
//  Implementation of the Class TapSchedule
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:25 AM
//  Original author: KLH
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.LoadModel;
namespace TC57CIM.IEC61970.Base.Wires {
	/// <summary>
	/// A pre-established pattern over time for a tap step.
	/// </summary>
	public class TapSchedule : SeasonDayTypeSchedule {

		/// <summary>
		/// A TapSchedule is associated with a TapChanger.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.TapChanger? TapChanger;

		/// <summary>
		/// Initializes a new instance of the <see cref="TapSchedule"/> class
		/// </summary>
		public TapSchedule(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end TapSchedule

}//end namespace Wires
