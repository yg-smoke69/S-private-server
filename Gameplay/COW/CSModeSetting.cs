using System;
using Il2CppDummyDll;
using message;

namespace COW;

[Serializable]
[Token(Token = "0x2003299")]
public class CSModeSetting
{
	[Token(Token = "0x4013448")]
	[FieldOffset(Offset = "0x8")]
	public EndConditionCheckList EndConditionCheckList;

	[NonSerialized]
	[Token(Token = "0x4013449")]
	[FieldOffset(Offset = "0xC")]
	public EndConditionSetting EndCondition;

	[Token(Token = "0x401344A")]
	[FieldOffset(Offset = "0x10")]
	public ToggleButtonGroupRuleSetting PlayerNum;

	[Token(Token = "0x401344B")]
	[FieldOffset(Offset = "0x14")]
	public SafeZoneRuleSetting SafeZoneSize;

	[Token(Token = "0x401344C")]
	[FieldOffset(Offset = "0x18")]
	public NumericRuleSetting SafeZoneStartTime;

	[Token(Token = "0x401344D")]
	[FieldOffset(Offset = "0x1C")]
	private OMAFMFJKMPB m_DataCache;

	[Token(Token = "0x601554C")]
	[Address(RVA = "0x1820D20", Offset = "0x1820D20", VA = "0x1820D20")]
	public CSModeSetting()
	{
	}

	[Token(Token = "0x601554D")]
	[Address(RVA = "0x1820E38", Offset = "0x1820E38", VA = "0x1820E38")]
	public OMAFMFJKMPB ToProtoData()
	{
		return null;
	}

	[Token(Token = "0x601554E")]
	[Address(RVA = "0x1820F94", Offset = "0x1820F94", VA = "0x1820F94")]
	public void FromProtoData(OMAFMFJKMPB protoData)
	{
	}

	[Token(Token = "0x601554F")]
	[Address(RVA = "0x1821178", Offset = "0x1821178", VA = "0x1821178")]
	public bool FromDefaultData()
	{
		return default(bool);
	}

	[Token(Token = "0x6015550")]
	[Address(RVA = "0x18214CC", Offset = "0x18214CC", VA = "0x18214CC")]
	public CSModeSetting Clone()
	{
		return null;
	}
}
