using System;
using Il2CppDummyDll;
using message;

namespace COW;

[Serializable]
[Token(Token = "0x2003298")]
public class GeneralModeSetting
{
	[Token(Token = "0x401343E")]
	[FieldOffset(Offset = "0x8")]
	public NumericRuleSetting MaxHP;

	[Token(Token = "0x401343F")]
	[FieldOffset(Offset = "0xC")]
	public NumericRuleSetting MaxEP;

	[Token(Token = "0x4013440")]
	[FieldOffset(Offset = "0x10")]
	public NumericRuleSetting StartEP;

	[Token(Token = "0x4013441")]
	[FieldOffset(Offset = "0x14")]
	public ToggleRuleSetting AutoHealing;

	[Token(Token = "0x4013442")]
	[FieldOffset(Offset = "0x18")]
	public NumericRuleSetting Damage;

	[Token(Token = "0x4013443")]
	[FieldOffset(Offset = "0x1C")]
	public NumericRuleSetting Damaged;

	[Token(Token = "0x4013444")]
	[FieldOffset(Offset = "0x20")]
	public NumericRuleSetting MoveSpeed;

	[Token(Token = "0x4013445")]
	[FieldOffset(Offset = "0x24")]
	public NumericRuleSetting JumpHeight;

	[Token(Token = "0x4013446")]
	[FieldOffset(Offset = "0x28")]
	public ToggleRuleSetting LimitedAmmo;

	[Token(Token = "0x4013447")]
	[FieldOffset(Offset = "0x2C")]
	private PLPOJKGPFDL m_DataCache;

	[Token(Token = "0x6015547")]
	[Address(RVA = "0x2590370", Offset = "0x2590370", VA = "0x2590370")]
	public GeneralModeSetting()
	{
	}

	[Token(Token = "0x6015548")]
	[Address(RVA = "0x25904DC", Offset = "0x25904DC", VA = "0x25904DC")]
	public PLPOJKGPFDL ToProtoData()
	{
		return null;
	}

	[Token(Token = "0x6015549")]
	[Address(RVA = "0x2590784", Offset = "0x2590784", VA = "0x2590784")]
	public void FromProtoData(PLPOJKGPFDL protoData)
	{
	}

	[Token(Token = "0x601554A")]
	[Address(RVA = "0x2590A50", Offset = "0x2590A50", VA = "0x2590A50")]
	public void FromDefaultData()
	{
	}

	[Token(Token = "0x601554B")]
	[Address(RVA = "0x2590C64", Offset = "0x2590C64", VA = "0x2590C64")]
	public GeneralModeSetting Clone()
	{
		return null;
	}
}
