using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034CA")]
public class UIDigitaluniverseBCollectionDoorView : UIBaseView
{
	[Token(Token = "0x4014AB4")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Main;

	[Token(Token = "0x4014AB5")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TopLeftContainer;

	[Token(Token = "0x4014AB6")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTextureExt TitleCDN;

	[Token(Token = "0x4014AB7")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnRule;

	[Token(Token = "0x4014AB8")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelDate;

	[Token(Token = "0x4014AB9")]
	[FieldOffset(Offset = "0x28")]
	public UIScrollView TabScrollView;

	[Token(Token = "0x4014ABA")]
	[FieldOffset(Offset = "0x2C")]
	public UITable TabTable;

	[Token(Token = "0x4014ABB")]
	[FieldOffset(Offset = "0x30")]
	public Transform TopRightContainer;

	[Token(Token = "0x4014ABC")]
	[FieldOffset(Offset = "0x34")]
	public GameObject RightContainer;

	[Token(Token = "0x4014ABD")]
	[FieldOffset(Offset = "0x38")]
	public GameObject TokenProgress;

	[Token(Token = "0x4014ABE")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel LabelTokenNum;

	[Token(Token = "0x4014ABF")]
	[FieldOffset(Offset = "0x40")]
	public UIGrid ExtraAwardList;

	[Token(Token = "0x4014AC0")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Spot1Pos;

	[Token(Token = "0x4014AC1")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Spot2Pos;

	[Token(Token = "0x4014AC2")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Spot3Pos;

	[Token(Token = "0x4014AC3")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Spot4Pos;

	[Token(Token = "0x4014AC4")]
	[FieldOffset(Offset = "0x54")]
	public GameObject Spot5Pos;

	[Token(Token = "0x4014AC5")]
	[FieldOffset(Offset = "0x58")]
	public GameObject Spot6Pos;

	[Token(Token = "0x4014AC6")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject Spot7Pos;

	[Token(Token = "0x4014AC7")]
	[FieldOffset(Offset = "0x60")]
	public Transform ProgressContainer;

	[Token(Token = "0x4014AC8")]
	[FieldOffset(Offset = "0x64")]
	public UIProgressBar LuckyProgressBar;

	[Token(Token = "0x4014AC9")]
	[FieldOffset(Offset = "0x68")]
	public GameObject ShootCon;

	[Token(Token = "0x4014ACA")]
	[FieldOffset(Offset = "0x6C")]
	public UINetworkTextureExt GunCDN;

	[Token(Token = "0x4014ACB")]
	[FieldOffset(Offset = "0x70")]
	public GameObject DailyRewardCon;

	[Token(Token = "0x4014ACC")]
	[FieldOffset(Offset = "0x74")]
	public UISprite RewardIcon;

	[Token(Token = "0x4014ACD")]
	[FieldOffset(Offset = "0x78")]
	public GameObject MissionRewardsCon;

	[Token(Token = "0x4014ACE")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject GunDetailCon;

	[Token(Token = "0x4014ACF")]
	[FieldOffset(Offset = "0x80")]
	public UIButton SwitchBtn;

	[Token(Token = "0x4014AD0")]
	[FieldOffset(Offset = "0x84")]
	public UITable MissionTable;

	[Token(Token = "0x4014AD1")]
	[FieldOffset(Offset = "0x88")]
	public UILabel GunNameLabel;

	[Token(Token = "0x4014AD2")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel GunDataLabel;

	[Token(Token = "0x4014AD3")]
	[FieldOffset(Offset = "0x90")]
	public UITable GunDataTable;

	[Token(Token = "0x4014AD4")]
	[FieldOffset(Offset = "0x94")]
	public UILabel KillNum;

	[Token(Token = "0x4014AD5")]
	[FieldOffset(Offset = "0x98")]
	public UILabel BooyahNum;

	[Token(Token = "0x4014AD6")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel GamesNum;

	[Token(Token = "0x4014AD7")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel HeadShotNum;

	[Token(Token = "0x4014AD8")]
	[FieldOffset(Offset = "0xA4")]
	public UIButton ShareBtn;

	[Token(Token = "0x4014AD9")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel ShareLabel;

	[Token(Token = "0x4014ADA")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel FirstShareBubbleLabel;

	[Token(Token = "0x4014ADB")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel ShareGunName;

	[Token(Token = "0x4014ADC")]
	[FieldOffset(Offset = "0xB4")]
	public UILabel ShareKillNum;

	[Token(Token = "0x4014ADD")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel ShareBooyahNum;

	[Token(Token = "0x4014ADE")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel ShareGamesNum;

	[Token(Token = "0x4014ADF")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel ShareHeadShotNum;

	[Token(Token = "0x4014AE0")]
	[FieldOffset(Offset = "0xC4")]
	public UITable ShareGunDataTable;

	[Token(Token = "0x4014AE1")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject IconMission;

	[Token(Token = "0x4014AE2")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject IconGun;

	[Token(Token = "0x4014AE3")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject ShareCon;

	[Token(Token = "0x4014AE4")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject MissionTitleUnlockTip;

	[Token(Token = "0x4014AE5")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject MissionTitleLockTip;

	[Token(Token = "0x4014AE6")]
	[FieldOffset(Offset = "0xDC")]
	public UILabel MissionFinishState;

	[Token(Token = "0x4014AE7")]
	[FieldOffset(Offset = "0xE0")]
	public UILabel MissionDayInfo;

	[Token(Token = "0x4014AE8")]
	[FieldOffset(Offset = "0xE4")]
	public UISprite MissionDayIcon;

	[Token(Token = "0x4014AE9")]
	[FieldOffset(Offset = "0xE8")]
	public UISprite MissionFinishIcon;

	[Token(Token = "0x4014AEA")]
	[FieldOffset(Offset = "0xEC")]
	public UINetworkTextureExt TitleCDNShare;

	[Token(Token = "0x4014AEB")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel LabelDateShare;

	[Token(Token = "0x4014AEC")]
	[FieldOffset(Offset = "0xF4")]
	public UIButton MaskBtn;

	[Token(Token = "0x4014AED")]
	[FieldOffset(Offset = "0xF8")]
	public UIPanel MaskPanel;

	[Token(Token = "0x4014AEE")]
	[FieldOffset(Offset = "0xFC")]
	public GameObject BgTexture;

	[Token(Token = "0x4014AEF")]
	[FieldOffset(Offset = "0x100")]
	public GameObject BigReward;

	[Token(Token = "0x4014AF0")]
	[FieldOffset(Offset = "0x104")]
	public Animator UIDigitaluniverseBCollectionDoor;

	[Token(Token = "0x4014AF1")]
	[FieldOffset(Offset = "0x108")]
	public GameObject BgTextureShare;

	[Token(Token = "0x4014AF2")]
	[FieldOffset(Offset = "0x10C")]
	public UIButton RewardByShowBtn;

	[Token(Token = "0x4014AF3")]
	[FieldOffset(Offset = "0x110")]
	public UILabel ShareTitle;

	[Token(Token = "0x4014AF4")]
	[FieldOffset(Offset = "0x114")]
	public UINetworkTextureExt GunIconTexture;

	[Token(Token = "0x4014AF5")]
	[FieldOffset(Offset = "0x118")]
	public UINetworkTextureExt ShareGunSprite;

	[Token(Token = "0x4014AF6")]
	[FieldOffset(Offset = "0x11C")]
	public GameObject RewardMask;

	[Token(Token = "0x4014AF7")]
	[FieldOffset(Offset = "0x120")]
	public UILabel MissionTitleLabel;

	[Token(Token = "0x4014AF8")]
	[FieldOffset(Offset = "0x124")]
	public UIWidget GuideWidget;

	[Token(Token = "0x4014AF9")]
	[FieldOffset(Offset = "0x128")]
	public GameObject LeftContainer;

	[Token(Token = "0x4014AFA")]
	[FieldOffset(Offset = "0x12C")]
	public GameObject MissionCon;

	[Token(Token = "0x6016212")]
	[Address(RVA = "0x2AD5F74", Offset = "0x2AD5F74", VA = "0x2AD5F74")]
	public UIDigitaluniverseBCollectionDoorView()
	{
	}

	[Token(Token = "0x6016213")]
	[Address(RVA = "0x2AD5F7C", Offset = "0x2AD5F7C", VA = "0x2AD5F7C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016214")]
	[Address(RVA = "0x2AD79DC", Offset = "0x2AD79DC", VA = "0x2AD79DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
