///////////////////////////////////////////////////////////
//  ChangeSetMember.cs
//  Implementation of the Class ChangeSetMember
//  Updated with new XML comments
//  Created on:      15-Jun-2024 10:04:42 AM
//  Original author: 222206
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.InfIEC61970.Part303.GenericDataSet {
    /// <summary>
    /// Represents a CRUD-style data object within a change set.
    /// </summary>
    public class ChangeSetMember {

        /// <summary>
        /// Gets or sets the dataset containing the data objects.
        /// </summary>
        public ChangeSet? Changeset;
        /// <summary>
        /// Gets or sets the CIM object holding the properties of this dataset context.
        /// Sometimes only a reference to the registered object is used.
        /// </summary>
        public TC57CIM.IEC61970.Base.Core.IdentifiedObject? PropertiesObject;
        /// <summary>
        /// Gets or sets the registered CIM target object.
        /// </summary>
        public TC57CIM.IEC61970.Base.Core.IdentifiedObject? TargetObject;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeSetMember"/> class.
        /// </summary>
        public ChangeSetMember(){
        }

    /// <summary>
    /// Releases unmanaged resources and performs other cleanup operations.
    /// </summary>
    public virtual void Dispose(){
        }

    }//end ChangeSetMember
}
