using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000DF")]
public class HeadPicData : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000546")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x4000547")]
	[FieldOffset(Offset = "0xC")]
	public uint sortId;

	[Token(Token = "0x4000548")]
	[FieldOffset(Offset = "0x10")]
	public uint avatarID;

	[Token(Token = "0x4000549")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID iconRes;

	[Token(Token = "0x400054A")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID effectRes;

	[Token(Token = "0x400054B")]
	[FieldOffset(Offset = "0x1C")]
	public ESourceType sourceTypeKey;

	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x190C9F8", Offset = "0x190C9F8", VA = "0x190C9F8")]
	public HeadPicData()
	{
	}

	[Token(Token = "0x60005DB")]
	[Address(RVA = "0x190CAD0", Offset = "0x190CAD0", VA = "0x190CAD0", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x60005DC")]
	[Address(RVA = "0x190CB28", Offset = "0x190CB28", VA = "0x190CB28", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005DD")]
	[Address(RVA = "0x190CB8C", Offset = "0x190CB8C", VA = "0x190CB8C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
