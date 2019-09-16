// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class FIGHTING_LOSERSTarget : TargetRules
{
	public FIGHTING_LOSERSTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "FIGHTING_LOSERS" } );
	}
}
