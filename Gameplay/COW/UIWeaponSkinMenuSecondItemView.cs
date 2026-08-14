using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A73")]
public class UIWeaponSkinMenuSecondItemView : UIBaseView
{
	[Token(Token = "0x4018CDF")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x4018CE0")]
	[FieldOffset(Offset = "0x18")]
	public GameObject HighLight;

	[Token(Token = "0x4018CE1")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Sprite;

	[Token(Token = "0x4018CE2")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Label;

	[Token(Token = "0x4018CE3")]
	[FieldOffset(Offset = "0x24")]
	public UISprite icespr;

	[Token(Token = "0x4018CE4")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Count;

	[Token(Token = "0x4018CE5")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject TipsGO;

	[Token(Token = "0x60172FF")]
	[Address(RVA = "0x2EE10A0", Offset = "0x2EE10A0", VA = "0x2EE10A0")]
	public UIWeaponSkinMenuSecondItemView()
	{
	}

	[Token(Token = "0x6017300")]
	[Address(RVA = "0x2EE10A8", Offset = "0x2EE10A8", VA = "0x2EE10A8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017301")]
	[Address(RVA = "0x2EE1478", Offset = "0x2EE1478", VA = "0x2EE1478")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
