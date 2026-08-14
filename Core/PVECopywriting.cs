using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using message;

[Token(Token = "0x2001E00")]
public class PVECopywriting : ScriptableObject
{
	[Token(Token = "0x400BE1B")]
	[FieldOffset(Offset = "0xC")]
	public List<RoundTargetInfo> RoundTargetContent;

	[Token(Token = "0x400BE1C")]
	[FieldOffset(Offset = "0x10")]
	public List<SubtitleInfo> BossRandomSubtitle;

	[Token(Token = "0x400BE1D")]
	[FieldOffset(Offset = "0x14")]
	public List<SubtitleInfo> PlayerDeadSubtitle;

	[Token(Token = "0x400BE1E")]
	[FieldOffset(Offset = "0x18")]
	public List<SubtitleInfo> TeamDeadSubtitle;

	[Token(Token = "0x400BE1F")]
	[FieldOffset(Offset = "0x1C")]
	public List<SkillSubtitleInfo> BossSkillTalkContent;

	[Token(Token = "0x400BE20")]
	[FieldOffset(Offset = "0x20")]
	public List<RuleInfo> GameRuleInfo;

	[Token(Token = "0x6008F8E")]
	[Address(RVA = "0x1C775D8", Offset = "0x1C775D8", VA = "0x1C775D8")]
	public PVECopywriting()
	{
	}

	[Token(Token = "0x6008F8F")]
	[Address(RVA = "0x1C775E0", Offset = "0x1C775E0", VA = "0x1C775E0")]
	public string GetRoundContent(int roundID)
	{
		return null;
	}

	[Token(Token = "0x6008F90")]
	[Address(RVA = "0x1C777A4", Offset = "0x1C777A4", VA = "0x1C777A4")]
	public SubtitleInfo PopBossRandomSubtitle()
	{
		return null;
	}

	[Token(Token = "0x6008F91")]
	[Address(RVA = "0x1C778D4", Offset = "0x1C778D4", VA = "0x1C778D4")]
	public SubtitleInfo GetSkillTalkContent(OPKPPFDNCMC skillType)
	{
		return null;
	}

	[Token(Token = "0x6008F92")]
	[Address(RVA = "0x1C77A44", Offset = "0x1C77A44", VA = "0x1C77A44")]
	public string GetGameRuleTipByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6008F93")]
	[Address(RVA = "0x1C77B58", Offset = "0x1C77B58", VA = "0x1C77B58")]
	public SubtitleInfo GetPlayerDeadContent(bool isTeamDead)
	{
		return null;
	}
}
