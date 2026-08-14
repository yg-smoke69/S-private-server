using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033E5")]
internal class UIBackButtonView : UIBaseView
{
	[Token(Token = "0x4013EF1")]
	[FieldOffset(Offset = "0x14")]
	public UIButton leaveBtn;

	[Token(Token = "0x4013EF2")]
	[FieldOffset(Offset = "0x18")]
	public UISprite ArrowSprite;

	[Token(Token = "0x4013EF3")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel BackLabel;

	[Token(Token = "0x4013EF4")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ButtonBgSprite;

	[Token(Token = "0x6015F65")]
	[Address(RVA = "0x1403108", Offset = "0x1403108", VA = "0x1403108")]
	public UIBackButtonView()
	{
	}

	[Token(Token = "0x6015F66")]
	[Address(RVA = "0x1403110", Offset = "0x1403110", VA = "0x1403110", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F67")]
	[Address(RVA = "0x1403318", Offset = "0x1403318", VA = "0x1403318")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
