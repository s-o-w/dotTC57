///////////////////////////////////////////////////////////
//  DataSet.cs
//  Implementation of the Class DataSet
//  Updated with new XML comments
//  Created on:      15-Jun-2024 10:04:46 AM
//  Original author: SELAOST1
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.InfIEC61970.Part303.GenericDataSet {
    /// <summary>
    /// A generic container of a version of instance data.
    /// </summary>
    public class DataSet {

        /// <summary>
        /// A free human readable text describing or naming the object.
        /// May be non-unique and not necessarily correlate to a naming hierarchy.
        /// </summary>
        public string? description;
        /// <summary>
        /// Master resource identifier issued by a model authority.
        /// The mRID is unique within an exchange context and it is recommended to be a UUID (RFC 4122).
        /// </summary>
        public string? mRID;
        /// <summary>
        /// Any free human readable text naming the object. May be non-unique.
        /// </summary>
        public string? name;
        /// <summary>
        /// The profile that describes the contents of the dataset and its governing rules.
        /// </summary>
        public Profile? Profile;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSet"/> class.
        /// </summary>
        public DataSet(){
        }

    /// <summary>
    /// Releases unmanaged resources and performs other cleanup operations.
    /// </summary>
    public virtual void Dispose(){
        }

    }//end DataSet
}
