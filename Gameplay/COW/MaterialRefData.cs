using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000BD")]
public class MaterialRefData : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000496")]
	[FieldOffset(Offset = "0x8")]
	public uint clothID;

	[Token(Token = "0x4000497")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID maleMatRefID;

	[Token(Token = "0x4000498")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID femaleMatRefID;

	[Token(Token = "0x4000499")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID inGameMaleMatRefID;

	[Token(Token = "0x400049A")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID inGameFemaleMatRefID;

	[Token(Token = "0x6000553")]
	[Address(RVA = "0x1546774", Offset = "0x1546774", VA = "0x1546774")]
	public MaterialRefData()
	{
	}

	[Token(Token = "0x6000554")]
	[Address(RVA = "0x15467F8", Offset = "0x15467F8", VA = "0x15467F8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000555")]
	[Address(RVA = "0x154685C", Offset = "0x154685C", VA = "0x154685C", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000556")]
	[Address(RVA = "0x15468B4", Offset = "0x15468B4", VA = "0x15468B4", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
