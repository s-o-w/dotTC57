///////////////////////////////////////////////////////////
//  CurveStyle.cs
//  Implementation of the Class CurveStyle
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:46 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Core {
	/// <summary>
	/// Style or shape of curve.
	/// </summary>
	public enum CurveStyle : int {

		/// <summary>
		/// The Y-axis values are assumed constant until the next curve point and prior to
		/// the first curve point.
		/// </summary>
		constantYValue,
		/// <summary>
		/// The Y-axis values are assumed to be a straight line between values.  Also known
		/// as linear interpolation.
		/// </summary>
		straightLineYValues

	}//end CurveStyle

}//end namespace Core
