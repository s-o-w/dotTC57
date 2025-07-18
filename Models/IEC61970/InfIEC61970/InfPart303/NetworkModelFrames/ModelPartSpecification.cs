﻿///////////////////////////////////////////////////////////
//  ModelPartSpecification.cs
//  Implementation of the Class ModelPartSpecification
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:08 AM
//  Original author: 222206
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelFrames {
	/// <summary>
	/// The type of model.  For example,  state estimator, planning, planning dynamics,
	/// short circuit, or real-time dynamics etc.     The model must conform to a
	/// profile.
	/// </summary>
	public class ModelPartSpecification : IdentifiedObject {

		/// <summary>
		/// Model frame of the model part.
		/// </summary>
		public TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelFrames.ModelAuthoritySet FrameworkPart;

		public ModelPartSpecification(){

		}

		~ModelPartSpecification(){

		}

		public override void Dispose(){

		}

	}//end ModelPartSpecification

}//end namespace NetworkModelFrames