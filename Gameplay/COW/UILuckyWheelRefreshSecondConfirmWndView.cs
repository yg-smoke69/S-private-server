using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003861")]
public class UILuckyWheelRefreshSecondConfirmWndView : UIBaseView
{
	[Token(Token = "0x401721F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CancelBtn;

	[Token(Token = "0x4017220")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4017221")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel DescriptionLabel;

	[Token(Token = "0x4017222")]
	[FieldOffset(Offset = "0x20")]
	public UIToggle Toggle;

	[Token(Token = "0x6016CCE")]
	[Address(RVA = "0x18CE3C0", Offset = "0x18CE3C0", VA = "0x18CE3C0")]
	public UILuckyWheelRefreshSecondConfirmWndView()
	{
	}

	[Token(Token = "0x6016CCF")]
	[Address(RVA = "0x18CE3C8", Offset = "0x18CE3C8", VA = "0x18CE3C8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CD0")]
	[Address(RVA = "0x18CE690", Offset = "0x18CE690", VA = "0x18CE690")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
