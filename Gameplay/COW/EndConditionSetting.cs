using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using message;

namespace COW;

[Serializable]
[Token(Token = "0x200329C")]
public class EndConditionSetting : _Attribute
{
	[Token(Token = "0x200329D")]
	private sealed class _003CFromProtoData_003Ec__AnonStorey0
	{
		[Token(Token = "0x401345F")]
		[FieldOffset(Offset = "0x8")]
		internal MHJLCENIECM protoData;

		[Token(Token = "0x6015563")]
		[Address(RVA = "0x2535E4C", Offset = "0x2535E4C", VA = "0x2535E4C")]
		public _003CFromProtoData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6015564")]
		[Address(RVA = "0x2536488", Offset = "0x2536488", VA = "0x2536488")]
		internal bool _003C_003Em__0(ToggleButtonGroupRuleSetting.Item item)
		{
			return default(bool);
		}
	}

	[NonSerialized]
	[Token(Token = "0x4013459")]
	[FieldOffset(Offset = "0x8")]
	public EndConditionCheckList CheckList;

	[Token(Token = "0x401345A")]
	[FieldOffset(Offset = "0xC")]
	public string TitleID;

	[Token(Token = "0x401345B")]
	[FieldOffset(Offset = "0x10")]
	public NumericRuleSetting TimeUp;

	[Token(Token = "0x401345C")]
	[FieldOffset(Offset = "0x14")]
	public NumericRuleSetting Score;

	[Token(Token = "0x401345D")]
	[FieldOffset(Offset = "0x18")]
	public ToggleButtonGroupRuleSetting CSRounds;

	[NonSerialized]
	[Token(Token = "0x401345E")]
	[FieldOffset(Offset = "0x1C")]
	private MHJLCENIECM m_EndConditionCache;

	[Token(Token = "0x601555B")]
	[Address(RVA = "0x2535290", Offset = "0x2535290", VA = "0x2535290")]
	public EndConditionSetting()
	{
	}

	[Token(Token = "0x601555C")]
	[Address(RVA = "0x2535378", Offset = "0x2535378", VA = "0x2535378")]
	public MHJLCENIECM ToProtoData()
	{
		return null;
	}

	[Token(Token = "0x601555D")]
	[Address(RVA = "0x25358B4", Offset = "0x25358B4", VA = "0x25358B4")]
	public bool FromProtoData(MHJLCENIECM protoData)
	{
		return default(bool);
	}

	[Token(Token = "0x601555E")]
	[Address(RVA = "0x2535E54", Offset = "0x2535E54", VA = "0x2535E54")]
	public bool FromDefaultData()
	{
		return default(bool);
	}

	[Token(Token = "0x601555F")]
	[Address(RVA = "0x2536230", Offset = "0x2536230", VA = "0x2536230")]
	public EndConditionSetting Clone()
	{
		return null;
	}

	[Token(Token = "0x6015560")]
	[Address(RVA = "0x25363A4", Offset = "0x25363A4", VA = "0x25363A4")]
	private bool _003CToProtoData_003Em__0(ToggleButtonGroupRuleSetting.Item item)
	{
		return default(bool);
	}

	[Token(Token = "0x6015561")]
	[Address(RVA = "0x25363F0", Offset = "0x25363F0", VA = "0x25363F0")]
	private bool _003CToProtoData_003Em__1(ToggleButtonGroupRuleSetting.Item item)
	{
		return default(bool);
	}

	[Token(Token = "0x6015562")]
	[Address(RVA = "0x253643C", Offset = "0x253643C", VA = "0x253643C")]
	private bool _003CFromDefaultData_003Em__2(ToggleButtonGroupRuleSetting.Item item)
	{
		return default(bool);
	}
}
