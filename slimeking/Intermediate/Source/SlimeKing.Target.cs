using UnrealBuildTool;

public class SlimeKingTarget : TargetRules
{
	public SlimeKingTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SlimeKing");
	}
}
