///////////////////////////////////////////////////////////
//  PFVArType2IEEEVArController.cs
//  Implementation of the Class PFVArType2IEEEVArController
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:12 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.PFVArControllerType2Dynamics {
	/// <summary>
	/// IEEE VAR controller type 2 which is a summing point type controller. It makes
	/// up the outside loop of a two-loop system. This controller is implemented as a
	/// slow PI type controller, and the voltage regulator forms the inner loop and is
	/// implemented as a fast controller.
	/// Reference: IEEE 421.5-2005, 11.5.
	/// </summary>
	public class PFVArType2IEEEVArController : PFVArControllerType2Dynamics {

		/// <summary>
		/// Overexcitation or under excitation flag (<i>EXLON</i>)
		/// true = 1 (not in the overexcitation or underexcitation state, integral action
		/// is active)
		/// false = 0 (in the overexcitation or underexcitation state, so integral action
		/// is disabled to allow the limiter to play its role).
		/// </summary>
		public bool exlon;
		/// <summary>
		/// Integral gain of the pf controller (<i>K</i><i><sub>I</sub></i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ki;
		/// <summary>
		/// Proportional gain of the pf controller (<i>K</i><i><sub>P</sub></i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kp;
		/// <summary>
		/// Reactive power reference (<i>Q</i><i><sub>REF</sub></i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? qref;
		/// <summary>
		/// Maximum output of the pf controller (<i>V</i><i><sub>CLMT</sub></i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vclmt;
		/// <summary>
		/// Voltage regulator reference (<i>V</i><i><sub>REF</sub></i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vref;
		/// <summary>
		/// Generator sensing voltage (<i>V</i><i><sub>S</sub></i>).
		/// </summary>
		public float vs;

		/// <summary>
		/// Initializes a new instance of the <see cref="PFVArType2IEEEVArController"/> class
		/// </summary>
		public PFVArType2IEEEVArController(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end PFVArType2IEEEVArController

}//end namespace PFVArControllerType2Dynamics
