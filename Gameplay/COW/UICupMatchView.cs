using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034AB")]
public class UICupMatchView : UIBaseView
{
	[Token(Token = "0x401490F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton NoticeBtn;

	[Token(Token = "0x4014910")]
	[FieldOffset(Offset = "0x18")]
	public Transform LeftTabContainer;

	[Token(Token = "0x4014911")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject MainPage;

	[Token(Token = "0x4014912")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ModeName;

	[Token(Token = "0x4014913")]
	[FieldOffset(Offset = "0x24")]
	public UILabel PlayerCount;

	[Token(Token = "0x4014914")]
	[FieldOffset(Offset = "0x28")]
	public UILabel NoWeaponSkinBonus;

	[Token(Token = "0x4014915")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel OpenTimeInWeek;

	[Token(Token = "0x4014916")]
	[FieldOffset(Offset = "0x30")]
	public UILabel OpenTimeInDay;

	[Token(Token = "0x4014917")]
	[FieldOffset(Offset = "0x34")]
	public Transform Reward1;

	[Token(Token = "0x4014918")]
	[FieldOffset(Offset = "0x38")]
	public Transform Reward2;

	[Token(Token = "0x4014919")]
	[FieldOffset(Offset = "0x3C")]
	public Transform Reward3;

	[Token(Token = "0x401491A")]
	[FieldOffset(Offset = "0x40")]
	public Transform Reward4;

	[Token(Token = "0x401491B")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BtnShowAllReward;

	[Token(Token = "0x401491C")]
	[FieldOffset(Offset = "0x48")]
	public GameObject SeasonInfo;

	[Token(Token = "0x401491D")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel SeasonName;

	[Token(Token = "0x401491E")]
	[FieldOffset(Offset = "0x50")]
	public UILabel MatchTime;

	[Token(Token = "0x401491F")]
	[FieldOffset(Offset = "0x54")]
	public UILabel SeasonNum;

	[Token(Token = "0x4014920")]
	[FieldOffset(Offset = "0x58")]
	public UIButton SeasonTipsBtn;

	[Token(Token = "0x4014921")]
	[FieldOffset(Offset = "0x5C")]
	public Transform Center;

	[Token(Token = "0x4014922")]
	[FieldOffset(Offset = "0x60")]
	public GameObject SeasonIcon;

	[Token(Token = "0x4014923")]
	[FieldOffset(Offset = "0x64")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x4014924")]
	[FieldOffset(Offset = "0x68")]
	public GameObject DefaultIcon;

	[Token(Token = "0x4014925")]
	[FieldOffset(Offset = "0x6C")]
	public UIToggleButton PrepareBtn;

	[Token(Token = "0x4014926")]
	[FieldOffset(Offset = "0x70")]
	public UIToggleButton OpenBtn;

	[Token(Token = "0x4014927")]
	[FieldOffset(Offset = "0x74")]
	public UIToggleButton CheckBtn;

	[Token(Token = "0x4014928")]
	[FieldOffset(Offset = "0x78")]
	public UIToggleButton SettleBtn;

	[Token(Token = "0x4014929")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel TierMain;

	[Token(Token = "0x401492A")]
	[FieldOffset(Offset = "0x80")]
	public UILabel TierDescriptionMain;

	[Token(Token = "0x401492B")]
	[FieldOffset(Offset = "0x84")]
	public UIButton BtnNewMore;

	[Token(Token = "0x401492C")]
	[FieldOffset(Offset = "0x88")]
	public Transform BottomRight;

	[Token(Token = "0x401492D")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton StartMatchBtn;

	[Token(Token = "0x401492E")]
	[FieldOffset(Offset = "0x90")]
	public UISprite StartMatchBtnBG;

	[Token(Token = "0x401492F")]
	[FieldOffset(Offset = "0x94")]
	public GameObject VFXStartClickable;

	[Token(Token = "0x4014930")]
	[FieldOffset(Offset = "0x98")]
	public UIButton BtnMainPageJoin;

	[Token(Token = "0x4014931")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject VFX_JoinBlink;

	[Token(Token = "0x4014932")]
	[FieldOffset(Offset = "0xA0")]
	public UIButton BtnMainPageRecuit;

	[Token(Token = "0x4014933")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject VFX_RecruitBlink;

	[Token(Token = "0x4014934")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel RemainSessionLabel;

	[Token(Token = "0x4014935")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject TeamPage;

	[Token(Token = "0x4014936")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject CoursePage;

	[Token(Token = "0x4014937")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject AccomplishedPage;

	[Token(Token = "0x4014938")]
	[FieldOffset(Offset = "0xB8")]
	public UIButton BtnAccomplished;

	[Token(Token = "0x4014939")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel BtnAccomplishedLabel;

	[Token(Token = "0x60161B5")]
	[Address(RVA = "0x11E6908", Offset = "0x11E6908", VA = "0x11E6908")]
	public UICupMatchView()
	{
	}

	[Token(Token = "0x60161B6")]
	[Address(RVA = "0x11E6910", Offset = "0x11E6910", VA = "0x11E6910", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161B7")]
	[Address(RVA = "0x11E78E8", Offset = "0x11E78E8", VA = "0x11E78E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
