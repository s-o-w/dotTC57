///////////////////////////////////////////////////////////
//  ObjectReverseModification.cs
//  Implementation of the Class ObjectReverseModification
//  Updated with new XML comments
//  Created on:      15-Jun-2024 10:05:10 AM
//  Original author: 222206
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.InfIEC61970.Part303.GenericDataSet {
    /// <summary>
    /// Used to specify precondition properties for a preconditioned update.
    /// </summary>
    public class ObjectReverseModification : ChangeSetMember {

        /// <summary>
        /// Gets or sets the associated data object representing the update.
        /// Normally the association is specified, but in the case of a proxy object where
        /// the association is removed, it might not reference any data object.
        /// </summary>
        public ObjectModification? ObjectModification;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectReverseModification"/> class.
        /// </summary>
        public ObjectReverseModification(){
        }

    /// <summary>
    /// Releases unmanaged resources and performs other cleanup operations.
    /// </summary>
    public override void Dispose(){
        }

    }//end ObjectReverseModification
}//end namespace GenericDataSet
