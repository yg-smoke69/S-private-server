using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000AA")]
public class AvatarLevelCardData : CSVBaseData
{
	[Token(Token = "0x40003CA")]
	[FieldOffset(Offset = "0x8")]
	public int cardId;

	[Token(Token = "0x40003CB")]
	[FieldOffset(Offset = "0xC")]
	public int maxLevel;

	[Token(Token = "0x40003CC")]
	[FieldOffset(Offset = "0x10")]
	public uint goPos;

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x234D33C", Offset = "0x234D33C", VA = "0x234D33C")]
	public AvatarLevelCardData()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x234D3C0", Offset = "0x234D3C0", VA = "0x234D3C0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x234D424", Offset = "0x234D424", VA = "0x234D424", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
