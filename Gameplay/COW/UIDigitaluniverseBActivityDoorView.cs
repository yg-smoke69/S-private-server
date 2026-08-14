using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034C6")]
public class UIDigitaluniverseBActivityDoorView : UIBaseView
{
	[Token(Token = "0x4014A54")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Main;

	[Token(Token = "0x4014A55")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TopLeftContainer;

	[Token(Token = "0x4014A56")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTextureExt TitleCDN;

	[Token(Token = "0x4014A57")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnRule;

	[Token(Token = "0x4014A58")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelDate;

	[Token(Token = "0x4014A59")]
	[FieldOffset(Offset = "0x28")]
	public UIScrollView TabScrollView;

	[Token(Token = "0x4014A5A")]
	[FieldOffset(Offset = "0x2C")]
	public Transform TopRightContainer;

	[Token(Token = "0x4014A5B")]
	[FieldOffset(Offset = "0x30")]
	public GameObject RightContainer;

	[Token(Token = "0x4014A5C")]
	[FieldOffset(Offset = "0x34")]
	public GameObject TokenProgress;

	[Token(Token = "0x4014A5D")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LabelTokenNum;

	[Token(Token = "0x4014A5E")]
	[FieldOffset(Offset = "0x3C")]
	public UIGrid ExtraAwardList;

	[Token(Token = "0x4014A5F")]
	[FieldOffset(Offset = "0x40")]
	public Transform ProgressContainer;

	[Token(Token = "0x4014A60")]
	[FieldOffset(Offset = "0x44")]
	public Transform Spot1Pos;

	[Token(Token = "0x4014A61")]
	[FieldOffset(Offset = "0x48")]
	public Transform Spot2Pos;

	[Token(Token = "0x4014A62")]
	[FieldOffset(Offset = "0x4C")]
	public Transform Spot3Pos;

	[Token(Token = "0x4014A63")]
	[FieldOffset(Offset = "0x50")]
	public Transform Spot4Pos;

	[Token(Token = "0x4014A64")]
	[FieldOffset(Offset = "0x54")]
	public Transform Spot5Pos;

	[Token(Token = "0x4014A65")]
	[FieldOffset(Offset = "0x58")]
	public Transform Spot6Pos;

	[Token(Token = "0x4014A66")]
	[FieldOffset(Offset = "0x5C")]
	public Transform Spot7Pos;

	[Token(Token = "0x4014A67")]
	[FieldOffset(Offset = "0x60")]
	public UIProgressBar LuckyProgressBar;

	[Token(Token = "0x4014A68")]
	[FieldOffset(Offset = "0x64")]
	public UITable MissionTable;

	[Token(Token = "0x4014A69")]
	[FieldOffset(Offset = "0x68")]
	public GameObject BGVFX;

	[Token(Token = "0x4014A6A")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject ShareCon;

	[Token(Token = "0x4014A6B")]
	[FieldOffset(Offset = "0x70")]
	public UIButton CardClickBtn;

	[Token(Token = "0x4014A6C")]
	[FieldOffset(Offset = "0x74")]
	public UISprite CardSprite;

	[Token(Token = "0x4014A6D")]
	[FieldOffset(Offset = "0x78")]
	public GameObject LightVFX;

	[Token(Token = "0x4014A6E")]
	[FieldOffset(Offset = "0x7C")]
	public UISprite CardMaskSprite;

	[Token(Token = "0x4014A6F")]
	[FieldOffset(Offset = "0x80")]
	public UITable TabTable;

	[Token(Token = "0x4014A70")]
	[FieldOffset(Offset = "0x84")]
	public GameObject MissionTitleLockTip;

	[Token(Token = "0x4014A71")]
	[FieldOffset(Offset = "0x88")]
	public UILabel MissionFinishState;

	[Token(Token = "0x4014A72")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel MissionDayInfo;

	[Token(Token = "0x4014A73")]
	[FieldOffset(Offset = "0x90")]
	public UISprite MissionDayIcon;

	[Token(Token = "0x4014A74")]
	[FieldOffset(Offset = "0x94")]
	public UISprite MissionFinishIcon;

	[Token(Token = "0x4014A75")]
	[FieldOffset(Offset = "0x98")]
	public GameObject SecondGuideCon;

	[Token(Token = "0x4014A76")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject GuidePanel;

	[Token(Token = "0x4014A77")]
	[FieldOffset(Offset = "0xA0")]
	public UIButton GuideMaskBtn;

	[Token(Token = "0x4014A78")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject MaskSprite;

	[Token(Token = "0x4014A79")]
	[FieldOffset(Offset = "0xA8")]
	public UIButton FirstGuideBtn;

	[Token(Token = "0x4014A7A")]
	[FieldOffset(Offset = "0xAC")]
	public Animator TimeMachineCon;

	[Token(Token = "0x4014A7B")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject CardPassIcon;

	[Token(Token = "0x4014A7C")]
	[FieldOffset(Offset = "0xB4")]
	public UILabel CardTitle;

	[Token(Token = "0x4014A7D")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject MissionTitleUnlockTip;

	[Token(Token = "0x4014A7E")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel MissionTitleLabel;

	[Token(Token = "0x4014A7F")]
	[FieldOffset(Offset = "0xC0")]
	public Animation InAni;

	[Token(Token = "0x4014A80")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject LeftContainer;

	[Token(Token = "0x6016206")]
	[Address(RVA = "0x2D98DC4", Offset = "0x2D98DC4", VA = "0x2D98DC4")]
	public UIDigitaluniverseBActivityDoorView()
	{
	}

	[Token(Token = "0x6016207")]
	[Address(RVA = "0x2D98DCC", Offset = "0x2D98DCC", VA = "0x2D98DCC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016208")]
	[Address(RVA = "0x2D99DE4", Offset = "0x2D99DE4", VA = "0x2D99DE4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
