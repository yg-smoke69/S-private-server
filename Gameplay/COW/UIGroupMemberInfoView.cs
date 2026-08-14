using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035B5")]
public class UIGroupMemberInfoView : UIBaseView
{
	[Token(Token = "0x4015798")]
	[FieldOffset(Offset = "0x14")]
	public UILabel readyTxt;

	[Token(Token = "0x4015799")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ready;

	[Token(Token = "0x401579A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject captain;

	[Token(Token = "0x401579B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject captain_bg;

	[Token(Token = "0x401579C")]
	[FieldOffset(Offset = "0x24")]
	public UILabel memName;

	[Token(Token = "0x401579D")]
	[FieldOffset(Offset = "0x28")]
	public GameObject friend;

	[Token(Token = "0x401579E")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton invite;

	[Token(Token = "0x401579F")]
	[FieldOffset(Offset = "0x30")]
	public UISprite LadderIcon;

	[Token(Token = "0x40157A0")]
	[FieldOffset(Offset = "0x34")]
	public Transform CallSignPos;

	[Token(Token = "0x40157A1")]
	[FieldOffset(Offset = "0x38")]
	public UIButton ClickAvatar;

	[Token(Token = "0x40157A2")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite RelationshipIcon;

	[Token(Token = "0x40157A3")]
	[FieldOffset(Offset = "0x40")]
	public UISprite SpriteEmulator;

	[Token(Token = "0x40157A4")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ChatBubble;

	[Token(Token = "0x40157A5")]
	[FieldOffset(Offset = "0x48")]
	public Animator BubbleAnimtor;

	[Token(Token = "0x40157A6")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject SimpleContent;

	[Token(Token = "0x40157A7")]
	[FieldOffset(Offset = "0x50")]
	public UIButton BtnSimple;

	[Token(Token = "0x40157A8")]
	[FieldOffset(Offset = "0x54")]
	public UILabel LabelSimple;

	[Token(Token = "0x40157A9")]
	[FieldOffset(Offset = "0x58")]
	public UISprite BgSimple;

	[Token(Token = "0x40157AA")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject MultiContent;

	[Token(Token = "0x40157AB")]
	[FieldOffset(Offset = "0x60")]
	public UIButton BtnMulti;

	[Token(Token = "0x40157AC")]
	[FieldOffset(Offset = "0x64")]
	public UILabel LabelMulti;

	[Token(Token = "0x40157AD")]
	[FieldOffset(Offset = "0x68")]
	public UISprite BgMulti;

	[Token(Token = "0x40157AE")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject Sticker;

	[Token(Token = "0x40157AF")]
	[FieldOffset(Offset = "0x70")]
	public UIButton BtnSticker;

	[Token(Token = "0x40157B0")]
	[FieldOffset(Offset = "0x74")]
	public UISprite ChatSticker;

	[Token(Token = "0x40157B1")]
	[FieldOffset(Offset = "0x78")]
	public UISprite BgSticker;

	[Token(Token = "0x40157B2")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel LabelShort;

	[Token(Token = "0x40157B3")]
	[FieldOffset(Offset = "0x80")]
	public UIGrid MapResGrid;

	[Token(Token = "0x40157B4")]
	[FieldOffset(Offset = "0x84")]
	public UISprite MapResState;

	[Token(Token = "0x40157B5")]
	[FieldOffset(Offset = "0x88")]
	public UISprite MapResStateshadow;

	[Token(Token = "0x40157B6")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject DownloadingEffect;

	[Token(Token = "0x40157B7")]
	[FieldOffset(Offset = "0x90")]
	public GameObject VFX_di;

	[Token(Token = "0x40157B8")]
	[FieldOffset(Offset = "0x94")]
	public GameObject VFX_gao;

	[Token(Token = "0x40157B9")]
	[FieldOffset(Offset = "0x98")]
	public GameObject BRStarContainer;

	[Token(Token = "0x40157BA")]
	[FieldOffset(Offset = "0x9C")]
	public UILadderMatchHeroicLevelView HeroicLevelView;

	[Token(Token = "0x40157BB")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject MIC;

	[Token(Token = "0x40157BC")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject MicNormal;

	[Token(Token = "0x40157BD")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject Mute;

	[Token(Token = "0x60164CD")]
	[Address(RVA = "0x1D069F0", Offset = "0x1D069F0", VA = "0x1D069F0")]
	public UIGroupMemberInfoView()
	{
	}

	[Token(Token = "0x60164CE")]
	[Address(RVA = "0x1D069F8", Offset = "0x1D069F8", VA = "0x1D069F8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164CF")]
	[Address(RVA = "0x1D078A4", Offset = "0x1D078A4", VA = "0x1D078A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
