using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003647")]
public class UIHudEscortBossNameView : UIBaseView
{
	[Token(Token = "0x4015C57")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x4015C58")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Name;

	[Token(Token = "0x4015C59")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GoName;

	[Token(Token = "0x4015C5A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ArrowUp;

	[Token(Token = "0x4015C5B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ArrowUpLight;

	[Token(Token = "0x4015C5C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ArrowLeft;

	[Token(Token = "0x4015C5D")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ArrowLeftLight;

	[Token(Token = "0x4015C5E")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ArrowRight;

	[Token(Token = "0x4015C5F")]
	[FieldOffset(Offset = "0x34")]
	public GameObject ArrowRightLight;

	[Token(Token = "0x4015C60")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ArrowDown;

	[Token(Token = "0x4015C61")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ArrowDownLight;

	[Token(Token = "0x4015C62")]
	[FieldOffset(Offset = "0x40")]
	public UILabel TeammateDistance;

	[Token(Token = "0x4015C63")]
	[FieldOffset(Offset = "0x44")]
	public GameObject RepairIcon;

	[Token(Token = "0x4015C64")]
	[FieldOffset(Offset = "0x48")]
	public UISprite DistanceBG;

	[Token(Token = "0x4015C65")]
	[FieldOffset(Offset = "0x4C")]
	public Transform EventTriggerMarkPos;

	[Token(Token = "0x4015C66")]
	[FieldOffset(Offset = "0x50")]
	public UILabel AdditiveLabel;

	[Token(Token = "0x4015C67")]
	[FieldOffset(Offset = "0x54")]
	public GameObject HPNode;

	[Token(Token = "0x4015C68")]
	[FieldOffset(Offset = "0x58")]
	public UISprite BodyHPBar;

	[Token(Token = "0x4015C69")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel BodyLabel;

	[Token(Token = "0x4015C6A")]
	[FieldOffset(Offset = "0x60")]
	public UISprite WheelHPBar;

	[Token(Token = "0x4015C6B")]
	[FieldOffset(Offset = "0x64")]
	public UILabel WheelLabel;

	[Token(Token = "0x6016682")]
	[Address(RVA = "0x1B9199C", Offset = "0x1B9199C", VA = "0x1B9199C")]
	public UIHudEscortBossNameView()
	{
	}

	[Token(Token = "0x6016683")]
	[Address(RVA = "0x1B919A4", Offset = "0x1B919A4", VA = "0x1B919A4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016684")]
	[Address(RVA = "0x1B92214", Offset = "0x1B92214", VA = "0x1B92214")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
