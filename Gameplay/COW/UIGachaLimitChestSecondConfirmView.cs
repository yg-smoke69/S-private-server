using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003589")]
public class UIGachaLimitChestSecondConfirmView : UIBaseView
{
	[Token(Token = "0x401549C")]
	[FieldOffset(Offset = "0x14")]
	public GameObject RewardNode1;

	[Token(Token = "0x401549D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject RewardNode2;

	[Token(Token = "0x401549E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Tips;

	[Token(Token = "0x401549F")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x40154A0")]
	[FieldOffset(Offset = "0x24")]
	public UIButton CancelBtn;

	[Token(Token = "0x601644B")]
	[Address(RVA = "0x2E85CEC", Offset = "0x2E85CEC", VA = "0x2E85CEC")]
	public UIGachaLimitChestSecondConfirmView()
	{
	}

	[Token(Token = "0x601644C")]
	[Address(RVA = "0x2E85CF4", Offset = "0x2E85CF4", VA = "0x2E85CF4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601644D")]
	[Address(RVA = "0x2E86004", Offset = "0x2E86004", VA = "0x2E86004")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
