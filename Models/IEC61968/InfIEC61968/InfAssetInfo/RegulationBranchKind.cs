﻿///////////////////////////////////////////////////////////
//  RegulationBranchKind.cs
//  Implementation of the Class RegulationBranchKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:22 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

namespace TC57CIM.IEC61968.InfIEC61968.InfAssetInfo {
	/// <summary>
	/// Kind of regulation branch for shunt impedance.
	/// </summary>
	public enum RegulationBranchKind : int {

		line,
		transformer,
		switch_,
		breaker,
		recloser,
		fuse,
		sectionner,
		other

	}//end RegulationBranchKind

}//end namespace InfAssetInfo