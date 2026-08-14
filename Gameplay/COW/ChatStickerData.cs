using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000CB")]
public class ChatStickerData : CSVBaseData
{
	[Token(Token = "0x40004D2")]
	[FieldOffset(Offset = "0x8")]
	public uint ItemID;

	[Token(Token = "0x40004D3")]
	[FieldOffset(Offset = "0xC")]
	public uint StickerID;

	[Token(Token = "0x40004D4")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID ResourceName;

	[Token(Token = "0x40004D5")]
	[FieldOffset(Offset = "0x14")]
	public float RoomChatStickerPosY;

	[Token(Token = "0x40004D6")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<uint, List<ChatStickerData>> m_StickerSpriteDic;

	[Token(Token = "0x40004D7")]
	[FieldOffset(Offset = "0x4")]
	public static uint TrainingStickerItemId;

	[Token(Token = "0x6000588")]
	[Address(RVA = "0x1724DBC", Offset = "0x1724DBC", VA = "0x1724DBC")]
	public ChatStickerData()
	{
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0x1724E40", Offset = "0x1724E40", VA = "0x1724E40", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0x1724F40", Offset = "0x1724F40", VA = "0x1724F40", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x600058B")]
	[Address(RVA = "0x1725448", Offset = "0x1725448", VA = "0x1725448")]
	public static bool IsThisASticker(string strMsg)
	{
		return default(bool);
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0x17256DC", Offset = "0x17256DC", VA = "0x17256DC")]
	public static ChatStickerData IsThisASticker(string strMsg, out bool isSticker, out uint itemid)
	{
		return null;
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0x1725278", Offset = "0x1725278", VA = "0x1725278")]
	public static List<ChatStickerData> GetChatStickerDatas(uint itemID)
	{
		return null;
	}
}
