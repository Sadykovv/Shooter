// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ONLINESHOOTER : ModuleRules
{
	public ONLINESHOOTER(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
