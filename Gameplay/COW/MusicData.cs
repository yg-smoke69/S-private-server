using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000F6")]
public class MusicData : CSVBaseData, _Attribute
{
	[Token(Token = "0x400063C")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x400063D")]
	[FieldOffset(Offset = "0xC")]
	public uint SortId;

	[Token(Token = "0x400063E")]
	[FieldOffset(Offset = "0x10")]
	public uint IsIP;

	[Token(Token = "0x400063F")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID MusicResId;

	[Token(Token = "0x600062B")]
	[Address(RVA = "0x22911C4", Offset = "0x22911C4", VA = "0x22911C4")]
	public MusicData()
	{
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0x2291248", Offset = "0x2291248", VA = "0x2291248", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0x22912A0", Offset = "0x22912A0", VA = "0x22912A0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0x2291304", Offset = "0x2291304", VA = "0x2291304", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
