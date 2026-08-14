using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029E8")]
public class DownloadShowAllInfo
{
	[Token(Token = "0x40101B4")]
	[FieldOffset(Offset = "0x8")]
	public Action onClickAll;

	[Token(Token = "0x40101B5")]
	[FieldOffset(Offset = "0xC")]
	public ResDownloadType downloadtype;

	[Token(Token = "0x40101B6")]
	[FieldOffset(Offset = "0x10")]
	public string downloadllstr;

	[Token(Token = "0x6010DE9")]
	[Address(RVA = "0x1C94F7C", Offset = "0x1C94F7C", VA = "0x1C94F7C")]
	public DownloadShowAllInfo()
	{
	}

	[Token(Token = "0x6010DEA")]
	[Address(RVA = "0x1C9501C", Offset = "0x1C9501C", VA = "0x1C9501C")]
	public DownloadShowAllInfo(Action onClickAll, ResDownloadType downloadtype, string downloadllstr)
	{
	}
}
