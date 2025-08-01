///////////////////////////////////////////////////////////
//  SeriesEquipmentDependentLimit.cs
//  Implementation of the Class SeriesEquipmentDependentLimit
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:21 AM
//  Original author: kdemaree
///////////////////////////////////////////////////////////


namespace TC57CIM.IEC61970.InfIEC61970.InfOperationalLimits {
   /// <summary>
   /// Limit based on most restrictive series equipment limit. A specification of equipment that determines the calculated operational limit values based upon other equipment and their ratings.
   /// </summary>
   public class SeriesEquipmentDependentLimit : LimitDependency {

	  /// <summary>
	  /// Equipment linkages that participate in the limit calculation.
	  /// </summary>
	  public TC57CIM.IEC61970.InfIEC61970.InfOperationalLimits.EquipmentLimitSeriesComponent? EquipmentLimitSeriesComponent;

	   /// <summary>
	   /// Initializes a new instance of the <see cref="SeriesEquipmentDependentLimit"/> class.
	   /// </summary>
	   public SeriesEquipmentDependentLimit(){

		}

    /// <summary>
    /// Releases resources used by the <see cref="SeriesEquipmentDependentLimit"/> class.
    /// </summary>
    public override void Dispose(){

		}

	}//end SeriesEquipmentDependentLimit

}//end namespace InfOperationalLimits
