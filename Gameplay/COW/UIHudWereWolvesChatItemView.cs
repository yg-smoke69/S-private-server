using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037CD")]
public class UIHudWereWolvesChatItemView : UIBaseView
{
	[Token(Token = "0x40169F3")]
	[FieldOffset(Offset = "0x14")]
	public GameObject OtherNode;

	[Token(Token = "0x40169F4")]
	[FieldOffset(Offset = "0x18")]
	public UILabel OtherNameLabel;

	[Token(Token = "0x40169F5")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite OtherHeadPic;

	[Token(Token = "0x40169F6")]
	[FieldOffset(Offset = "0x20")]
	public UISprite OtherHeadBg;

	[Token(Token = "0x40169F7")]
	[FieldOffset(Offset = "0x24")]
	public UISprite OtherCountBG;

	[Token(Token = "0x40169F8")]
	[FieldOffset(Offset = "0x28")]
	public UILabel OtherCountLabel;

	[Token(Token = "0x40169F9")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel OtherChatLabel;

	[Token(Token = "0x40169FA")]
	[FieldOffset(Offset = "0x30")]
	public UISprite OtherChatBG;

	[Token(Token = "0x40169FB")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SelfNode;

	[Token(Token = "0x40169FC")]
	[FieldOffset(Offset = "0x38")]
	public UILabel SelfNameLabel;

	[Token(Token = "0x40169FD")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite SelfHeadPic;

	[Token(Token = "0x40169FE")]
	[FieldOffset(Offset = "0x40")]
	public UISprite SelfHeadBg;

	[Token(Token = "0x40169FF")]
	[FieldOffset(Offset = "0x44")]
	public UISprite SelfCountBG;

	[Token(Token = "0x4016A00")]
	[FieldOffset(Offset = "0x48")]
	public UILabel SelfCountLabel;

	[Token(Token = "0x4016A01")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel SelfChatLabel;

	[Token(Token = "0x4016A02")]
	[FieldOffset(Offset = "0x50")]
	public UISprite SelfChatBG;

	[Token(Token = "0x4016A03")]
	[FieldOffset(Offset = "0x54")]
	public GameObject VoteNode;

	[Token(Token = "0x4016A04")]
	[FieldOffset(Offset = "0x58")]
	public UISprite VoteCountBG;

	[Token(Token = "0x4016A05")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel VoteCountLabel;

	[Token(Token = "0x4016A06")]
	[FieldOffset(Offset = "0x60")]
	public UILabel VoteInfoLabel;

	[Token(Token = "0x4016A07")]
	[FieldOffset(Offset = "0x64")]
	public GameObject RoundNode;

	[Token(Token = "0x4016A08")]
	[FieldOffset(Offset = "0x68")]
	public UILabel RoundLabel;

	[Token(Token = "0x6016B12")]
	[Address(RVA = "0x256650C", Offset = "0x256650C", VA = "0x256650C")]
	public UIHudWereWolvesChatItemView()
	{
	}

	[Token(Token = "0x6016B13")]
	[Address(RVA = "0x2566514", Offset = "0x2566514", VA = "0x2566514", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B14")]
	[Address(RVA = "0x2566E6C", Offset = "0x2566E6C", VA = "0x2566E6C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
