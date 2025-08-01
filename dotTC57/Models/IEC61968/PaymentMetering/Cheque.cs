///////////////////////////////////////////////////////////
//  Cheque.cs
//  Implementation of the Class Cheque
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:01 AM
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.PaymentMetering {
	/// <summary>
	/// The actual tender when it is a type of cheque.
	/// </summary>
	public class Cheque {

		/// <summary>
		/// Details of the account holder and bank.
		/// </summary>
		public BankAccountDetail? bankAccountDetail;
		/// <summary>
		/// Cheque reference number as printed on the cheque.
		/// </summary>
		public string? chequeNumber;
		/// <summary>
		/// Date when cheque becomes valid.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Date? date;
		/// <summary>
		/// Kind of cheque.
		/// </summary>
		public ChequeKind kind;
		/// <summary>
		/// The magnetic ink character recognition number printed on the cheque.
		/// </summary>
		public string? micrNumber;
		/// <summary>
		/// Payment tender the cheque is being used for.
		/// </summary>
		public TC57CIM.IEC61968.PaymentMetering.Tender? Tender;

		/// <summary>
		/// Initializes a new instance of the <see cref="Cheque"/> class
		/// </summary>
		public Cheque(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public virtual void Dispose(){

		}

	}//end Cheque

}//end namespace PaymentMetering
