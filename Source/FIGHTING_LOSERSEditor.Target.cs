// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class FIGHTING_LOSERSEditorTarget : TargetRules
{
	public FIGHTING_LOSERSEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "FIGHTING_LOSERS" } );
	}
}
