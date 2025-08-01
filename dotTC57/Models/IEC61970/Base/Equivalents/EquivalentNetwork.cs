///////////////////////////////////////////////////////////
//  EquivalentNetwork.cs
//  Implementation of the Class EquivalentNetwork
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:51 AM
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Equivalents {
	/// <summary>
	/// A class that groups electrical equivalents, including internal nodes, of a
	/// network that has been reduced. The ConnectivityNodes contained in the
	/// equivalent are intended to reflect internal nodes of the equivalent. The
	/// boundary Connectivity nodes where the equivalent connects outside itself are
	/// not contained by the equivalent.
	/// </summary>
	public class EquivalentNetwork : ConnectivityNodeContainer {

		/// <summary>
		/// The associated reduced equivalents.
		/// </summary>
		public TC57CIM.IEC61970.Base.Equivalents.EquivalentEquipment? EquivalentEquipments;

		/// <summary>
		/// Initializes a new instance of the <see cref="EquivalentNetwork"/> class
		/// </summary>
		public EquivalentNetwork(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end EquivalentNetwork

}//end namespace Equivalents
