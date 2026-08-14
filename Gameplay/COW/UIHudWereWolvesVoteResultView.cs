using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037E2")]
public class UIHudWereWolvesVoteResultView : UIBaseView
{
	[Token(Token = "0x4016A89")]
	[FieldOffset(Offset = "0x14")]
	public GameObject EjectNode;

	[Token(Token = "0x4016A8A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite HeadPic;

	[Token(Token = "0x4016A8B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject EjectLabel;

	[Token(Token = "0x4016A8C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject WolfNode;

	[Token(Token = "0x4016A8D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject CivilNode;

	[Token(Token = "0x4016A8E")]
	[FieldOffset(Offset = "0x28")]
	public UILabel CountLabel;

	[Token(Token = "0x4016A8F")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite CountBG;

	[Token(Token = "0x4016A90")]
	[FieldOffset(Offset = "0x30")]
	public GameObject AlertNode;

	[Token(Token = "0x4016A91")]
	[FieldOffset(Offset = "0x34")]
	public GameObject RoundTableLabel;

	[Token(Token = "0x4016A92")]
	[FieldOffset(Offset = "0x38")]
	public GameObject BodyLabel;

	[Token(Token = "0x4016A93")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject NoEjectNode;

	[Token(Token = "0x6016B51")]
	[Address(RVA = "0x293D990", Offset = "0x293D990", VA = "0x293D990")]
	public UIHudWereWolvesVoteResultView()
	{
	}

	[Token(Token = "0x6016B52")]
	[Address(RVA = "0x293D998", Offset = "0x293D998", VA = "0x293D998", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B53")]
	[Address(RVA = "0x293DEA0", Offset = "0x293DEA0", VA = "0x293DEA0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
