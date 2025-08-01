///////////////////////////////////////////////////////////
//  TelephoneNumber.cs
//  Implementation of the Class TelephoneNumber
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:27 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.Common {
	/// <summary>
	/// Telephone number.
	/// </summary>
	public class TelephoneNumber {

		/// <summary>
		/// (if applicable) Area or region code.
		/// </summary>
		public string? areaCode;
		/// <summary>
		/// City code.
		/// </summary>
		public string? cityCode;
		/// <summary>
		/// Country code.
		/// </summary>
		public string? countryCode;
		/// <summary>
		/// (if applicable) Dial out code, for instance to call outside an enterprise.
		/// </summary>
		public string? dialOut;
		/// <summary>
		/// (if applicable) Extension for this telephone number.
		/// </summary>
		public string? extension;
		/// <summary>
		/// (if applicable) Prefix used when calling an international number.
		/// </summary>
		public string? internationalPrefix;
		/// <summary>
		/// Phone number according to International Telecommunication Union (ITU) E.164.
		/// </summary>
		public string? ituPhone;
		/// <summary>
		/// Main (local) part of this telephone number.
		/// </summary>
		public string? localNumber;

		/// <summary>
		/// Initializes a new instance of the <see cref="TelephoneNumber"/> class
		/// </summary>
		public TelephoneNumber(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public virtual void Dispose(){

		}

	}//end TelephoneNumber

}//end namespace Common
