using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000B6")]
public class ClothesHairUpData : CSVBaseData, _Attribute
{
	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x4000450")]
	[FieldOffset(Offset = "0xC")]
	public uint LV0;

	[Token(Token = "0x4000451")]
	[FieldOffset(Offset = "0x10")]
	public uint LV1;

	[Token(Token = "0x4000452")]
	[FieldOffset(Offset = "0x14")]
	public uint LV2;

	[Token(Token = "0x4000453")]
	[FieldOffset(Offset = "0x18")]
	public uint LV3;

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x172E650", Offset = "0x172E650", VA = "0x172E650")]
	public ClothesHairUpData()
	{
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0x172E6D4", Offset = "0x172E6D4", VA = "0x172E6D4", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000521")]
	[Address(RVA = "0x172E72C", Offset = "0x172E72C", VA = "0x172E72C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0x172E790", Offset = "0x172E790", VA = "0x172E790", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
