using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003828")]
public class UILinkActivityBombView : UIBaseView
{
	[Token(Token = "0x4016E3F")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture cdn;

	[Token(Token = "0x4016E40")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4016E41")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Desc;

	[Token(Token = "0x4016E42")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnClose;

	[Token(Token = "0x4016E43")]
	[FieldOffset(Offset = "0x24")]
	public UILabel RewardTitle;

	[Token(Token = "0x4016E44")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid RewardList;

	[Token(Token = "0x4016E45")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BigRewardDesc;

	[Token(Token = "0x4016E46")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnBox;

	[Token(Token = "0x4016E47")]
	[FieldOffset(Offset = "0x34")]
	public UISprite BigRewardIcon;

	[Token(Token = "0x4016E48")]
	[FieldOffset(Offset = "0x38")]
	public UILabel FinishCounts;

	[Token(Token = "0x4016E49")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel FinishCountsCurrent;

	[Token(Token = "0x4016E4A")]
	[FieldOffset(Offset = "0x40")]
	public UILabel FinishCountsTotal;

	[Token(Token = "0x4016E4B")]
	[FieldOffset(Offset = "0x44")]
	public UIProgressBar FinishProgress;

	[Token(Token = "0x4016E4C")]
	[FieldOffset(Offset = "0x48")]
	public UILabel Days;

	[Token(Token = "0x4016E4D")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BtnGoto;

	[Token(Token = "0x4016E4E")]
	[FieldOffset(Offset = "0x50")]
	public GameObject DailyRewardsGot;

	[Token(Token = "0x6016C23")]
	[Address(RVA = "0x254FE8C", Offset = "0x254FE8C", VA = "0x254FE8C")]
	public UILinkActivityBombView()
	{
	}

	[Token(Token = "0x6016C24")]
	[Address(RVA = "0x254FE94", Offset = "0x254FE94", VA = "0x254FE94", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C25")]
	[Address(RVA = "0x25505C4", Offset = "0x25505C4", VA = "0x25505C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
