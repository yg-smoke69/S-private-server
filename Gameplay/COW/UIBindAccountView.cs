using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003403")]
public class UIBindAccountView : UIBaseView
{
	[Token(Token = "0x40140A7")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture CDNEPWebSite;

	[Token(Token = "0x40140A8")]
	[FieldOffset(Offset = "0x18")]
	public UIButton CloseBtn;

	[Token(Token = "0x40140A9")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelInfo;

	[Token(Token = "0x40140AA")]
	[FieldOffset(Offset = "0x20")]
	public Transform AwardGrid;

	[Token(Token = "0x40140AB")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid AccountBtnCenter;

	[Token(Token = "0x40140AC")]
	[FieldOffset(Offset = "0x28")]
	public UIButton HWBtn;

	[Token(Token = "0x40140AD")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton FBBtn;

	[Token(Token = "0x40140AE")]
	[FieldOffset(Offset = "0x30")]
	public UIButton VKBtn;

	[Token(Token = "0x40140AF")]
	[FieldOffset(Offset = "0x34")]
	public UIButton GoogleBtn;

	[Token(Token = "0x40140B0")]
	[FieldOffset(Offset = "0x38")]
	public UIButton AppleBtn;

	[Token(Token = "0x40140B1")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton TwitterBtn;

	[Token(Token = "0x40140B2")]
	[FieldOffset(Offset = "0x40")]
	public UIButton PlatformCombinedBtn;

	[Token(Token = "0x40140B3")]
	[FieldOffset(Offset = "0x44")]
	public Transform MorePlatformPanel;

	[Token(Token = "0x40140B4")]
	[FieldOffset(Offset = "0x48")]
	public GameObject RankLockContainer;

	[Token(Token = "0x40140B5")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel UnlockRankLabel;

	[Token(Token = "0x40140B6")]
	[FieldOffset(Offset = "0x50")]
	public UILabel BindRewardLabel;

	[Token(Token = "0x6015FBD")]
	[Address(RVA = "0x10D72EC", Offset = "0x10D72EC", VA = "0x10D72EC")]
	public UIBindAccountView()
	{
	}

	[Token(Token = "0x6015FBE")]
	[Address(RVA = "0x10D72F4", Offset = "0x10D72F4", VA = "0x10D72F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FBF")]
	[Address(RVA = "0x10D79E0", Offset = "0x10D79E0", VA = "0x10D79E0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
