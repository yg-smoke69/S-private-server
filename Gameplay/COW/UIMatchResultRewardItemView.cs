using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003896")]
public class UIMatchResultRewardItemView : UIBaseView
{
	[Token(Token = "0x4017612")]
	[FieldOffset(Offset = "0x14")]
	public GameObject RewardCon;

	[Token(Token = "0x4017613")]
	[FieldOffset(Offset = "0x18")]
	public GameObject RewardItem;

	[Token(Token = "0x4017614")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject LinkProgress;

	[Token(Token = "0x4017615")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LinkObtainable;

	[Token(Token = "0x4017616")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Obtain;

	[Token(Token = "0x4017617")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ProgressNum;

	[Token(Token = "0x4017618")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ProgressContainer;

	[Token(Token = "0x4017619")]
	[FieldOffset(Offset = "0x30")]
	public UILabel NoReachMax;

	[Token(Token = "0x401761A")]
	[FieldOffset(Offset = "0x34")]
	public UILabel ReachMax;

	[Token(Token = "0x401761B")]
	[FieldOffset(Offset = "0x38")]
	public UILabel GoposBtnLabel;

	[Token(Token = "0x401761C")]
	[FieldOffset(Offset = "0x3C")]
	public Animator VFX_Main;

	[Token(Token = "0x401761D")]
	[FieldOffset(Offset = "0x40")]
	public UILabel TokenLabel;

	[Token(Token = "0x401761E")]
	[FieldOffset(Offset = "0x44")]
	public UIProgressBar ProgressBarFront;

	[Token(Token = "0x6016D6D")]
	[Address(RVA = "0x281DC54", Offset = "0x281DC54", VA = "0x281DC54")]
	public UIMatchResultRewardItemView()
	{
	}

	[Token(Token = "0x6016D6E")]
	[Address(RVA = "0x281DC5C", Offset = "0x281DC5C", VA = "0x281DC5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D6F")]
	[Address(RVA = "0x281E248", Offset = "0x281E248", VA = "0x281E248")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
