using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003533")]
public class UIFFWS03MainView : UIBaseView
{
	[Token(Token = "0x4015047")]
	[FieldOffset(Offset = "0x14")]
	public Transform TopBtnContainer;

	[Token(Token = "0x4015048")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTextureExt TitleCDN;

	[Token(Token = "0x4015049")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnRule;

	[Token(Token = "0x401504A")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelDate;

	[Token(Token = "0x401504B")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid EntrenceGrid;

	[Token(Token = "0x401504C")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnPeakDay;

	[Token(Token = "0x401504D")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Bubble;

	[Token(Token = "0x401504E")]
	[FieldOffset(Offset = "0x30")]
	public UILabel BubbleLabel;

	[Token(Token = "0x401504F")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LabelPeakDayDate;

	[Token(Token = "0x4015050")]
	[FieldOffset(Offset = "0x38")]
	public GameObject BubbleVFX;

	[Token(Token = "0x4015051")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton BtnRevenue;

	[Token(Token = "0x4015052")]
	[FieldOffset(Offset = "0x40")]
	public UILabel LabelRevenue1;

	[Token(Token = "0x4015053")]
	[FieldOffset(Offset = "0x44")]
	public GameObject BtnRevenueOpen;

	[Token(Token = "0x4015054")]
	[FieldOffset(Offset = "0x48")]
	public GameObject BtnRevenueRedPoint;

	[Token(Token = "0x4015055")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject BtnRevenueGrey;

	[Token(Token = "0x4015056")]
	[FieldOffset(Offset = "0x50")]
	public UIButton BtnRevenue2;

	[Token(Token = "0x4015057")]
	[FieldOffset(Offset = "0x54")]
	public UILabel LabelRevenue2;

	[Token(Token = "0x4015058")]
	[FieldOffset(Offset = "0x58")]
	public GameObject BtnRevenue2Open;

	[Token(Token = "0x4015059")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject BtnRevenue2RedPoint;

	[Token(Token = "0x401505A")]
	[FieldOffset(Offset = "0x60")]
	public GameObject BtnRevenue2Grey;

	[Token(Token = "0x401505B")]
	[FieldOffset(Offset = "0x64")]
	public UIButton BtnCup;

	[Token(Token = "0x401505C")]
	[FieldOffset(Offset = "0x68")]
	public GameObject BtnCupOpen;

	[Token(Token = "0x401505D")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject BtnCupRedPoint;

	[Token(Token = "0x401505E")]
	[FieldOffset(Offset = "0x70")]
	public UIButton BtnGuess;

	[Token(Token = "0x401505F")]
	[FieldOffset(Offset = "0x74")]
	public UILabel LabelGuess;

	[Token(Token = "0x4015060")]
	[FieldOffset(Offset = "0x78")]
	public GameObject BtnGuessGrey;

	[Token(Token = "0x4015061")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject BtnGuessOpen;

	[Token(Token = "0x4015062")]
	[FieldOffset(Offset = "0x80")]
	public GameObject BtnGuessRedPoint;

	[Token(Token = "0x4015063")]
	[FieldOffset(Offset = "0x84")]
	public GameObject BtnGuessRewardTip;

	[Token(Token = "0x4015064")]
	[FieldOffset(Offset = "0x88")]
	public GameObject BtnGuessGuide;

	[Token(Token = "0x4015065")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton BtnFFManager;

	[Token(Token = "0x4015066")]
	[FieldOffset(Offset = "0x90")]
	public UILabel LabelFFManager;

	[Token(Token = "0x4015067")]
	[FieldOffset(Offset = "0x94")]
	public GameObject BtnFFManagerGrey;

	[Token(Token = "0x4015068")]
	[FieldOffset(Offset = "0x98")]
	public GameObject BtnFFManagerOpen;

	[Token(Token = "0x4015069")]
	[FieldOffset(Offset = "0x9C")]
	public UIButton BtnStore;

	[Token(Token = "0x401506A")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel LabelStore;

	[Token(Token = "0x401506B")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject BtnStoreGrey;

	[Token(Token = "0x401506C")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject BtnStoreOpen;

	[Token(Token = "0x401506D")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject BtnStoreRedPoint;

	[Token(Token = "0x401506E")]
	[FieldOffset(Offset = "0xB0")]
	public UIButton BtnGoWeb;

	[Token(Token = "0x401506F")]
	[FieldOffset(Offset = "0xB4")]
	public UILabel LabelGoWeb;

	[Token(Token = "0x4015070")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject BtnGoWebGrey;

	[Token(Token = "0x4015071")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject BtnGoWebOpen;

	[Token(Token = "0x4015072")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject BtnGoWebRedPoint;

	[Token(Token = "0x4015073")]
	[FieldOffset(Offset = "0xC4")]
	public UIButton BtnLive;

	[Token(Token = "0x4015074")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel LabelLive;

	[Token(Token = "0x4015075")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject BtnLiveOpen;

	[Token(Token = "0x4015076")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject BtnLiveRedPoint;

	[Token(Token = "0x4015077")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject BtnLiveGrey;

	[Token(Token = "0x4015078")]
	[FieldOffset(Offset = "0xD8")]
	public Animation Anim;

	[Token(Token = "0x4015079")]
	[FieldOffset(Offset = "0xDC")]
	public GameObject Body;

	[Token(Token = "0x401507A")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject AnimMask;

	[Token(Token = "0x401507B")]
	[FieldOffset(Offset = "0xE4")]
	public UINetworkTextureExt CDNRevenue2;

	[Token(Token = "0x401507C")]
	[FieldOffset(Offset = "0xE8")]
	public UINetworkTextureExt CDNRevenue;

	[Token(Token = "0x401507D")]
	[FieldOffset(Offset = "0xEC")]
	public GameObject Revene2Icon;

	[Token(Token = "0x401507E")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject RevenueIcon;

	[Token(Token = "0x401507F")]
	[FieldOffset(Offset = "0xF4")]
	public GameObject TopLeft;

	[Token(Token = "0x4015080")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject Center;

	[Token(Token = "0x4015081")]
	[FieldOffset(Offset = "0xFC")]
	public GameObject BottomLeft;

	[Token(Token = "0x4015082")]
	[FieldOffset(Offset = "0x100")]
	public GameObject BottomRight;

	[Token(Token = "0x4015083")]
	[FieldOffset(Offset = "0x104")]
	public GameObject FFManagerRedPoint;

	[Token(Token = "0x4015084")]
	[FieldOffset(Offset = "0x108")]
	public GameObject VFXCup;

	[Token(Token = "0x6016349")]
	[Address(RVA = "0x19EF340", Offset = "0x19EF340", VA = "0x19EF340")]
	public UIFFWS03MainView()
	{
	}

	[Token(Token = "0x601634A")]
	[Address(RVA = "0x19EF348", Offset = "0x19EF348", VA = "0x19EF348", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601634B")]
	[Address(RVA = "0x19F09F8", Offset = "0x19F09F8", VA = "0x19F09F8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
