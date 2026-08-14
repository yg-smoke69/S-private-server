using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034C5")]
public class UIDigitaluniverseBActivityCardItemView : UIBaseView
{
	[Token(Token = "0x4014A3D")]
	[FieldOffset(Offset = "0x14")]
	public GameObject CDNCon;

	[Token(Token = "0x4014A3E")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTextureExt CDNCard;

	[Token(Token = "0x4014A3F")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject DetailCon;

	[Token(Token = "0x4014A40")]
	[FieldOffset(Offset = "0x20")]
	public UILabel SummaryLabel;

	[Token(Token = "0x4014A41")]
	[FieldOffset(Offset = "0x24")]
	public TypewriterEffect SummaryTypeWriter;

	[Token(Token = "0x4014A42")]
	[FieldOffset(Offset = "0x28")]
	public UITable DetalTabel;

	[Token(Token = "0x4014A43")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Detail1Label;

	[Token(Token = "0x4014A44")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Detail1Num;

	[Token(Token = "0x4014A45")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Detail2Label;

	[Token(Token = "0x4014A46")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Detail2Num;

	[Token(Token = "0x4014A47")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Detail3Label;

	[Token(Token = "0x4014A48")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Detail3Num;

	[Token(Token = "0x4014A49")]
	[FieldOffset(Offset = "0x44")]
	public UIButton ShareBtn;

	[Token(Token = "0x4014A4A")]
	[FieldOffset(Offset = "0x48")]
	public UILabel FirstShareBubbleLabel;

	[Token(Token = "0x4014A4B")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Detail4Con;

	[Token(Token = "0x4014A4C")]
	[FieldOffset(Offset = "0x50")]
	public UILabel Detail4Label;

	[Token(Token = "0x4014A4D")]
	[FieldOffset(Offset = "0x54")]
	public UILabel Detail4Num;

	[Token(Token = "0x4014A4E")]
	[FieldOffset(Offset = "0x58")]
	public UISprite DetailBG;

	[Token(Token = "0x4014A4F")]
	[FieldOffset(Offset = "0x5C")]
	public Animation UIDigitaluniverseBActivityCardItem;

	[Token(Token = "0x4014A50")]
	[FieldOffset(Offset = "0x60")]
	public GameObject PassIcon;

	[Token(Token = "0x4014A51")]
	[FieldOffset(Offset = "0x64")]
	public Animation PassIconAni;

	[Token(Token = "0x4014A52")]
	[FieldOffset(Offset = "0x68")]
	public UILabel HasNotPlayActivityLabel;

	[Token(Token = "0x4014A53")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject PassIconShining;

	[Token(Token = "0x6016203")]
	[Address(RVA = "0x2D90610", Offset = "0x2D90610", VA = "0x2D90610")]
	public UIDigitaluniverseBActivityCardItemView()
	{
	}

	[Token(Token = "0x6016204")]
	[Address(RVA = "0x2D90618", Offset = "0x2D90618", VA = "0x2D90618", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016205")]
	[Address(RVA = "0x2D90FC4", Offset = "0x2D90FC4", VA = "0x2D90FC4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
