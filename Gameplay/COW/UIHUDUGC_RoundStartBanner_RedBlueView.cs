using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037A7")]
public class UIHUDUGC_RoundStartBanner_RedBlueView : UIBaseView
{
	[Token(Token = "0x4016899")]
	[FieldOffset(Offset = "0x14")]
	public UILabel RoundNum;

	[Token(Token = "0x401689A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Final;

	[Token(Token = "0x401689B")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Bg_Left;

	[Token(Token = "0x401689C")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Bg_Right;

	[Token(Token = "0x6016AA0")]
	[Address(RVA = "0x2E275F8", Offset = "0x2E275F8", VA = "0x2E275F8")]
	public UIHUDUGC_RoundStartBanner_RedBlueView()
	{
	}

	[Token(Token = "0x6016AA1")]
	[Address(RVA = "0x2E27600", Offset = "0x2E27600", VA = "0x2E27600", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AA2")]
	[Address(RVA = "0x2E278C8", Offset = "0x2E278C8", VA = "0x2E278C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
