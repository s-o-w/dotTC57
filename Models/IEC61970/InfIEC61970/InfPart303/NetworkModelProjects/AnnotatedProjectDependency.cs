﻿///////////////////////////////////////////////////////////
//  AnnotatedProjectDependency.cs
//  Implementation of the Class AnnotatedProjectDependency
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:40 AM
//  Original author: selaost1
///////////////////////////////////////////////////////////

using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelProjects {
	public class AnnotatedProjectDependency : IdentifiedObject {

		public DependencyKind dependencyType;
		public TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelProjects.NetworkModelProjectStage DependentOnStage;
		public TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelProjects.NetworkModelProjectStage DependingStage;

		public AnnotatedProjectDependency(){

		}

		~AnnotatedProjectDependency(){

		}

		public override void Dispose(){

		}

	}//end AnnotatedProjectDependency

}//end namespace NetworkModelProjects