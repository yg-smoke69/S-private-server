using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003899")]
public class UIMatchResultRewardWndView : UIBaseView
{
	[Token(Token = "0x4017629")]
	[FieldOffset(Offset = "0x14")]
	public UIButton SkipMask;

	[Token(Token = "0x401762A")]
	[FieldOffset(Offset = "0x18")]
	public UIButton TipsProgress;

	[Token(Token = "0x401762B")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton TipsHasObtain;

	[Token(Token = "0x401762C")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BuffBtn;

	[Token(Token = "0x401762D")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid RewardGrid;

	[Token(Token = "0x401762E")]
	[FieldOffset(Offset = "0x28")]
	public UIScrollView RewardContainer;

	[Token(Token = "0x401762F")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton SkipAniMask;

	[Token(Token = "0x4017630")]
	[FieldOffset(Offset = "0x30")]
	public UILabel RewardDescLabel;

	[Token(Token = "0x4017631")]
	[FieldOffset(Offset = "0x34")]
	public UILabel TaskDescLabel;

	[Token(Token = "0x4017632")]
	[FieldOffset(Offset = "0x38")]
	public UIEasyList TaskEasyList;

	[Token(Token = "0x4017633")]
	[FieldOffset(Offset = "0x3C")]
	public UIGrid ContentGrid;

	[Token(Token = "0x4017634")]
	[FieldOffset(Offset = "0x40")]
	public GameObject MatchRewardContainer;

	[Token(Token = "0x4017635")]
	[FieldOffset(Offset = "0x44")]
	public GameObject TaskContainer;

	[Token(Token = "0x4017636")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Line;

	[Token(Token = "0x4017637")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel ContinueTxt;

	[Token(Token = "0x6016D76")]
	[Address(RVA = "0x268405C", Offset = "0x268405C", VA = "0x268405C")]
	public UIMatchResultRewardWndView()
	{
	}

	[Token(Token = "0x6016D77")]
	[Address(RVA = "0x2684064", Offset = "0x2684064", VA = "0x2684064", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D78")]
	[Address(RVA = "0x2684728", Offset = "0x2684728", VA = "0x2684728")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
