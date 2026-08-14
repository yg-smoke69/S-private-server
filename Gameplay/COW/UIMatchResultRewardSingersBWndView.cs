using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003898")]
public class UIMatchResultRewardSingersBWndView : UIBaseView
{
	[Token(Token = "0x4017622")]
	[FieldOffset(Offset = "0x14")]
	public UIButton SkipMask;

	[Token(Token = "0x4017623")]
	[FieldOffset(Offset = "0x18")]
	public UIButton TipsProgress;

	[Token(Token = "0x4017624")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton TipsHasObtain;

	[Token(Token = "0x4017625")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BuffBtn;

	[Token(Token = "0x4017626")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid RewardGrid;

	[Token(Token = "0x4017627")]
	[FieldOffset(Offset = "0x28")]
	public UIScrollView RewardContainer;

	[Token(Token = "0x4017628")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton SkipAniMask;

	[Token(Token = "0x6016D73")]
	[Address(RVA = "0x267FB1C", Offset = "0x267FB1C", VA = "0x267FB1C")]
	public UIMatchResultRewardSingersBWndView()
	{
	}

	[Token(Token = "0x6016D74")]
	[Address(RVA = "0x267FB24", Offset = "0x267FB24", VA = "0x267FB24", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D75")]
	[Address(RVA = "0x267FF0C", Offset = "0x267FF0C", VA = "0x267FF0C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
