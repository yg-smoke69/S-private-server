using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200375D")]
public class UIHudSuicideView : UIBaseView
{
	[Token(Token = "0x4016688")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Root;

	[Token(Token = "0x4016689")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Button;

	[Token(Token = "0x401668A")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton CancelBtn;

	[Token(Token = "0x401668B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CDIcon;

	[Token(Token = "0x401668C")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Circle;

	[Token(Token = "0x401668D")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TimeLabel;

	[Token(Token = "0x60169C2")]
	[Address(RVA = "0x1FEF838", Offset = "0x1FEF838", VA = "0x1FEF838")]
	public UIHudSuicideView()
	{
	}

	[Token(Token = "0x60169C3")]
	[Address(RVA = "0x1FEF840", Offset = "0x1FEF840", VA = "0x1FEF840", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169C4")]
	[Address(RVA = "0x1FEFBB0", Offset = "0x1FEFBB0", VA = "0x1FEFBB0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
