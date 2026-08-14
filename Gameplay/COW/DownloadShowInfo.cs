using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029E7")]
public class DownloadShowInfo
{
	[Token(Token = "0x40101AA")]
	[FieldOffset(Offset = "0x8")]
	public DownloadShowStyle style;

	[Token(Token = "0x40101AB")]
	[FieldOffset(Offset = "0xC")]
	public Action onClickCommon;

	[Token(Token = "0x40101AC")]
	[FieldOffset(Offset = "0x10")]
	public List<ResourceID> downloadlist;

	[Token(Token = "0x40101AD")]
	[FieldOffset(Offset = "0x14")]
	public bool onlyShowIcon;

	[Token(Token = "0x40101AE")]
	[FieldOffset(Offset = "0x15")]
	public bool DoNotCheck;

	[Token(Token = "0x40101AF")]
	[FieldOffset(Offset = "0x18")]
	public int DelayShow;

	[Token(Token = "0x40101B0")]
	[FieldOffset(Offset = "0x1C")]
	public bool EnableDragScroll;

	[Token(Token = "0x40101B1")]
	[FieldOffset(Offset = "0x20")]
	public ResDownloadType ResType;

	[Token(Token = "0x40101B2")]
	[FieldOffset(Offset = "0x24")]
	public UIModelOptionalDownload.EOptionalLobbyResType LobbyResType;

	[Token(Token = "0x40101B3")]
	[FieldOffset(Offset = "0x28")]
	public uint ResAbId;

	[Token(Token = "0x6010DE6")]
	[Address(RVA = "0x1C950D4", Offset = "0x1C950D4", VA = "0x1C950D4")]
	public DownloadShowInfo()
	{
	}

	[Token(Token = "0x6010DE7")]
	[Address(RVA = "0x1C950DC", Offset = "0x1C950DC", VA = "0x1C950DC")]
	public DownloadShowInfo(DownloadShowStyle style, Action onClickCommon, List<ResourceID> downloadlist, bool onlyShowIcon = false)
	{
	}

	[Token(Token = "0x6010DE8")]
	[Address(RVA = "0x1C95114", Offset = "0x1C95114", VA = "0x1C95114")]
	public DownloadShowInfo(DownloadShowStyle style, ResDownloadType resType, UIModelOptionalDownload.EOptionalLobbyResType lobbyResType = UIModelOptionalDownload.EOptionalLobbyResType.None, uint resAbId = 0u, bool onlyShowIcon = false, bool doNotCheck = false, int delayShow = 0, [Optional] Action onClickCommon, bool enableDragScroll = false)
	{
	}
}
