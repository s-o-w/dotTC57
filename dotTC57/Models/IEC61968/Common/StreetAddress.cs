///////////////////////////////////////////////////////////
//  StreetAddress.cs
//  Implementation of the Class StreetAddress
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:25 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.Common {
	/// <summary>
	/// General purpose street and postal address information.
	/// </summary>
	public class StreetAddress {

		/// <summary>
		/// The language in which the address is specified, using ISO 639-1 two digit
		/// language code.
		/// </summary>
		public string? language;
		/// <summary>
		/// Post office box.
		/// </summary>
		public string? poBox;
		/// <summary>
		/// Postal code for the address.
		/// </summary>
		public string? postalCode;
		/// <summary>
		/// Status of this address.
		/// </summary>
		public Status? status;
		/// <summary>
		/// Street detail.
		/// </summary>
		public StreetDetail? streetDetail;
		/// <summary>
		/// Town detail.
		/// </summary>
		public TownDetail? townDetail;

		/// <summary>
		/// Initializes a new instance of the <see cref="StreetAddress"/> class
		/// </summary>
		public StreetAddress(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public virtual void Dispose(){

		}

	}//end StreetAddress

}//end namespace Common
