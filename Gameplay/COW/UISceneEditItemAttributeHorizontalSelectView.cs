using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003991")]
public class UISceneEditItemAttributeHorizontalSelectView : UIBaseView
{
	[Token(Token = "0x40181EF")]
	[FieldOffset(Offset = "0x14")]
	public UIButton RightBtn;

	[Token(Token = "0x40181F0")]
	[FieldOffset(Offset = "0x18")]
	public UISprite RightSprite;

	[Token(Token = "0x40181F1")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton LeftBtn;

	[Token(Token = "0x40181F2")]
	[FieldOffset(Offset = "0x20")]
	public UISprite LeftSprite;

	[Token(Token = "0x40181F3")]
	[FieldOffset(Offset = "0x24")]
	public UILabel CountLabel;

	[Token(Token = "0x40181F4")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ParamNameLabel;

	[Token(Token = "0x601705A")]
	[Address(RVA = "0x2D9E3E0", Offset = "0x2D9E3E0", VA = "0x2D9E3E0")]
	public UISceneEditItemAttributeHorizontalSelectView()
	{
	}

	[Token(Token = "0x601705B")]
	[Address(RVA = "0x2D9E3E8", Offset = "0x2D9E3E8", VA = "0x2D9E3E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601705C")]
	[Address(RVA = "0x2D9E770", Offset = "0x2D9E770", VA = "0x2D9E770")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
