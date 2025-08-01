///////////////////////////////////////////////////////////
//  CommodityKind.cs
//  Implementation of the Class CommodityKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:01 AM
//  Original author: Marty
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// Kind of commodity being measured.
	/// </summary>
	public enum CommodityKind : int {

		/// <summary>
		/// Not Applicable
		/// </summary>
		none = 0,
		/// <summary>
		/// All types of metered quantities. This type of reading comes from the meter and
		/// represents a �secondary� metered value.
		/// </summary>
		electricitySecondaryMetered = 1,
		/// <summary>
		/// It is possible for a meter to be outfitted with an external VT and/or CT. The
		/// meter might not be aware of these devices, and the display not compensate for
		/// their presence. Ultimately, when these scalars are applied, the value that
		/// represents the service value is called the �primary metered� value. The �index�
		/// in sub-category 3 mirrors those of sub-category 0.
		/// </summary>
		electricityPrimaryMetered = 2,
		/// <summary>
		/// A measurement of the communication infrastructure itself.
		/// </summary>
		communication = 3,
		/// <summary>
		/// Atmospheric air
		/// </summary>
		air = 4,
		/// <summary>
		/// (SF6 is found separately below.)
		/// </summary>
		insulativeGas = 5,
		/// <summary>
		/// Oil that is used in transformers to provide insulation and heat conduction.
		/// </summary>
		insulativeOil = 6,
		/// <summary>
		/// A naturally occurring hydrocarbon  gas mixture.
		/// </summary>
		naturalGas = 7,
		/// <summary>
		/// The formula is C3H8
		/// </summary>
		propane = 8,
		/// <summary>
		/// Drinkable water
		/// </summary>
		potableWater = 9,
		/// <summary>
		/// Water in steam form, usually used for heating.
		/// </summary>
		steam = 10,
		/// <summary>
		/// (Sewerage)
		/// </summary>
		wasteWater = 11,
		/// <summary>
		/// This fluid is likely in liquid form. It is not necessarily water or water based.
		/// The warm fluid returns cooler than when it was sent. The heat conveyed may be
		/// metered.
		/// </summary>
		heatingFluid = 12,
		/// <summary>
		/// The cool fluid returns warmer than when it was sent. The heat conveyed may be
		/// metered.
		/// </summary>
		coolingFluid = 13,
		/// <summary>
		/// Reclaimed water � possibly used for irrigation but not sufficiently treated to
		/// be considered safe for drinking.
		/// </summary>
		nonpotableWater = 14,
		/// <summary>
		/// Nitrous Oxides NOX
		/// </summary>
		nox = 15,
		/// <summary>
		/// Sulfur Dioxide SO2
		/// </summary>
		so2 = 16,
		/// <summary>
		/// Methane CH4
		/// </summary>
		ch4 = 17,
		/// <summary>
		/// Carbon Dioxide CO2
		/// </summary>
		co2 = 18,
		/// <summary>
		/// The element has an atomic number of 6.
		/// </summary>
		carbon = 19,
		/// <summary>
		/// Hexachlorocyclohexane HCH
		/// </summary>
		hch = 20,
		/// <summary>
		/// Perfluorocarbons PFC
		/// </summary>
		pfc = 21,
		/// <summary>
		/// Sulfurhexafluoride SF6
		/// </summary>
		sf6 = 22,
		/// <summary>
		/// Television
		/// </summary>
		tvLicence = 23,
		/// <summary>
		/// Internet service
		/// </summary>
		internet = 24,
		/// <summary>
		/// trash
		/// </summary>
		refuse = 25

	}//end CommodityKind

}//end namespace Metering
