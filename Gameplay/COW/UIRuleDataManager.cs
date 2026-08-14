using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032CB")]
public static class UIRuleDataManager
{
	[Token(Token = "0x401355D")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string RULE_CHEST_RULE_TILTE;

	[Token(Token = "0x401355E")]
	[FieldOffset(Offset = "0x4")]
	public static readonly string RULE_CHEST_RULE_INFO2;

	[Token(Token = "0x401355F")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string RULE_CHEST_WHEEL_HELP_TAB;

	[Token(Token = "0x4013560")]
	[FieldOffset(Offset = "0xC")]
	public static readonly string RULE_CHEST_WHEEL_HELP_DESC;

	[Token(Token = "0x4013561")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string RULE_CHEST_LEGEND_HELP_TAB;

	[Token(Token = "0x4013562")]
	[FieldOffset(Offset = "0x14")]
	public static readonly string RULE_CHEST_LEGEND_HELP_DESC;

	[Token(Token = "0x4013563")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string RULE_CHEST_FADED_HELP_TAB;

	[Token(Token = "0x4013564")]
	[FieldOffset(Offset = "0x1C")]
	public static readonly string RULE_CHEST_FADED_HELP_DESC;

	[Token(Token = "0x4013565")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string RULE_CHEST_HACKER_STORE_HELP_TAB;

	[Token(Token = "0x4013566")]
	[FieldOffset(Offset = "0x24")]
	public static readonly string RULE_CHEST_HACKER_STORE_HELP_DESC;

	[Token(Token = "0x4013567")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string RULE_CS_CLAN_RULE;

	[Token(Token = "0x4013568")]
	[FieldOffset(Offset = "0x2C")]
	public static readonly string RULE_CLAN_TITLE_05;

	[Token(Token = "0x4013569")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string RULE_MYSTERYMALL;

	[Token(Token = "0x401356A")]
	[FieldOffset(Offset = "0x34")]
	public static readonly string RULE_WEAPON_RACK;

	[Token(Token = "0x401356B")]
	[FieldOffset(Offset = "0x38")]
	private static Dictionary<int, List<RuleMapping>> m_RuleDic;

	[Token(Token = "0x60156CF")]
	[Address(RVA = "0x2BF079C", Offset = "0x2BF079C", VA = "0x2BF079C")]
	public static string GetRuleKeyByTypeAndIndex(RuleType ruleType, int ruleIndex)
	{
		return null;
	}

	[Token(Token = "0x60156D0")]
	[Address(RVA = "0x2BF0978", Offset = "0x2BF0978", VA = "0x2BF0978")]
	public static List<RuleMapping> RulesOfType(RuleType ruleType, object extralData)
	{
		return null;
	}
}
