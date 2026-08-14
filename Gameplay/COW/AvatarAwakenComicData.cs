using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000A5")]
public class AvatarAwakenComicData : CSVBaseData
{
	[Token(Token = "0x40003A7")]
	[FieldOffset(Offset = "0x8")]
	public uint CharacterID;

	[Token(Token = "0x40003A8")]
	[FieldOffset(Offset = "0xC")]
	public uint ComicID;

	[Token(Token = "0x40003A9")]
	[FieldOffset(Offset = "0x10")]
	public uint UnlockItemID;

	[Token(Token = "0x40003AA")]
	[FieldOffset(Offset = "0x14")]
	public uint UnlockItemNum;

	[Token(Token = "0x40003AB")]
	[FieldOffset(Offset = "0x18")]
	public string ComicName;

	[Token(Token = "0x40003AC")]
	[FieldOffset(Offset = "0x1C")]
	public string ComicTitleCDN;

	[Token(Token = "0x40003AD")]
	[FieldOffset(Offset = "0x20")]
	public string ComicContentCDN;

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x10FB240", Offset = "0x10FB240", VA = "0x10FB240")]
	public AvatarAwakenComicData()
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x10FB2C4", Offset = "0x10FB2C4", VA = "0x10FB2C4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x10FB328", Offset = "0x10FB328", VA = "0x10FB328")]
	public static string GeneratePrimaryKey(uint characterID, uint comicID)
	{
		return null;
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x10FB450", Offset = "0x10FB450", VA = "0x10FB450", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
