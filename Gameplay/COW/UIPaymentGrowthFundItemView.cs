using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038EA")]
public class UIPaymentGrowthFundItemView : UIBaseView
{
	[Token(Token = "0x4017A1C")]
	[FieldOffset(Offset = "0x14")]
	public UIDragScrollView DragScrollView;

	[Token(Token = "0x4017A1D")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LevelHint;

	[Token(Token = "0x4017A1E")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite DiamondIcon;

	[Token(Token = "0x4017A1F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel RewardLabel;

	[Token(Token = "0x4017A20")]
	[FieldOffset(Offset = "0x24")]
	public UINetworkTextureExt Icon;

	[Token(Token = "0x4017A21")]
	[FieldOffset(Offset = "0x28")]
	public UIButton Purchase;

	[Token(Token = "0x4017A22")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject WaitClaim;

	[Token(Token = "0x4017A23")]
	[FieldOffset(Offset = "0x30")]
	public UILabel PurchaseLabel;

	[Token(Token = "0x4017A24")]
	[FieldOffset(Offset = "0x34")]
	public GameObject WaitClaimBG;

	[Token(Token = "0x4017A25")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Lock;

	[Token(Token = "0x4017A26")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Claimed;

	[Token(Token = "0x4017A27")]
	[FieldOffset(Offset = "0x40")]
	public GameObject LowLevel;

	[Token(Token = "0x6016E67")]
	[Address(RVA = "0x29D1900", Offset = "0x29D1900", VA = "0x29D1900")]
	public UIPaymentGrowthFundItemView()
	{
	}

	[Token(Token = "0x6016E68")]
	[Address(RVA = "0x29D1908", Offset = "0x29D1908", VA = "0x29D1908", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E69")]
	[Address(RVA = "0x29D1E94", Offset = "0x29D1E94", VA = "0x29D1E94")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
