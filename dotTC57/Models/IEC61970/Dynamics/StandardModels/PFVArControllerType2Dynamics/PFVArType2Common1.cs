///////////////////////////////////////////////////////////
//  PFVArType2Common1.cs
//  Implementation of the Class PFVArType2Common1
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:12 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.PFVArControllerType2Dynamics {
	/// <summary>
	/// Power factor / reactive power regulator. This model represents the power factor
	/// or reactive power controller such as the Basler SCP-250. The controller
	/// measures power factor or reactive power (PU on generator rated power) and
	/// compares it with the operator's set point.
	/// [Footnote: Basler SCP-250 is an example of a suitable product available
	/// commercially. This information is given for the convenience of users of this
	/// document and does not constitute an endorsement by IEC of this product.]
	/// </summary>
	public class PFVArType2Common1 : PFVArControllerType2Dynamics {

		/// <summary>
		/// Selector (<i>J</i>).
		/// true = control mode for reactive power
		/// false = control mode for power factor.
		/// </summary>
		public bool j;
		/// <summary>
		/// Reset gain (<i>Ki</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ki;
		/// <summary>
		/// Proportional gain (<i>Kp</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kp;
		/// <summary>
		/// Output limit (<i>max</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? max;
		/// <summary>
		/// Reference value of reactive power or power factor (<i>Ref</i>).
		/// The reference value is initialised by this model. This initialisation can
		/// override the value exchanged by this attribute to represent a plant operator's
		/// change of the reference setting.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? refValue;

		/// <summary>
		/// Initializes a new instance of the <see cref="PFVArType2Common1"/> class
		/// </summary>
		public PFVArType2Common1(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end PFVArType2Common1

}//end namespace PFVArControllerType2Dynamics
