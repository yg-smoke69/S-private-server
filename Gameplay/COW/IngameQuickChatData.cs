using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200015D")]
public class IngameQuickChatData : CSVBaseData
{
	[Token(Token = "0x40008CE")]
	[FieldOffset(Offset = "0x0")]
	public static readonly uint Special_ID_Request_Help_Purchase;

	[Token(Token = "0x40008CF")]
	[FieldOffset(Offset = "0x4")]
	public static readonly uint Special_ID_Response_Help_Purchase;

	[Token(Token = "0x40008D0")]
	[FieldOffset(Offset = "0x8")]
	public static readonly uint Special_ID_Response_PickUp;

	[Token(Token = "0x40008D1")]
	[FieldOffset(Offset = "0xC")]
	public static readonly uint Special_ID_Request_Friendly_Interaction;

	[Token(Token = "0x40008D2")]
	[FieldOffset(Offset = "0x10")]
	public static readonly uint Special_ID_Request_Enemy_Down;

	[Token(Token = "0x40008D3")]
	[FieldOffset(Offset = "0x14")]
	public static readonly uint Special_ID_Request_Another_Down;

	[Token(Token = "0x40008D4")]
	[FieldOffset(Offset = "0x18")]
	public static readonly uint Special_ID_Request_Enemy_Killed;

	[Token(Token = "0x40008D5")]
	[FieldOffset(Offset = "0x1C")]
	public static readonly uint Special_ID_Request_Another_Killed;

	[Token(Token = "0x40008D6")]
	[FieldOffset(Offset = "0x8")]
	public uint m_ID;

	[Token(Token = "0x40008D7")]
	[FieldOffset(Offset = "0xC")]
	public string m_MessageKey;

	[Token(Token = "0x40008D8")]
	[FieldOffset(Offset = "0x10")]
	public string m_SoundResourceName;

	[Token(Token = "0x40008D9")]
	[FieldOffset(Offset = "0x14")]
	public uint m_Type;

	[Token(Token = "0x40008DA")]
	[FieldOffset(Offset = "0x18")]
	public EGameModeCategory m_ModeCategory;

	[Token(Token = "0x40008DB")]
	[FieldOffset(Offset = "0x1C")]
	public uint m_GameMode;

	[Token(Token = "0x40008DC")]
	[FieldOffset(Offset = "0x20")]
	public bool m_IsDefault;

	[Token(Token = "0x40008DD")]
	[FieldOffset(Offset = "0x24")]
	public uint SamoOrder;

	[Token(Token = "0x600083E")]
	[Address(RVA = "0x2C7FF68", Offset = "0x2C7FF68", VA = "0x2C7FF68")]
	public IngameQuickChatData()
	{
	}

	[Token(Token = "0x600083F")]
	[Address(RVA = "0x2C7FFEC", Offset = "0x2C7FFEC", VA = "0x2C7FFEC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000840")]
	[Address(RVA = "0x2C80050", Offset = "0x2C80050", VA = "0x2C80050", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000841")]
	[Address(RVA = "0x2C80288", Offset = "0x2C80288", VA = "0x2C80288")]
	public static List<IngameQuickChatData> GetDefaultQuickChatList(EGameModeCategory modeCategory, uint gameMode = 0u)
	{
		return null;
	}

	[Token(Token = "0x6000842")]
	[Address(RVA = "0x2C80560", Offset = "0x2C80560", VA = "0x2C80560")]
	public static List<IngameQuickChatData> GetRouletteQuickChatList(EGameModeCategory modeCategory, uint gameMode = 0u)
	{
		return null;
	}
}
