using GCommon;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034DC")]
public class UIDigitaluniverseBRoleDoorView : UIBaseView
{
	[Token(Token = "0x4014C25")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnRule;

	[Token(Token = "0x4014C26")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTextureExt TitleCDN;

	[Token(Token = "0x4014C27")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelDate;

	[Token(Token = "0x4014C28")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnConcertMode;

	[Token(Token = "0x4014C29")]
	[FieldOffset(Offset = "0x24")]
	public GameObject DailyMissionContainer;

	[Token(Token = "0x4014C2A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CountDownMissionContainer;

	[Token(Token = "0x4014C2B")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject CompleteMissionContainer;

	[Token(Token = "0x4014C2C")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LabelTaskDesc;

	[Token(Token = "0x4014C2D")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LabelMaxProgress;

	[Token(Token = "0x4014C2E")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LabelCurProgress;

	[Token(Token = "0x4014C2F")]
	[FieldOffset(Offset = "0x3C")]
	public UIProgressScrollBar ScrollbarBg;

	[Token(Token = "0x4014C30")]
	[FieldOffset(Offset = "0x40")]
	public UIGrid ItemGridOnTime;

	[Token(Token = "0x4014C31")]
	[FieldOffset(Offset = "0x44")]
	public UICountDownLabel LabelCountTime;

	[Token(Token = "0x4014C32")]
	[FieldOffset(Offset = "0x48")]
	public GameObject LabelMillionCountTime;

	[Token(Token = "0x4014C33")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BtnClaim;

	[Token(Token = "0x4014C34")]
	[FieldOffset(Offset = "0x50")]
	public UILabel LabelBtn;

	[Token(Token = "0x4014C35")]
	[FieldOffset(Offset = "0x54")]
	public GameObject SpriteBtnGrey;

	[Token(Token = "0x4014C36")]
	[FieldOffset(Offset = "0x58")]
	public UILabel LabelTokenNum;

	[Token(Token = "0x4014C37")]
	[FieldOffset(Offset = "0x5C")]
	public UIProgressBar LuckyProgressBar;

	[Token(Token = "0x4014C38")]
	[FieldOffset(Offset = "0x60")]
	public Transform Spot1Pos;

	[Token(Token = "0x4014C39")]
	[FieldOffset(Offset = "0x64")]
	public Transform Spot2Pos;

	[Token(Token = "0x4014C3A")]
	[FieldOffset(Offset = "0x68")]
	public Transform Spot3Pos;

	[Token(Token = "0x4014C3B")]
	[FieldOffset(Offset = "0x6C")]
	public Transform Spot4Pos;

	[Token(Token = "0x4014C3C")]
	[FieldOffset(Offset = "0x70")]
	public Transform Spot5Pos;

	[Token(Token = "0x4014C3D")]
	[FieldOffset(Offset = "0x74")]
	public SkeletonAnimation RightRoleIdle2;

	[Token(Token = "0x4014C3E")]
	[FieldOffset(Offset = "0x78")]
	public SkeletonAnimation RightRoleIdle1;

	[Token(Token = "0x4014C3F")]
	[FieldOffset(Offset = "0x7C")]
	public SkeletonAnimation RightRoleIdle3;

	[Token(Token = "0x4014C40")]
	[FieldOffset(Offset = "0x80")]
	public SkeletonAnimation RightRoleIdle4;

	[Token(Token = "0x4014C41")]
	[FieldOffset(Offset = "0x84")]
	public SkeletonAnimation RightRoleIdle5;

	[Token(Token = "0x4014C42")]
	[FieldOffset(Offset = "0x88")]
	public GameObject LabelFinishiOnTime;

	[Token(Token = "0x4014C43")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject LabelFinishOutOfTime;

	[Token(Token = "0x4014C44")]
	[FieldOffset(Offset = "0x90")]
	public GameObject TokenProgress;

	[Token(Token = "0x4014C45")]
	[FieldOffset(Offset = "0x94")]
	public UIGrid ExtraAwardList;

	[Token(Token = "0x4014C46")]
	[FieldOffset(Offset = "0x98")]
	public Transform TopRightContainer;

	[Token(Token = "0x4014C47")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject CenterContainer;

	[Token(Token = "0x4014C48")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject TopContainer;

	[Token(Token = "0x4014C49")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject RightContainer;

	[Token(Token = "0x4014C4A")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject BottomRightContainer;

	[Token(Token = "0x4014C4B")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject LeftContainer;

	[Token(Token = "0x4014C4C")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject TopLeftContainer;

	[Token(Token = "0x4014C4D")]
	[FieldOffset(Offset = "0xB4")]
	public UIGrid Grid;

	[Token(Token = "0x4014C4E")]
	[FieldOffset(Offset = "0xB8")]
	public UICountDownLabel LabelCountTime_Shadow;

	[Token(Token = "0x4014C4F")]
	[FieldOffset(Offset = "0xBC")]
	public UISprite bg;

	[Token(Token = "0x4014C50")]
	[FieldOffset(Offset = "0xC0")]
	public UIPanel ScrollView;

	[Token(Token = "0x4014C51")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject CountDownContainer;

	[Token(Token = "0x4014C52")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel LabelMissionType;

	[Token(Token = "0x4014C53")]
	[FieldOffset(Offset = "0xCC")]
	public UILabel LabelDesc;

	[Token(Token = "0x4014C54")]
	[FieldOffset(Offset = "0xD0")]
	public UIButton BtnCountDownMission;

	[Token(Token = "0x4014C55")]
	[FieldOffset(Offset = "0xD4")]
	public UIGrid ItemGridOutofTime;

	[Token(Token = "0x4014C56")]
	[FieldOffset(Offset = "0xD8")]
	public TweenPositionArc VFX_trail;

	[Token(Token = "0x4014C57")]
	[FieldOffset(Offset = "0xDC")]
	public Transform ProgressContainer;

	[Token(Token = "0x4014C58")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject Plus;

	[Token(Token = "0x4014C59")]
	[FieldOffset(Offset = "0xE4")]
	public Transform Pos_VFX;

	[Token(Token = "0x4014C5A")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject VFX_chuchang;

	[Token(Token = "0x4014C5B")]
	[FieldOffset(Offset = "0xEC")]
	public GameObject Main;

	[Token(Token = "0x4014C5C")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel LabelNum;

	[Token(Token = "0x4014C5D")]
	[FieldOffset(Offset = "0xF4")]
	public GameObject VFX;

	[Token(Token = "0x6016246")]
	[Address(RVA = "0x2F09C54", Offset = "0x2F09C54", VA = "0x2F09C54")]
	public UIDigitaluniverseBRoleDoorView()
	{
	}

	[Token(Token = "0x6016247")]
	[Address(RVA = "0x2F09C5C", Offset = "0x2F09C5C", VA = "0x2F09C5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016248")]
	[Address(RVA = "0x2F0B0E0", Offset = "0x2F0B0E0", VA = "0x2F0B0E0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
