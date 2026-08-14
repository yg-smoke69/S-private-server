using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200382E")]
public class UILinkActivitySimpleView : UIBaseView
{
	[Token(Token = "0x4016E7B")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture cdn;

	[Token(Token = "0x4016E7C")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4016E7D")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Desc;

	[Token(Token = "0x4016E7E")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnClose;

	[Token(Token = "0x4016E7F")]
	[FieldOffset(Offset = "0x24")]
	public UILabel RewardTitle;

	[Token(Token = "0x4016E80")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid RewardList;

	[Token(Token = "0x4016E81")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BigRewardDesc;

	[Token(Token = "0x4016E82")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnBox;

	[Token(Token = "0x4016E83")]
	[FieldOffset(Offset = "0x34")]
	public UISprite BigRewardIcon;

	[Token(Token = "0x4016E84")]
	[FieldOffset(Offset = "0x38")]
	public UILabel FinishCounts;

	[Token(Token = "0x4016E85")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel FinishCountsCurrent;

	[Token(Token = "0x4016E86")]
	[FieldOffset(Offset = "0x40")]
	public UILabel FinishCountsTotal;

	[Token(Token = "0x4016E87")]
	[FieldOffset(Offset = "0x44")]
	public UIProgressBar FinishProgress;

	[Token(Token = "0x4016E88")]
	[FieldOffset(Offset = "0x48")]
	public UILabel Days;

	[Token(Token = "0x4016E89")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BtnGoto;

	[Token(Token = "0x4016E8A")]
	[FieldOffset(Offset = "0x50")]
	public GameObject DailyRewardsGot;

	[Token(Token = "0x6016C35")]
	[Address(RVA = "0x255A460", Offset = "0x255A460", VA = "0x255A460")]
	public UILinkActivitySimpleView()
	{
	}

	[Token(Token = "0x6016C36")]
	[Address(RVA = "0x255A468", Offset = "0x255A468", VA = "0x255A468", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C37")]
	[Address(RVA = "0x255AB98", Offset = "0x255AB98", VA = "0x255AB98")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
