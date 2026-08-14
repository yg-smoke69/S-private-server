using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000209")]
public class PVEDropShowcaseData : CSVBaseData
{
	[Token(Token = "0x4000C0C")]
	[FieldOffset(Offset = "0x8")]
	public uint ConfigId;

	[Token(Token = "0x4000C0D")]
	[FieldOffset(Offset = "0xC")]
	public int Difficulty;

	[Token(Token = "0x4000C0E")]
	[FieldOffset(Offset = "0x10")]
	public uint ItemId;

	[Token(Token = "0x4000C0F")]
	[FieldOffset(Offset = "0x14")]
	public bool IsPVEToken;

	[Token(Token = "0x4000C10")]
	[FieldOffset(Offset = "0x15")]
	public bool IsMainDrop;

	[Token(Token = "0x4000C11")]
	[FieldOffset(Offset = "0x18")]
	public uint GoPos;

	[Token(Token = "0x4000C12")]
	[FieldOffset(Offset = "0x1C")]
	public string SubGoPos;

	[Token(Token = "0x6000A81")]
	[Address(RVA = "0x28CDDEC", Offset = "0x28CDDEC", VA = "0x28CDDEC")]
	public PVEDropShowcaseData()
	{
	}

	[Token(Token = "0x6000A82")]
	[Address(RVA = "0x28CDE70", Offset = "0x28CDE70", VA = "0x28CDE70", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A83")]
	[Address(RVA = "0x28CDED4", Offset = "0x28CDED4", VA = "0x28CDED4", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
