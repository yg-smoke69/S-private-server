using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200384A")]
public class UILobbyNewRightBtnPanelView : UIBaseView
{
	[Token(Token = "0x401708C")]
	[FieldOffset(Offset = "0x14")]
	public Transform Right;

	[Token(Token = "0x401708D")]
	[FieldOffset(Offset = "0x18")]
	public TweenPosition TweenPosPanelRight;

	[Token(Token = "0x401708E")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid BtnPanel;

	[Token(Token = "0x401708F")]
	[FieldOffset(Offset = "0x20")]
	public UIButton UIButtonBtnEvent;

	[Token(Token = "0x4017090")]
	[FieldOffset(Offset = "0x24")]
	public Animator AnimatorBtnEvent;

	[Token(Token = "0x4017091")]
	[FieldOffset(Offset = "0x28")]
	public UISprite EventIcon;

	[Token(Token = "0x4017092")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject snowman;

	[Token(Token = "0x4017093")]
	[FieldOffset(Offset = "0x30")]
	public Transform VFXContainer;

	[Token(Token = "0x4017094")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnTask;

	[Token(Token = "0x4017095")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget TaskGuide;

	[Token(Token = "0x4017096")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton UIButtonBtnClan;

	[Token(Token = "0x4017097")]
	[FieldOffset(Offset = "0x40")]
	public UISprite UISpriteBtnClan;

	[Token(Token = "0x4017098")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ClanIcon;

	[Token(Token = "0x4017099")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ClanActivity;

	[Token(Token = "0x401709A")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject ClanActivityEffect;

	[Token(Token = "0x401709B")]
	[FieldOffset(Offset = "0x50")]
	public GameObject ClanWarGuidePop;

	[Token(Token = "0x401709C")]
	[FieldOffset(Offset = "0x54")]
	public UILabel ClanPopLabel;

	[Token(Token = "0x401709D")]
	[FieldOffset(Offset = "0x58")]
	public GameObject LiveTv;

	[Token(Token = "0x401709E")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject EsportsOnBubble;

	[Token(Token = "0x401709F")]
	[FieldOffset(Offset = "0x60")]
	public UISprite EsportsBubbleBG;

	[Token(Token = "0x40170A0")]
	[FieldOffset(Offset = "0x64")]
	public UIPanel EsportsClipPanel;

	[Token(Token = "0x40170A1")]
	[FieldOffset(Offset = "0x68")]
	public UILabel UILabelEsportsBubbleLabel;

	[Token(Token = "0x40170A2")]
	[FieldOffset(Offset = "0x6C")]
	public TweenPosition TweenPositionEsportsBubbleLabel;

	[Token(Token = "0x40170A3")]
	[FieldOffset(Offset = "0x70")]
	public UIButton EsportsBubbleBtn;

	[Token(Token = "0x40170A4")]
	[FieldOffset(Offset = "0x74")]
	public UIButton BtnLive;

	[Token(Token = "0x40170A5")]
	[FieldOffset(Offset = "0x78")]
	public GameObject VFX_EsportsOnBubble;

	[Token(Token = "0x40170A6")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton BtnLadderMatch;

	[Token(Token = "0x40170A7")]
	[FieldOffset(Offset = "0x80")]
	public GameObject SpriteLadderMatch;

	[Token(Token = "0x40170A8")]
	[FieldOffset(Offset = "0x84")]
	public GameObject LadderMatchDaily;

	[Token(Token = "0x40170A9")]
	[FieldOffset(Offset = "0x88")]
	public UILabel LabelDailyTask;

	[Token(Token = "0x40170AA")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject LadderMatchNewSeason;

	[Token(Token = "0x40170AB")]
	[FieldOffset(Offset = "0x90")]
	public UILabel LadderMatchNewSeasonLabel;

	[Token(Token = "0x40170AC")]
	[FieldOffset(Offset = "0x94")]
	public GameObject VFX_LadderMatch;

	[Token(Token = "0x40170AD")]
	[FieldOffset(Offset = "0x98")]
	public UINetworkTexture LiveCDN;

	[Token(Token = "0x40170AE")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite EsportsIcon;

	[Token(Token = "0x6016C89")]
	[Address(RVA = "0x1CAC5E8", Offset = "0x1CAC5E8", VA = "0x1CAC5E8")]
	public UILobbyNewRightBtnPanelView()
	{
	}

	[Token(Token = "0x6016C8A")]
	[Address(RVA = "0x1CAC5F0", Offset = "0x1CAC5F0", VA = "0x1CAC5F0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C8B")]
	[Address(RVA = "0x1CAD378", Offset = "0x1CAD378", VA = "0x1CAD378")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
