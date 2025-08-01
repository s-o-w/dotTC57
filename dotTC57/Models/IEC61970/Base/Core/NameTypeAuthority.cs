///////////////////////////////////////////////////////////
//  NameTypeAuthority.cs
//  Implementation of the Class NameTypeAuthority
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:09 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Base.Core {
	/// <summary>
	/// Authority responsible for creation and management of names of a given type;
	/// typically an organization or an enterprise system.
	/// </summary>
	public class NameTypeAuthority {

		/// <summary>
		/// Description of the name type authority.
		/// </summary>
		public string? description;
		/// <summary>
		/// Name of the name type authority.
		/// </summary>
		public string? name;

		/// <summary>
		/// Initializes a new instance of the <see cref="NameTypeAuthority"/> class
		/// </summary>
		public NameTypeAuthority(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public virtual void Dispose(){

		}

	}//end NameTypeAuthority

}//end namespace Core
