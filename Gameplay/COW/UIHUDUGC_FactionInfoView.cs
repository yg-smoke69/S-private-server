using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003791")]
public class UIHUDUGC_FactionInfoView : UIBaseView
{
	[Token(Token = "0x401682F")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Bg_Left;

	[Token(Token = "0x4016830")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LeftAliveCount;

	[Token(Token = "0x4016831")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Bg_Right;

	[Token(Token = "0x4016832")]
	[FieldOffset(Offset = "0x20")]
	public UILabel RightAliveCount;

	[Token(Token = "0x4016833")]
	[FieldOffset(Offset = "0x24")]
	public UISprite icon_Left;

	[Token(Token = "0x4016834")]
	[FieldOffset(Offset = "0x28")]
	public UISprite icon_Right;

	[Token(Token = "0x6016A5E")]
	[Address(RVA = "0x222D910", Offset = "0x222D910", VA = "0x222D910")]
	public UIHUDUGC_FactionInfoView()
	{
	}

	[Token(Token = "0x6016A5F")]
	[Address(RVA = "0x222D918", Offset = "0x222D918", VA = "0x222D918", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A60")]
	[Address(RVA = "0x222DCA0", Offset = "0x222DCA0", VA = "0x222DCA0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
