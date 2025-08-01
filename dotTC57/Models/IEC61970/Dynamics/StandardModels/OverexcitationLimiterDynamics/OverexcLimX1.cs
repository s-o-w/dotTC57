///////////////////////////////////////////////////////////
//  OverexcLimX1.cs
//  Implementation of the Class OverexcLimX1
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:11 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61970.Dynamics.StandardModels.OverexcitationLimiterDynamics {
	/// <summary>
	/// Field voltage over excitation limiter.
	/// </summary>
	public class OverexcLimX1 : OverexcitationLimiterDynamics {

		/// <summary>
		/// Low voltage point on the inverse time characteristic
		/// (<i>EFD</i><i><sub>1</sub></i>).  Typical value = 1,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? efd1;
		/// <summary>
		/// Mid voltage point on the inverse time characteristic
		/// (<i>EFD</i><i><sub>2</sub></i>).  Typical value = 1,2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? efd2;
		/// <summary>
		/// High voltage point on the inverse time characteristic
		/// (<i>EFD</i><i><sub>3</sub></i>).  Typical value = 1,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? efd3;
		/// <summary>
		/// Desired field voltage (<i>EFD</i><i><sub>DES</sub></i>).  Typical value = 0,9.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? efddes;
		/// <summary>
		/// Rated field voltage (<i>EFD</i><i><sub>RATED</sub></i>).  Typical value = 1,05.
		///
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? efdrated;
		/// <summary>
		/// Gain (<i>K</i><i><sub>MX</sub></i>).  Typical value = 0,01.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? kmx;
		/// <summary>
		/// Time to trip the exciter at the low voltage point on the inverse time
		/// characteristic (<i>TIME</i><i><sub>1</sub></i>) (>= 0).  Typical value = 120.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t1;
		/// <summary>
		/// Time to trip the exciter at the mid voltage point on the inverse time
		/// characteristic (<i>TIME</i><i><sub>2</sub></i>) (>= 0).  Typical value = 40.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t2;
		/// <summary>
		/// Time to trip the exciter at the high voltage point on the inverse time
		/// characteristic (<i>TIME</i><i><sub>3</sub></i>) (>= 0).  Typical value = 15.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds? t3;
		/// <summary>
		/// Low voltage limit (<i>V</i><i><sub>LOW</sub></i>) (> 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU? vlow;

		/// <summary>
		/// Initializes a new instance of the <see cref="OverexcLimX1"/> class
		/// </summary>
		public OverexcLimX1(){

		}

    /// <summary>
    /// Disposes this instance
    /// </summary>
    public override void Dispose(){

		}

	}//end OverexcLimX1

}//end namespace OverexcitationLimiterDynamics
