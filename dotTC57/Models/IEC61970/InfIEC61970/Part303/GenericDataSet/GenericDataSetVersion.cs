///////////////////////////////////////////////////////////
//  GenericDataSetVersion.cs
//  Implementation of the Class GenericDataSetVersion
//  Updated with new XML comments
//  Created on:      15-Jun-2024 10:04:57 AM
//  Original author: SELAOST1
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.InfIEC61970.Part303.GenericDataSet {
    /// <summary>
    /// Represents a version of a generic data set, including major and minor versioning details.
    /// </summary>
    public class GenericDataSetVersion {

        /// <summary>
        /// The universal CIM version name describing a consistent set of packages.
        /// </summary>
        public string majorVersion = "2016";
        /// <summary>
        /// Describes minor updates and error corrections.
        /// </summary>
        public string minorVersion = "01";
        /// <summary>
        /// The date when the complete CIM canonical model is published and made available for use.
        /// After publication the major version and namespace are updated.
        /// </summary>
        public TC57CIM.IEC61970.Base.Domain.Date published;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericDataSetVersion"/> class.
        /// </summary>
        public GenericDataSetVersion(){
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="GenericDataSetVersion"/> class.
        /// </summary>
        ~GenericDataSetVersion(){
        }

        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations.
        /// </summary>
        public virtual void Dispose(){
        }

    }//end GenericDataSetVersion
}