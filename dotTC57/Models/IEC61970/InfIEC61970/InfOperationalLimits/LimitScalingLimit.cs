///////////////////////////////////////////////////////////
//  LimitScalingLimit.cs
//  Implementation of the Class LimitScalingLimit
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:06 AM
//  Original author: kdemaree
///////////////////////////////////////////////////////////


namespace TC57CIM.IEC61970.InfIEC61970.InfOperationalLimits {
   /// <summary>
   /// Specifies an operational limit that is calculated by scaling another operational limit.
   /// </summary>
   public class LimitScalingLimit : LimitDependency {

	  /// <summary>
	  /// The associated source limit is scaled by this value to compute the limit of the dependency model.
	  /// </summary>
	  public TC57CIM.IEC61970.Base.Domain.PerCent? limitScalingPercent;

	  /// <summary>
	  /// The source operational limit used for scaling.
	  /// </summary>
	  public TC57CIM.IEC61970.Base.OperationalLimits.OperationalLimit? SourceOperationalLimit;

		/// <summary>
		/// Initializes a new instance of the <see cref="LimitScalingLimit"/> class.
		/// </summary>
		public LimitScalingLimit(){

		}

    /// <summary>
    /// Releases resources used by the <see cref="LimitScalingLimit"/> class.
    /// </summary>
    public override void Dispose(){

		}

	}//end LimitScalingLimit

}//end namespace InfOperationalLimits
