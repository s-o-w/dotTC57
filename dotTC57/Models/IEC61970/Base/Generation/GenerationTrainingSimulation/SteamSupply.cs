///////////////////////////////////////////////////////////
//  SteamSupply.cs
//  Implementation of the Class SteamSupply
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:22 AM
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Generation.GenerationTrainingSimulation {
	/// <summary>
	/// Steam supply for steam turbine.
	/// </summary>
	public class SteamSupply : PowerSystemResource {

		/// <summary>
		/// Rating of steam supply.
		/// </summary>
		public float steamSupplyRating;
		/// <summary>
		/// Steam turbines may have steam supplied by a steam supply.
		/// </summary>
		public TC57CIM.IEC61970.Base.Generation.GenerationTrainingSimulation.SteamTurbine? SteamTurbines;

		/// <summary>
		/// Initializes a new instance of the <see cref="SteamSupply"/> class
		/// </summary>
		public SteamSupply(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end SteamSupply

}//end namespace GenerationTrainingSimulation
