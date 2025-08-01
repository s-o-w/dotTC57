///////////////////////////////////////////////////////////
//  ReadingType.cs
//  Implementation of the Class ReadingType
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:22 AM
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// Detailed description for a type of a reading value. Values in attributes allow
	/// for the creation of recommended codes to be used for identifying reading value
	/// types as follows: macroPeriod.aggregate.measuringPeriod.accumulation.
	/// flowDirection.commodity.measurementKind.interharmonic.numerator.
	/// interharmonic.denominator.argument.numerator.argument.denominator.tou.
	/// cpp.consumptionTier.phases.multiplier.unit.currency.
	/// </summary>
	public class ReadingType : IdentifiedObject {

		/// <summary>
		/// Accumulation behaviour of a reading over time, usually 'measuringPeriod', to be
		/// used with individual endpoints (as opposed to 'macroPeriod' and 'aggregate'
		/// that are used to describe aggregations of data from individual endpoints).
		/// </summary>
		public AccumulationKind accumulation;
		/// <summary>
		/// Salient attribute of the reading data aggregated from individual endpoints.
		/// This is mainly used to define a mathematical operation carried out over
		/// 'macroPeriod', but may also be used to describe an attribute of the data when
		/// the 'macroPeriod' is not defined.
		/// </summary>
		public AggregateKind aggregate;
		/// <summary>
		/// Argument used to introduce numbers into the unit of measure description where
		/// they are needed (e.g., 4 where the measure needs an argument such as CEMI(n=4)).
		/// Most arguments used in practice however will be integers (i.e.,
		/// 'denominator'=1).
		/// Value 0 in 'numerator' and 'denominator' means not applicable.
		/// </summary>
		public RationalNumber? argument;
		/// <summary>
		/// Commodity being measured.
		/// </summary>
		public CommodityKind commodity;
		/// <summary>
		/// In case of common flat-rate pricing for power, in which all purchases are at a
		/// given rate, 'consumptionTier'=0. Otherwise, the value indicates the consumption
		/// tier, which can be used in conjunction with TOU or CPP pricing.
		/// Consumption tier pricing refers to the method of billing in which a certain
		/// "block" of energy is purchased/sold at one price, after which the next block of
		/// energy is purchased at another price, and so on, all throughout a defined
		/// period. At the start of the defined period, consumption is initially zero, and
		/// any usage is measured against the first consumption tier ('consumptionTier'=1).
		/// If this block of energy is consumed before the end of the period, energy
		/// consumption moves to be reconed against the second consumption tier
		/// ('consumptionTier'=2), and so on. At the end of the defined period, the
		/// consumption accumulator is reset, and usage within the 'consumptionTier'=1
		/// restarts.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? consumptionTier;
		/// <summary>
		/// Critical peak period (CPP) bucket the reading value is attributed to. Value 0
		/// means not applicable. Even though CPP is usually considered a specialised form
		/// of time of use 'tou', this attribute is defined explicitly for flexibility.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? cpp;
		/// <summary>
		/// Metering-specific currency.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Currency? currency;
		/// <summary>
		/// Flow direction for a reading where the direction of flow of the commodity is
		/// important (for electricity measurements this includes current, energy, power,
		/// and demand).
		/// </summary>
		public FlowDirectionKind flowDirection;
		/// <summary>
		/// Indication of a "harmonic" or "interharmonic" basis for the measurement. Value
		/// 0 in 'numerator' and 'denominator' means not applicable.
		/// </summary>
		public ReadingInterharmonic? interharmonic;
		/// <summary>
		/// Time period of interest that reflects how the reading is viewed or captured
		/// over a long period of time.
		/// </summary>
		public MacroPeriodKind macroPeriod;
		/// <summary>
		/// Identifies "what" is being measured, as refinement of 'commodity'. When
		/// combined with 'unit', it provides detail to the unit of measure. For example,
		/// 'energy' with a unit of measure of 'kWh' indicates to the user that active
		/// energy is being measured, while with 'kVAh' or 'kVArh', it indicates apparent
		/// energy and reactive energy, respectively. 'power' can be combined in a similar
		/// way with various power units of measure: Distortion power
		/// ('distortionVoltAmperes') with 'kVA' is different from 'power' with 'kVA'.
		/// </summary>
		public MeasurementKind measurementKind;
		/// <summary>
		/// Time attribute inherent or fundamental to the reading value (as opposed to
		/// 'macroPeriod' that supplies an "adjective" to describe aspects of a time period
		/// with regard to the measurement). It refers to the way the value was originally
		/// measured and not to the frequency at which it is reported or presented. For
		/// example, an hourly interval of consumption data would have value 'hourly' as an
		/// attribute. However in the case of an hourly sampled voltage value, the
		/// meterReadings schema would carry the 'hourly' interval size information.
		/// It is common for meters to report demand in a form that is measured over the
		/// course of a portion of an hour, while enterprise applications however commonly
		/// assume the demand (in kW or kVAr) normalised to 1 hour. The system that
		/// receives readings directly from the meter therefore shall perform this
		/// transformation before publishing readings for use by the other enterprise
		/// systems. The scalar used is chosen based on the block size (not any sub-
		/// interval size).
		/// </summary>
		public MeasuringPeriodKind measuringPeriod;
		/// <summary>
		/// Metering-specific multiplier.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.UnitMultiplier? multiplier;
		/// <summary>
		/// Metering-specific phase code.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.PhaseCode? phases;
		/// <summary>
		/// Time of use (TOU) bucket the reading value is attributed to. Value 0 means not
		/// applicable.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? tou;
		/// <summary>
		/// Metering-specific unit.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.UnitSymbol? unit;
		/// <summary>
		/// Channel reporting/collecting register values with this type information.
		/// </summary>
		public TC57CIM.IEC61968.Metering.Channel? Channel;

		/// <summary>
		/// Initializes a new instance of the <see cref="ReadingType"/> class
		/// </summary>
		public ReadingType(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end ReadingType

}//end namespace Metering
