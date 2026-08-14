using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037A5")]
public class UIHUDUGC_RoundNumView : UIBaseView
{
	[Token(Token = "0x4016890")]
	[FieldOffset(Offset = "0x14")]
	public UILabel RoundNumLabel;

	[Token(Token = "0x4016891")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BgTheme;

	[Token(Token = "0x6016A9A")]
	[Address(RVA = "0x2E25978", Offset = "0x2E25978", VA = "0x2E25978")]
	public UIHUDUGC_RoundNumView()
	{
	}

	[Token(Token = "0x6016A9B")]
	[Address(RVA = "0x2E25980", Offset = "0x2E25980", VA = "0x2E25980", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A9C")]
	[Address(RVA = "0x2E25B88", Offset = "0x2E25B88", VA = "0x2E25B88")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
