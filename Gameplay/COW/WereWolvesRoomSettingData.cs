using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200026F")]
public class WereWolvesRoomSettingData : CSVBaseData
{
	[Token(Token = "0x4000ED2")]
	[FieldOffset(Offset = "0x8")]
	public int TypeID;

	[Token(Token = "0x4000ED3")]
	[FieldOffset(Offset = "0xC")]
	public string LocKey;

	[Token(Token = "0x4000ED4")]
	[FieldOffset(Offset = "0x10")]
	public uint DefaultValue;

	[Token(Token = "0x4000ED5")]
	[FieldOffset(Offset = "0x14")]
	public uint MinValue;

	[Token(Token = "0x4000ED6")]
	[FieldOffset(Offset = "0x18")]
	public uint MaxValue;

	[Token(Token = "0x4000ED7")]
	[FieldOffset(Offset = "0x1C")]
	public uint StepValue;

	[Token(Token = "0x4000ED8")]
	[FieldOffset(Offset = "0x20")]
	public uint[] OptionValues;

	[Token(Token = "0x6000BF0")]
	[Address(RVA = "0x21B9D34", Offset = "0x21B9D34", VA = "0x21B9D34")]
	public WereWolvesRoomSettingData()
	{
	}

	[Token(Token = "0x6000BF1")]
	[Address(RVA = "0x21B9DB8", Offset = "0x21B9DB8", VA = "0x21B9DB8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BF2")]
	[Address(RVA = "0x21B9E1C", Offset = "0x21B9E1C", VA = "0x21B9E1C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
