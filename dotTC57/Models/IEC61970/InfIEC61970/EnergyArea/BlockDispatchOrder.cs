///////////////////////////////////////////////////////////
//  BlockDispatchOrder.cs
//  Implementation of the Class BlockDispatchOrder
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:41 AM
//  Original author: selaost1
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.InfIEC61970.EnergyArea {
	/// <summary>
	/// Represents a block dispatch order in the energy area.
	/// </summary>
	public class BlockDispatchOrder : IdentifiedObject {

		/// <summary>
		/// The active power value for the dispatch order.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower? p;
		/// <summary>
		/// The sequence number for the dispatch order.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer? sequence;
		/// <summary>
		/// The block dispatch component associated with this order.
		/// </summary>
		public TC57CIM.IEC61970.InfIEC61970.EnergyArea.BlockDispatchComponent? m_BlockDispatchComponent;

		/// <summary>
		/// Initializes a new instance of the <see cref="BlockDispatchOrder"/> class.
		/// </summary>
		public BlockDispatchOrder(){

		}

    /// <summary>
    /// Releases resources used by the <see cref="BlockDispatchOrder"/> class.
    /// </summary>
    public override void Dispose(){

		}

	}//end BlockDispatchOrder

}//end namespace EnergyArea
