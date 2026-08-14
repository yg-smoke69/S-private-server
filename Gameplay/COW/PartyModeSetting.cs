using System;
using Il2CppDummyDll;
using message;

namespace COW;

[Serializable]
[Token(Token = "0x200329B")]
public class PartyModeSetting
{
	[Token(Token = "0x4013455")]
	[FieldOffset(Offset = "0x8")]
	public EndConditionCheckList EndConditionCheckList;

	[NonSerialized]
	[Token(Token = "0x4013456")]
	[FieldOffset(Offset = "0xC")]
	public EndConditionSetting EndCondition;

	[Token(Token = "0x4013457")]
	[FieldOffset(Offset = "0x10")]
	public ToggleButtonGroupRuleSetting PlayerNum;

	[Token(Token = "0x4013458")]
	[FieldOffset(Offset = "0x14")]
	private OKBFAGMCOKP m_DataCache;

	[Token(Token = "0x6015556")]
	[Address(RVA = "0x28D0334", Offset = "0x28D0334", VA = "0x28D0334")]
	public PartyModeSetting()
	{
	}

	[Token(Token = "0x6015557")]
	[Address(RVA = "0x28D0404", Offset = "0x28D0404", VA = "0x28D0404")]
	public OKBFAGMCOKP ToProtoData()
	{
		return null;
	}

	[Token(Token = "0x6015558")]
	[Address(RVA = "0x28D04D4", Offset = "0x28D04D4", VA = "0x28D04D4")]
	public void FromProtoData(OKBFAGMCOKP protoData)
	{
	}

	[Token(Token = "0x6015559")]
	[Address(RVA = "0x28D062C", Offset = "0x28D062C", VA = "0x28D062C")]
	public bool FromDefaultData()
	{
		return default(bool);
	}

	[Token(Token = "0x601555A")]
	[Address(RVA = "0x28D090C", Offset = "0x28D090C", VA = "0x28D090C")]
	public PartyModeSetting Clone()
	{
		return null;
	}
}
