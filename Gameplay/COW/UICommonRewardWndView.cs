using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200347D")]
public class UICommonRewardWndView : UIBaseView
{
	[Token(Token = "0x40146CE")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Mask;

	[Token(Token = "0x40146CF")]
	[FieldOffset(Offset = "0x18")]
	public UIButton SkipMask;

	[Token(Token = "0x40146D0")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RewardContainer;

	[Token(Token = "0x40146D1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ExtraItem;

	[Token(Token = "0x40146D2")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid RewardGrid;

	[Token(Token = "0x40146D3")]
	[FieldOffset(Offset = "0x28")]
	public GameObject RewardGridLeftPos;

	[Token(Token = "0x40146D4")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject RewardGridMiddlePos;

	[Token(Token = "0x40146D5")]
	[FieldOffset(Offset = "0x30")]
	public UIScrollView OptionalRewardScrollView;

	[Token(Token = "0x40146D6")]
	[FieldOffset(Offset = "0x34")]
	public UIGrid OptionalRewardGrid;

	[Token(Token = "0x40146D7")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Share;

	[Token(Token = "0x40146D8")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton GoToSharePreViewBtn;

	[Token(Token = "0x40146D9")]
	[FieldOffset(Offset = "0x40")]
	public Animator ShareIconAnimator;

	[Token(Token = "0x40146DA")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Label;

	[Token(Token = "0x40146DB")]
	[FieldOffset(Offset = "0x48")]
	public UILabel FreeRewardLabel;

	[Token(Token = "0x40146DC")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel TransferHint;

	[Token(Token = "0x40146DD")]
	[FieldOffset(Offset = "0x50")]
	public UILabel TransferHintOneRow;

	[Token(Token = "0x40146DE")]
	[FieldOffset(Offset = "0x54")]
	public UILabel OptionalLabel;

	[Token(Token = "0x40146DF")]
	[FieldOffset(Offset = "0x58")]
	public UILabel OptionalLabelStatic;

	[Token(Token = "0x40146E0")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject BG;

	[Token(Token = "0x601612B")]
	[Address(RVA = "0x1EB09C8", Offset = "0x1EB09C8", VA = "0x1EB09C8")]
	public UICommonRewardWndView()
	{
	}

	[Token(Token = "0x601612C")]
	[Address(RVA = "0x1EB09D0", Offset = "0x1EB09D0", VA = "0x1EB09D0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601612D")]
	[Address(RVA = "0x1EB11D8", Offset = "0x1EB11D8", VA = "0x1EB11D8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
