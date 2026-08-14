using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037E1")]
public class UIHudWereWolvesVoteItemView : UIBaseView
{
	[Token(Token = "0x4016A78")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnItem;

	[Token(Token = "0x4016A79")]
	[FieldOffset(Offset = "0x18")]
	public GameObject PredictWolfIcon;

	[Token(Token = "0x4016A7A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject PredictHumanIcon;

	[Token(Token = "0x4016A7B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SelfBG;

	[Token(Token = "0x4016A7C")]
	[FieldOffset(Offset = "0x24")]
	public UISprite BG;

	[Token(Token = "0x4016A7D")]
	[FieldOffset(Offset = "0x28")]
	public UILabel NameLabel;

	[Token(Token = "0x4016A7E")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget QuickChatTutorialWidget;

	[Token(Token = "0x4016A7F")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnQuickChat;

	[Token(Token = "0x4016A80")]
	[FieldOffset(Offset = "0x34")]
	public UISprite HeadPic;

	[Token(Token = "0x4016A81")]
	[FieldOffset(Offset = "0x38")]
	public UISprite HeadPicBg;

	[Token(Token = "0x4016A82")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject SelectObj;

	[Token(Token = "0x4016A83")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Voted;

	[Token(Token = "0x4016A84")]
	[FieldOffset(Offset = "0x44")]
	public UISprite CountBG;

	[Token(Token = "0x4016A85")]
	[FieldOffset(Offset = "0x48")]
	public UILabel CountLabel;

	[Token(Token = "0x4016A86")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject DeadSprite;

	[Token(Token = "0x4016A87")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Mic;

	[Token(Token = "0x4016A88")]
	[FieldOffset(Offset = "0x54")]
	public UIGrid VotedGridList;

	[Token(Token = "0x6016B4E")]
	[Address(RVA = "0x257F288", Offset = "0x257F288", VA = "0x257F288")]
	public UIHudWereWolvesVoteItemView()
	{
	}

	[Token(Token = "0x6016B4F")]
	[Address(RVA = "0x257F290", Offset = "0x257F290", VA = "0x257F290", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B50")]
	[Address(RVA = "0x257F9E4", Offset = "0x257F9E4", VA = "0x257F9E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
