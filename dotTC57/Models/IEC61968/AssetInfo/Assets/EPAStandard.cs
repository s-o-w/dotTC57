///////////////////////////////////////////////////////////
//  EPAStandard.cs
//  Implementation of the Class EPAStandard
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:07 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// Standard published by EPA (United States Environmental Protection Agency).
	/// </summary>
	public class EPAStandard {

		/// <summary>
		/// Edition of EPA standard.
		/// </summary>
		public EPAStandardEditionKind standardEdition;
		/// <summary>
		/// EPA standard number.
		/// </summary>
		public EPAStandardKind standardNumber;

		/// <summary>
		/// Initializes a new instance of the <see cref="EPAStandard"/> class
		/// </summary>
		public EPAStandard(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public virtual void Dispose(){

		}

	}//end EPAStandard

}//end namespace Assets
