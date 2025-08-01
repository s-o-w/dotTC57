///////////////////////////////////////////////////////////
//  SurgeArresterInfo.cs
//  Implementation of the Class SurgeArresterInfo
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:26 AM
///////////////////////////////////////////////////////////

using Assets = TC57CIM.IEC61968.AssetInfo.Assets;
namespace TC57CIM.IEC61968.InfIEC61968.InfAssetInfo {
	/// <summary>
	/// Properties of surge arrester.
	/// </summary>
	public class SurgeArresterInfo : Assets.AssetInfo {

		/// <summary>
		/// Maximum continuous power frequency voltage allowed on the surge arrester.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Voltage? continuousOperatingVoltage;
		/// <summary>
		/// If true, the arrester has a polymer housing, porcelain otherwise.
		/// </summary>
		public bool isPolymer;
		/// <summary>
		/// Residual voltage during an 8x20 microsecond current impulse at the nominal
		/// discharge current level.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Voltage? lightningImpulseDischargeVoltage;
		/// <summary>
		/// Determines the arrester energy discharge capability.  Choices are limited to 0
		/// (none) through 5 (highest) by IEC 60099. Classes 1..3 require a 10-kA nominal
		/// discharge current. Classes 4..5 require a 20-kA nominal discharge current.
		/// Lower nominal discharge currents must use class 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? lineDischargeClass;
		/// <summary>
		/// The lightning discharge current used to classify the arrester. Choices are
		/// limited to 1.5, 2.5, 5, 10, and 20 kA by IEC 60099.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.CurrentFlow? nominalDischargeCurrent;
		/// <summary>
		/// Fault current level at which all parts of the failed arrester lie within a
		/// circle prescribed by IEC 60099.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.CurrentFlow? pressureReliefClass;
		/// <summary>
		/// The temporary overvoltage (TOV) level at power frequency that the surge
		/// arrester withstands for 10 seconds.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Voltage? ratedVoltage;
		/// <summary>
		/// Residual voltage during a current impulse with front time of 1 microsecond, and
		/// magnitude equal to the nominal discharge current level.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Voltage? steepFrontDischargeVoltage;
		/// <summary>
		/// Residual voltage during a current impulse with front time of at least 30
		/// microseconds, and magnitude specified in IEC 60099 for the line discharge class.
		/// Does not apply to line discharge class 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Voltage? switchingImpulseDischargeVoltage;

		/// <summary>
		/// Initializes a new instance of the <see cref="SurgeArresterInfo"/> class
		/// </summary>
		public SurgeArresterInfo(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end SurgeArresterInfo

}//end namespace InfAssetInfo
