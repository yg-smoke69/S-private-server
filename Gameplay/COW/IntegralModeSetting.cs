using System;
using Il2CppDummyDll;
using message;

namespace COW;

[Serializable]
[Token(Token = "0x200329A")]
public class IntegralModeSetting
{
	[Token(Token = "0x401344E")]
	[FieldOffset(Offset = "0x8")]
	public EndConditionCheckList EndConditionCheckList;

	[NonSerialized]
	[Token(Token = "0x401344F")]
	[FieldOffset(Offset = "0xC")]
	public EndConditionSetting EndCondition;

	[Token(Token = "0x4013450")]
	[FieldOffset(Offset = "0x10")]
	public ToggleButtonGroupRuleSetting PlayerNum;

	[Token(Token = "0x4013451")]
	[FieldOffset(Offset = "0x14")]
	public NumericRuleSetting KillScore;

	[Token(Token = "0x4013452")]
	[FieldOffset(Offset = "0x18")]
	public ToggleButtonGroupRuleSetting ReviveRule;

	[Token(Token = "0x4013453")]
	[FieldOffset(Offset = "0x1C")]
	public NumericRuleSetting ReviveTime;

	[Token(Token = "0x4013454")]
	[FieldOffset(Offset = "0x20")]
	private BAJPKFPIKHB m_DataCache;

	[Token(Token = "0x6015551")]
	[Address(RVA = "0x2C80A70", Offset = "0x2C80A70", VA = "0x2C80A70")]
	public IntegralModeSetting()
	{
	}

	[Token(Token = "0x6015552")]
	[Address(RVA = "0x2C80B94", Offset = "0x2C80B94", VA = "0x2C80B94")]
	public BAJPKFPIKHB ToProtoData()
	{
		return null;
	}

	[Token(Token = "0x6015553")]
	[Address(RVA = "0x2C80D30", Offset = "0x2C80D30", VA = "0x2C80D30")]
	public void FromProtoData(BAJPKFPIKHB protoData)
	{
	}

	[Token(Token = "0x6015554")]
	[Address(RVA = "0x2C80F4C", Offset = "0x2C80F4C", VA = "0x2C80F4C")]
	public bool FromDefaultData()
	{
		return default(bool);
	}

	[Token(Token = "0x6015555")]
	[Address(RVA = "0x2C812D4", Offset = "0x2C812D4", VA = "0x2C812D4")]
	public IntegralModeSetting Clone()
	{
		return null;
	}
}
