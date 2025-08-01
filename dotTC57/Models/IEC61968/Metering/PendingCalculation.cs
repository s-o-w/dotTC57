///////////////////////////////////////////////////////////
//  PendingCalculation.cs
//  Implementation of the Class PendingCalculation
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:19 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// When present, a scalar conversion that needs to be applied to every
	/// IntervalReading.value contained in IntervalBlock. This conversion results in a
	/// new associated ReadingType, reflecting the true dimensions of IntervalReading
	/// values after the conversion.
	/// </summary>
	public class PendingCalculation {

		/// <summary>
		/// Whether scalars should be applied before adding the 'offset'.
		/// </summary>
		public bool multiplyBeforeAdd;
		/// <summary>
		/// (if applicable) Offset to be added as well as multiplication using scalars.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? offset;
		/// <summary>
		/// (if scalar is rational number) When 'IntervalReading.value' is multiplied by
		/// 'scalarNumerator' and divided by this value, it causes a unit of measure
		/// conversion to occur, resulting in the 'ReadingType.unit'.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? scalarDenominator;
		/// <summary>
		/// (if scalar is floating number) When multiplied with 'IntervalReading.value', it
		/// causes a unit of measure conversion to occur, according to the 'ReadingType.
		/// unit'.
		/// </summary>
		public float scalarFloat;
		/// <summary>
		/// (if scalar is integer or rational number)  When the scalar is a simple integer,
		/// and this attribute is presented alone and multiplied with 'IntervalReading.
		/// value', it causes a unit of measure conversion to occur, resulting in the
		/// 'ReadingType.unit'. It is never used in conjunction with 'scalarFloat', only
		/// with 'scalarDenominator'.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? scalarNumerator;
		/// <summary>
		/// Reading type resulting from this pending conversion.
		/// </summary>
		public TC57CIM.IEC61968.Metering.ReadingType? ReadingType;

		/// <summary>
		/// Initializes a new instance of the <see cref="PendingCalculation"/> class
		/// </summary>
		public PendingCalculation(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public virtual void Dispose(){

		}

	}//end PendingCalculation

}//end namespace Metering
