using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034D5")]
public class UIDigitaluniverseBMapDoorView : UIBaseView
{
	[Token(Token = "0x4014BA8")]
	[FieldOffset(Offset = "0x14")]
	public GameObject TopRightContainer;

	[Token(Token = "0x4014BA9")]
	[FieldOffset(Offset = "0x18")]
	public UIButton MapArea1;

	[Token(Token = "0x4014BAA")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton MapArea2;

	[Token(Token = "0x4014BAB")]
	[FieldOffset(Offset = "0x20")]
	public UIButton MapArea3;

	[Token(Token = "0x4014BAC")]
	[FieldOffset(Offset = "0x24")]
	public UIButton MapArea4;

	[Token(Token = "0x4014BAD")]
	[FieldOffset(Offset = "0x28")]
	public UIButton MapArea5;

	[Token(Token = "0x4014BAE")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton MapArea6;

	[Token(Token = "0x4014BAF")]
	[FieldOffset(Offset = "0x30")]
	public UIButton MapArea7;

	[Token(Token = "0x4014BB0")]
	[FieldOffset(Offset = "0x34")]
	public UIButton MapArea8;

	[Token(Token = "0x4014BB1")]
	[FieldOffset(Offset = "0x38")]
	public UIButton MapArea9;

	[Token(Token = "0x4014BB2")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton MapArea10;

	[Token(Token = "0x4014BB3")]
	[FieldOffset(Offset = "0x40")]
	public Transform MissionList;

	[Token(Token = "0x4014BB4")]
	[FieldOffset(Offset = "0x44")]
	public UIGrid MissionGrid;

	[Token(Token = "0x4014BB5")]
	[FieldOffset(Offset = "0x48")]
	public UIButton GoBtn;

	[Token(Token = "0x4014BB6")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Claimed;

	[Token(Token = "0x4014BB7")]
	[FieldOffset(Offset = "0x50")]
	public UIButton ClaimBtn;

	[Token(Token = "0x4014BB8")]
	[FieldOffset(Offset = "0x54")]
	public GameObject Map;

	[Token(Token = "0x4014BB9")]
	[FieldOffset(Offset = "0x58")]
	public Animation MapAreaUavAnim;

	[Token(Token = "0x4014BBA")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject Uav_Anim;

	[Token(Token = "0x4014BBB")]
	[FieldOffset(Offset = "0x60")]
	public GameObject MissionContent;

	[Token(Token = "0x4014BBC")]
	[FieldOffset(Offset = "0x64")]
	public UILabel LabelTokenNum;

	[Token(Token = "0x4014BBD")]
	[FieldOffset(Offset = "0x68")]
	public GameObject Spot1Pos;

	[Token(Token = "0x4014BBE")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject Spot2Pos;

	[Token(Token = "0x4014BBF")]
	[FieldOffset(Offset = "0x70")]
	public GameObject Spot3Pos;

	[Token(Token = "0x4014BC0")]
	[FieldOffset(Offset = "0x74")]
	public GameObject Spot4Pos;

	[Token(Token = "0x4014BC1")]
	[FieldOffset(Offset = "0x78")]
	public GameObject Spot5Pos;

	[Token(Token = "0x4014BC2")]
	[FieldOffset(Offset = "0x7C")]
	public UIProgressBar LuckyProgressBar;

	[Token(Token = "0x4014BC3")]
	[FieldOffset(Offset = "0x80")]
	public UINetworkTextureExt TitleCDN;

	[Token(Token = "0x4014BC4")]
	[FieldOffset(Offset = "0x84")]
	public UIButton BtnRule;

	[Token(Token = "0x4014BC5")]
	[FieldOffset(Offset = "0x88")]
	public UILabel LabelDate;

	[Token(Token = "0x4014BC6")]
	[FieldOffset(Offset = "0x8C")]
	public UIGrid RewardGrid;

	[Token(Token = "0x4014BC7")]
	[FieldOffset(Offset = "0x90")]
	public Transform ProgressContainer;

	[Token(Token = "0x4014BC8")]
	[FieldOffset(Offset = "0x94")]
	public TweenPositionArc VFX_trail;

	[Token(Token = "0x4014BC9")]
	[FieldOffset(Offset = "0x98")]
	public GameObject Main;

	[Token(Token = "0x4014BCA")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject GuideContent1;

	[Token(Token = "0x4014BCB")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel LabelGuide1;

	[Token(Token = "0x4014BCC")]
	[FieldOffset(Offset = "0xA4")]
	public TypewriterEffect LabelGuide1Type;

	[Token(Token = "0x4014BCD")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject LabelContinue;

	[Token(Token = "0x4014BCE")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject GuideContent2;

	[Token(Token = "0x4014BCF")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject GuideContent3;

	[Token(Token = "0x4014BD0")]
	[FieldOffset(Offset = "0xB4")]
	public UIButton Mask;

	[Token(Token = "0x4014BD1")]
	[FieldOffset(Offset = "0xB8")]
	public UIButton ShareBtn;

	[Token(Token = "0x4014BD2")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel FirstShareBubbleLabel;

	[Token(Token = "0x4014BD3")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject TokenProgress;

	[Token(Token = "0x4014BD4")]
	[FieldOffset(Offset = "0xC4")]
	public UISprite GoBtnBG;

	[Token(Token = "0x4014BD5")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel GoBtnLabel;

	[Token(Token = "0x4014BD6")]
	[FieldOffset(Offset = "0xCC")]
	public UISprite GoBtnSprite1;

	[Token(Token = "0x4014BD7")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite GoBtnSprite2;

	[Token(Token = "0x4014BD8")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject VFX_light1;

	[Token(Token = "0x4014BD9")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject VFX_light2;

	[Token(Token = "0x4014BDA")]
	[FieldOffset(Offset = "0xDC")]
	public GameObject VFX_light3;

	[Token(Token = "0x4014BDB")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject VFX_light4;

	[Token(Token = "0x4014BDC")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject VFX_light5;

	[Token(Token = "0x4014BDD")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject VFX_light6;

	[Token(Token = "0x4014BDE")]
	[FieldOffset(Offset = "0xEC")]
	public GameObject VFX_light7;

	[Token(Token = "0x4014BDF")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject VFX_light8;

	[Token(Token = "0x4014BE0")]
	[FieldOffset(Offset = "0xF4")]
	public GameObject VFX_light9;

	[Token(Token = "0x4014BE1")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject VFX_light10;

	[Token(Token = "0x4014BE2")]
	[FieldOffset(Offset = "0xFC")]
	public UILabel TitleLabel;

	[Token(Token = "0x4014BE3")]
	[FieldOffset(Offset = "0x100")]
	public UIEffectWidget VFX_juqing;

	[Token(Token = "0x4014BE4")]
	[FieldOffset(Offset = "0x104")]
	public GameObject VFX_chuchang;

	[Token(Token = "0x4014BE5")]
	[FieldOffset(Offset = "0x108")]
	public Transform TopLeftContainer;

	[Token(Token = "0x6016233")]
	[Address(RVA = "0x2F7D40C", Offset = "0x2F7D40C", VA = "0x2F7D40C")]
	public UIDigitaluniverseBMapDoorView()
	{
	}

	[Token(Token = "0x6016234")]
	[Address(RVA = "0x2F7D414", Offset = "0x2F7D414", VA = "0x2F7D414", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016235")]
	[Address(RVA = "0x2F7EAE0", Offset = "0x2F7EAE0", VA = "0x2F7EAE0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
