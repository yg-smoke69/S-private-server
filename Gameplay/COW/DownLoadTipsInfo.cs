using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002944")]
public class DownLoadTipsInfo
{
	[Token(Token = "0x400FE61")]
	[FieldOffset(Offset = "0x8")]
	public string Info;

	[Token(Token = "0x400FE62")]
	[FieldOffset(Offset = "0xC")]
	public bool Need_btn_group;

	[Token(Token = "0x400FE63")]
	[FieldOffset(Offset = "0x10")]
	public Action Comfirm_call_back;

	[Token(Token = "0x400FE64")]
	[FieldOffset(Offset = "0x14")]
	public bool Show_DownloadBtn;

	[Token(Token = "0x60107A5")]
	[Address(RVA = "0x1C945FC", Offset = "0x1C945FC", VA = "0x1C945FC")]
	public DownLoadTipsInfo(string info, bool need_btn_group, [Optional] Action comfirm_call_back, bool show_downloadBtn = false)
	{
	}
}
