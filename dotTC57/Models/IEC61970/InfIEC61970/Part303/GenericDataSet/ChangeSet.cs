///////////////////////////////////////////////////////////
//  ChangeSet.cs
//  Implementation of the Class ChangeSet
//  Updated with new XML comments
//  Created on:      15-Jun-2024 10:04:42 AM
//  Original author: 222206
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.InfIEC61970.Part303.GenericDataSet {
    /// <summary>
    /// Represents a set of changes that can be applied in different scenarios.
    /// A given registered target object's MRID may only be referenced once by the change set members.
    /// </summary>
    public class ChangeSet : DataSet {

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeSet"/> class.
        /// </summary>
        public ChangeSet(){
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="ChangeSet"/> class.
        /// </summary>
        ~ChangeSet(){
        }

        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations.
        /// </summary>
        public override void Dispose(){
        }

    }//end ChangeSet
}