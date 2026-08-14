using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000A9")]
public class AvatarInvisbleData : CSVBaseData
{
	[Token(Token = "0x40003C7")]
	[FieldOffset(Offset = "0x8")]
	public uint AvatarID;

	[Token(Token = "0x40003C8")]
	[FieldOffset(Offset = "0xC")]
	public uint RelatedID;

	[Token(Token = "0x40003C9")]
	[FieldOffset(Offset = "0x10")]
	public uint ItemID;

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x234D034", Offset = "0x234D034", VA = "0x234D034")]
	public AvatarInvisbleData()
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x234D0B8", Offset = "0x234D0B8", VA = "0x234D0B8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x234D11C", Offset = "0x234D11C", VA = "0x234D11C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x234D28C", Offset = "0x234D28C", VA = "0x234D28C")]
	public uint GetCurrentItemId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x234D2E4", Offset = "0x234D2E4", VA = "0x234D2E4")]
	public uint GetRelatedId()
	{
		return default(uint);
	}
}
