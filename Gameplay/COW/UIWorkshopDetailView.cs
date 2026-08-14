using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A87")]
public class UIWorkshopDetailView : UIBaseView
{
	[Token(Token = "0x4018E3E")]
	[FieldOffset(Offset = "0x14")]
	public Transform MapContainer;

	[Token(Token = "0x4018E3F")]
	[FieldOffset(Offset = "0x18")]
	public UIPanel MapExtarInfo;

	[Token(Token = "0x4018E40")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnPreview;

	[Token(Token = "0x4018E41")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnFullScreen;

	[Token(Token = "0x4018E42")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelSubscribeCount;

	[Token(Token = "0x4018E43")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelLikeCount;

	[Token(Token = "0x4018E44")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SpriteMap;

	[Token(Token = "0x4018E45")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid TagContainer;

	[Token(Token = "0x4018E46")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LabelWorkshopName;

	[Token(Token = "0x4018E47")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LabelAuthorName;

	[Token(Token = "0x4018E48")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton BtnAuthor;

	[Token(Token = "0x4018E49")]
	[FieldOffset(Offset = "0x40")]
	public UILabel LabelWorkshopCode;

	[Token(Token = "0x4018E4A")]
	[FieldOffset(Offset = "0x44")]
	public UILabel LabelEmtpyCodeTips;

	[Token(Token = "0x4018E4B")]
	[FieldOffset(Offset = "0x48")]
	public UIButton BtnCopyWorkshopCode;

	[Token(Token = "0x4018E4C")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel LabelRound;

	[Token(Token = "0x4018E4D")]
	[FieldOffset(Offset = "0x50")]
	public UILabel LabelBattleStyle;

	[Token(Token = "0x4018E4E")]
	[FieldOffset(Offset = "0x54")]
	public UIScrollView DescScrollView;

	[Token(Token = "0x4018E4F")]
	[FieldOffset(Offset = "0x58")]
	public UILabel LabelDesc;

	[Token(Token = "0x4018E50")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton BtnSubscribe;

	[Token(Token = "0x4018E51")]
	[FieldOffset(Offset = "0x60")]
	public UISprite SpriteSubscribeIdle;

	[Token(Token = "0x4018E52")]
	[FieldOffset(Offset = "0x64")]
	public UISprite SpriteSubscribeSucc;

	[Token(Token = "0x4018E53")]
	[FieldOffset(Offset = "0x68")]
	public UIButton BtnShare;

	[Token(Token = "0x4018E54")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton BtnReport;

	[Token(Token = "0x4018E55")]
	[FieldOffset(Offset = "0x70")]
	public UIButton BtnQuickJoin;

	[Token(Token = "0x4018E56")]
	[FieldOffset(Offset = "0x74")]
	public UIButton BtnCreateRoom;

	[Token(Token = "0x4018E57")]
	[FieldOffset(Offset = "0x78")]
	public UIButton BtnMatchMaking;

	[Token(Token = "0x4018E58")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject FreeCreateRoom;

	[Token(Token = "0x4018E59")]
	[FieldOffset(Offset = "0x80")]
	public UIGrid CommentContainer;

	[Token(Token = "0x4018E5A")]
	[FieldOffset(Offset = "0x84")]
	public UIButton BtnAddComment;

	[Token(Token = "0x4018E5B")]
	[FieldOffset(Offset = "0x88")]
	public UIWidget TutorialWidget;

	[Token(Token = "0x601733B")]
	[Address(RVA = "0x1A32994", Offset = "0x1A32994", VA = "0x1A32994")]
	public UIWorkshopDetailView()
	{
	}

	[Token(Token = "0x601733C")]
	[Address(RVA = "0x1A3299C", Offset = "0x1A3299C", VA = "0x1A3299C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601733D")]
	[Address(RVA = "0x1A335F0", Offset = "0x1A335F0", VA = "0x1A335F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
