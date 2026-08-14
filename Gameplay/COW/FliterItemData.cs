using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028F6")]
public class FliterItemData
{
	[Token(Token = "0x400FBEF")]
	[FieldOffset(Offset = "0x8")]
	public string Text;

	[Token(Token = "0x400FBF0")]
	[FieldOffset(Offset = "0xC")]
	public string Deep_Link;

	[Token(Token = "0x400FBF1")]
	[FieldOffset(Offset = "0x10")]
	public UILeaderBoardNewController.DeepLinkLayer DeepLinkLayer;

	[Token(Token = "0x400FBF2")]
	[FieldOffset(Offset = "0x14")]
	public Action<object> CallBack;

	[Token(Token = "0x6010315")]
	[Address(RVA = "0xDEDC20", Offset = "0xDEDC20", VA = "0xDEDC20")]
	public FliterItemData()
	{
	}
}
