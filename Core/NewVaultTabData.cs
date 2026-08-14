using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x20001BD")]
public class NewVaultTabData : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000AC4")]
	[FieldOffset(Offset = "0x8")]
	public int TabID;

	[Token(Token = "0x4000AC5")]
	[FieldOffset(Offset = "0xC")]
	public string TabName;

	[Token(Token = "0x4000AC6")]
	[FieldOffset(Offset = "0x10")]
	public int Priority;

	[Token(Token = "0x4000AC7")]
	[FieldOffset(Offset = "0x14")]
	public int IsHide;

	[Token(Token = "0x6000965")]
	[Address(RVA = "0x1C730AC", Offset = "0x1C730AC", VA = "0x1C730AC")]
	public NewVaultTabData()
	{
	}

	[Token(Token = "0x6000966")]
	[Address(RVA = "0x1C73178", Offset = "0x1C73178", VA = "0x1C73178", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000967")]
	[Address(RVA = "0x1C73184", Offset = "0x1C73184", VA = "0x1C73184", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000968")]
	[Address(RVA = "0x1C732B0", Offset = "0x1C732B0", VA = "0x1C732B0", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}
}
