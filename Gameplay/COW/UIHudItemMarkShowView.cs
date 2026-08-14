using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003685")]
public class UIHudItemMarkShowView : UIBaseView
{
	[Token(Token = "0x4015ECC")]
	[FieldOffset(Offset = "0x14")]
	public UISprite EnemyLine;

	[Token(Token = "0x4015ECD")]
	[FieldOffset(Offset = "0x18")]
	public UISprite MarkPoint;

	[Token(Token = "0x4015ECE")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite PickUpLine;

	[Token(Token = "0x4015ECF")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget UIShowContainer;

	[Token(Token = "0x4015ED0")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TeamPointMark;

	[Token(Token = "0x4015ED1")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelTeamId;

	[Token(Token = "0x4015ED2")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject EnemyMark;

	[Token(Token = "0x4015ED3")]
	[FieldOffset(Offset = "0x30")]
	public UISprite triggerImg;

	[Token(Token = "0x4015ED4")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Distance;

	[Token(Token = "0x4015ED5")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ArrowDown;

	[Token(Token = "0x4015ED6")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite ArrowDownSprite;

	[Token(Token = "0x4015ED7")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ArrowRight;

	[Token(Token = "0x4015ED8")]
	[FieldOffset(Offset = "0x44")]
	public UISprite ArrowRightSprite;

	[Token(Token = "0x4015ED9")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ArrowLeft;

	[Token(Token = "0x4015EDA")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite ArrowLeftSprite;

	[Token(Token = "0x4015EDB")]
	[FieldOffset(Offset = "0x50")]
	public GameObject ArrowUp;

	[Token(Token = "0x4015EDC")]
	[FieldOffset(Offset = "0x54")]
	public UISprite ArrowUpSprite;

	[Token(Token = "0x601673C")]
	[Address(RVA = "0x20AC654", Offset = "0x20AC654", VA = "0x20AC654")]
	public UIHudItemMarkShowView()
	{
	}

	[Token(Token = "0x601673D")]
	[Address(RVA = "0x20AC65C", Offset = "0x20AC65C", VA = "0x20AC65C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601673E")]
	[Address(RVA = "0x20ACDC8", Offset = "0x20ACDC8", VA = "0x20ACDC8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
