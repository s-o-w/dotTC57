///////////////////////////////////////////////////////////
//  Profile.cs
//  Implementation of the Class Profile
//  Updated with new XML comments
//  Created on:      15-Jun-2024 10:05:15 AM
//  Original author: SELAOST1
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.InfIEC61970.Part303.GenericDataSet {
    /// <summary>
    /// Describes the existence of a profile.
    /// The MRID is usually defined as a static value by the document or artifact
    /// that defines the contents of the profile and the rules for using the profile.
    /// </summary>
    public class Profile : IdentifiedObject {

        /// <summary>
        /// Initializes a new instance of the <see cref="Profile"/> class.
        /// </summary>
        public Profile(){
        }

    /// <summary>
    /// Releases unmanaged resources and performs other cleanup operations.
    /// </summary>
    public override void Dispose(){
        }

    }//end Profile
}
