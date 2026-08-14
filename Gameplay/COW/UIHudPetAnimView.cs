using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036D7")]
public class UIHudPetAnimView : UIBaseView
{
	[Token(Token = "0x401623C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnPetAnimEntry;

	[Token(Token = "0x401623D")]
	[FieldOffset(Offset = "0x18")]
	public Transform icon;

	[Token(Token = "0x401623E")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget iconWidget;

	[Token(Token = "0x401623F")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteNormal;

	[Token(Token = "0x4016240")]
	[FieldOffset(Offset = "0x24")]
	public UISprite bg;

	[Token(Token = "0x4016241")]
	[FieldOffset(Offset = "0x28")]
	public GameObject widget;

	[Token(Token = "0x4016242")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton btnMask;

	[Token(Token = "0x4016243")]
	[FieldOffset(Offset = "0x30")]
	public UIButton btn1;

	[Token(Token = "0x4016244")]
	[FieldOffset(Offset = "0x34")]
	public UISprite icon1;

	[Token(Token = "0x4016245")]
	[FieldOffset(Offset = "0x38")]
	public UIButton btn2;

	[Token(Token = "0x4016246")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite icon2;

	[Token(Token = "0x4016247")]
	[FieldOffset(Offset = "0x40")]
	public UIButton btn3;

	[Token(Token = "0x4016248")]
	[FieldOffset(Offset = "0x44")]
	public UISprite icon3;

	[Token(Token = "0x4016249")]
	[FieldOffset(Offset = "0x48")]
	public UIButton btn4;

	[Token(Token = "0x401624A")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite icon4;

	[Token(Token = "0x401624B")]
	[FieldOffset(Offset = "0x50")]
	public UIButton btn5;

	[Token(Token = "0x401624C")]
	[FieldOffset(Offset = "0x54")]
	public UISprite icon5;

	[Token(Token = "0x401624D")]
	[FieldOffset(Offset = "0x58")]
	public UIButton btn6;

	[Token(Token = "0x401624E")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite icon6;

	[Token(Token = "0x401624F")]
	[FieldOffset(Offset = "0x60")]
	public UIButton BtnCenter;

	[Token(Token = "0x4016250")]
	[FieldOffset(Offset = "0x64")]
	public GameObject IconShowPet;

	[Token(Token = "0x4016251")]
	[FieldOffset(Offset = "0x68")]
	public GameObject IconHidePet;

	[Token(Token = "0x4016252")]
	[FieldOffset(Offset = "0x6C")]
	public Transform DesPos1;

	[Token(Token = "0x4016253")]
	[FieldOffset(Offset = "0x70")]
	public Transform DesPos2;

	[Token(Token = "0x4016254")]
	[FieldOffset(Offset = "0x74")]
	public Transform DesPos3;

	[Token(Token = "0x4016255")]
	[FieldOffset(Offset = "0x78")]
	public Transform DesPos4;

	[Token(Token = "0x4016256")]
	[FieldOffset(Offset = "0x7C")]
	public Transform DesPos5;

	[Token(Token = "0x4016257")]
	[FieldOffset(Offset = "0x80")]
	public Transform DesPos6;

	[Token(Token = "0x4016258")]
	[FieldOffset(Offset = "0x84")]
	public GameObject InGameDesPos1;

	[Token(Token = "0x4016259")]
	[FieldOffset(Offset = "0x88")]
	public GameObject InGameDesPos2;

	[Token(Token = "0x401625A")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject InGameDesPos3;

	[Token(Token = "0x401625B")]
	[FieldOffset(Offset = "0x90")]
	public GameObject InGameDesPos4;

	[Token(Token = "0x401625C")]
	[FieldOffset(Offset = "0x94")]
	public GameObject InGameDesPos5;

	[Token(Token = "0x401625D")]
	[FieldOffset(Offset = "0x98")]
	public GameObject InGameDesPos6;

	[Token(Token = "0x401625E")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject maskSprite1;

	[Token(Token = "0x401625F")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject maskSprite2;

	[Token(Token = "0x4016260")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject maskSprite3;

	[Token(Token = "0x4016261")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject maskSprite4;

	[Token(Token = "0x4016262")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject maskSprite5;

	[Token(Token = "0x4016263")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject maskSprite6;

	[Token(Token = "0x6016832")]
	[Address(RVA = "0x184CC18", Offset = "0x184CC18", VA = "0x184CC18")]
	public UIHudPetAnimView()
	{
	}

	[Token(Token = "0x6016833")]
	[Address(RVA = "0x184CC20", Offset = "0x184CC20", VA = "0x184CC20", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016834")]
	[Address(RVA = "0x184DA9C", Offset = "0x184DA9C", VA = "0x184DA9C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
