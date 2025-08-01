///////////////////////////////////////////////////////////
//  SynchronousMachineDetailed.cs
//  Implementation of the Class SynchronousMachineDetailed
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:24 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.SynchronousMachineDynamics {
	/// <summary>
	/// All synchronous machine detailed types use a subset of the same data parameters
	/// and input/output variables.
	/// The several variations differ in the following ways:
	/// - the number of  equivalent windings that are included;
	/// - the way in which saturation is incorporated into the model;
	/// - whether or not �subtransient saliency� (<i>X''q</i> not = <i>X''d</i>) is
	/// represented.
	/// It is not necessary for each simulation tool to have separate models for each
	/// of the model types.  The same model can often be used for several types by
	/// alternative logic within the model.  Also, differences in saturation
	/// representation might not result in significant model performance differences so
	/// model substitutions are often acceptable.
	/// </summary>
	public class SynchronousMachineDetailed : SynchronousMachineDynamics {

		/// <summary>
		/// Ratio (exciter voltage/generator voltage) of <i>Efd</i> bases of exciter and
		/// generator models (> 0). Typical value = 1.
		/// </summary>
		public float efdBaseRatio;
		/// <summary>
		/// Excitation base system mode. It should be equal to the value of <i>WLMDV</i>
		/// given by the user. <i>WLMDV</i> is the PU ratio between the field voltage and
		/// the excitation current: <i>Efd</i> = <i>WLMDV</i> x <i>Ifd</i>. Typical value =
		/// ifag.
		/// </summary>
		public IfdBaseKind ifdBaseType;
		/// <summary>
		/// Quadrature-axis saturation factor at 120% of rated terminal voltage
		/// (<i>S12q</i>) (>= SynchonousMachineDetailed.saturationFactorQAxis).  Typical
		/// value = 0,12.
		/// </summary>
		public float saturationFactor120QAxis;
		/// <summary>
		/// Quadrature-axis saturation factor at rated terminal voltage (<i>S1q</i>) (>= 0).
		/// Typical value = 0,02.
		/// </summary>
		public float saturationFactorQAxis;

		/// <summary>
		/// Initializes a new instance of the <see cref="SynchronousMachineDetailed"/> class
		/// </summary>
		public SynchronousMachineDetailed(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end SynchronousMachineDetailed

}//end namespace SynchronousMachineDynamics
