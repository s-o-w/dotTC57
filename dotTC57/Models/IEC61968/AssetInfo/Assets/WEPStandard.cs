///////////////////////////////////////////////////////////
//  WEPStandard.cs
//  Implementation of the Class WEPStandard
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:31 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// Standard published by Westinghouse - a WEP (Westinghouse Engineering Procedure).
	///
	/// </summary>
	public class WEPStandard {

		/// <summary>
		/// Edition of WEP standard.
		/// </summary>
		public WEPStandardEditionKind standardEdition;
		/// <summary>
		/// WEP standard number.
		/// </summary>
		public WEPStandardKind standardNumber;

		/// <summary>
		/// Initializes a new instance of the <see cref="WEPStandard"/> class
		/// </summary>
		public WEPStandard(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public virtual void Dispose(){

		}

	}//end WEPStandard

}//end namespace Assets
