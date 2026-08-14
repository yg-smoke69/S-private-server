using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003893")]
public class UIMatchMakingWaitingOptimizedView : UIBaseView
{
	[Token(Token = "0x40175F4")]
	[FieldOffset(Offset = "0x14")]
	public GameObject DefaultViewContent;

	[Token(Token = "0x40175F5")]
	[FieldOffset(Offset = "0x18")]
	public GameObject OtherViewContent;

	[Token(Token = "0x40175F6")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel OtherTime;

	[Token(Token = "0x40175F7")]
	[FieldOffset(Offset = "0x20")]
	public UISprite MatchWatingBG;

	[Token(Token = "0x40175F8")]
	[FieldOffset(Offset = "0x24")]
	public UIButton OtherCancelBtn;

	[Token(Token = "0x40175F9")]
	[FieldOffset(Offset = "0x28")]
	public UISprite OtherCancelBtnIcon;

	[Token(Token = "0x40175FA")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite OtherCancelBtnBG;

	[Token(Token = "0x40175FB")]
	[FieldOffset(Offset = "0x30")]
	public GameObject OtherEstimateContent;

	[Token(Token = "0x40175FC")]
	[FieldOffset(Offset = "0x34")]
	public UILabel EstimateLabel;

	[Token(Token = "0x40175FD")]
	[FieldOffset(Offset = "0x38")]
	public UILabel OtherEstimateTime;

	[Token(Token = "0x40175FE")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject VFX_Loop;

	[Token(Token = "0x6016D64")]
	[Address(RVA = "0x2816D00", Offset = "0x2816D00", VA = "0x2816D00")]
	public UIMatchMakingWaitingOptimizedView()
	{
	}

	[Token(Token = "0x6016D65")]
	[Address(RVA = "0x2816D08", Offset = "0x2816D08", VA = "0x2816D08", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D66")]
	[Address(RVA = "0x2817240", Offset = "0x2817240", VA = "0x2817240")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
