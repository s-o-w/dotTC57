///////////////////////////////////////////////////////////
//  PssELIN2.cs
//  Implementation of the Class PssELIN2
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:17 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.PowerSystemStabilizerDynamics {
	/// <summary>
	/// Power system stabilizer typically associated with ExcELIN2 (though PssIEEE2B or
	/// Pss2B can also be used).
	/// </summary>
	public class PssELIN2 : PowerSystemStabilizerDynamics {

		/// <summary>
		/// Coefficient (<i>a_PSS</i>).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? apss;
		/// <summary>
		/// Gain (<i>Ks1</i>).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ks1;
		/// <summary>
		/// Gain (<i>Ks2</i>).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ks2;
		/// <summary>
		/// Coefficient (<i>p_PSS</i>) (greater than or equal to 0 and less than or equal to 4).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? ppss;
		/// <summary>
		/// PSS limiter (<i>psslim</i>).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? psslim;
		/// <summary>
		/// Time constant (<i>Ts1</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? ts1;
		/// <summary>
		/// Time constant (<i>Ts2</i>) (>= 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? ts2;
		/// <summary>
		/// Time constant (<i>Ts3</i>) (>= 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? ts3;
		/// <summary>
		/// Time constant (<i>Ts4</i>) (>= 0).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? ts4;
		/// <summary>
		/// Time constant (<i>Ts5</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? ts5;
		/// <summary>
		/// Time constant (<i>Ts6</i>) (>= 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? ts6;

		/// <summary>
		/// Initializes a new instance of the <see cref="PssELIN2"/> class
		/// </summary>
		public PssELIN2(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end PssELIN2

}//end namespace PowerSystemStabilizerDynamics
