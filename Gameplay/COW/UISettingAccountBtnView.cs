using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039AC")]
public class UISettingAccountBtnView : UIBaseView
{
	[Token(Token = "0x4018359")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Btn;

	[Token(Token = "0x401835A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Sprite;

	[Token(Token = "0x401835B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Bind;

	[Token(Token = "0x60170AB")]
	[Address(RVA = "0x1A56214", Offset = "0x1A56214", VA = "0x1A56214")]
	public UISettingAccountBtnView()
	{
	}

	[Token(Token = "0x60170AC")]
	[Address(RVA = "0x1A5621C", Offset = "0x1A5621C", VA = "0x1A5621C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170AD")]
	[Address(RVA = "0x1A56478", Offset = "0x1A56478", VA = "0x1A56478")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
