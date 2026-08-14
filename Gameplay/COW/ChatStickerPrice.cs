using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000CC")]
public class ChatStickerPrice : CSVBaseData
{
	[Token(Token = "0x40004D8")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40004D9")]
	[FieldOffset(Offset = "0xC")]
	public string Name;

	[Token(Token = "0x40004DA")]
	[FieldOffset(Offset = "0x10")]
	public uint GemsPrice;

	[Token(Token = "0x40004DB")]
	[FieldOffset(Offset = "0x14")]
	public uint CoinsPrice;

	[Token(Token = "0x40004DC")]
	[FieldOffset(Offset = "0x18")]
	public uint Gopos;

	[Token(Token = "0x40004DD")]
	[FieldOffset(Offset = "0x1C")]
	public uint GoposParam;

	[Token(Token = "0x40004DE")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID Icon;

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x1725A5C", Offset = "0x1725A5C", VA = "0x1725A5C")]
	public ChatStickerPrice()
	{
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x1725AE0", Offset = "0x1725AE0", VA = "0x1725AE0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000591")]
	[Address(RVA = "0x1725B44", Offset = "0x1725B44", VA = "0x1725B44", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x1725D6C", Offset = "0x1725D6C", VA = "0x1725D6C")]
	public static List<ChatStickerPrice> GetChatStickerPrices()
	{
		return null;
	}
}
