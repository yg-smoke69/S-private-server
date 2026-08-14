using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003792")]
public class UIHUDUGC_IconNotificationView : UIBaseView
{
	[Token(Token = "0x4016835")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Bg;

	[Token(Token = "0x4016836")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Description;

	[Token(Token = "0x4016837")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Icon;

	[Token(Token = "0x6016A61")]
	[Address(RVA = "0x2E08788", Offset = "0x2E08788", VA = "0x2E08788")]
	public UIHUDUGC_IconNotificationView()
	{
	}

	[Token(Token = "0x6016A62")]
	[Address(RVA = "0x2E08790", Offset = "0x2E08790", VA = "0x2E08790", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A63")]
	[Address(RVA = "0x2E089F8", Offset = "0x2E089F8", VA = "0x2E089F8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
