using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034B2")]
public class UIDebtWindowView : UIBaseView
{
	[Token(Token = "0x40149D4")]
	[FieldOffset(Offset = "0x14")]
	public UILabel DebtNumLabel;

	[Token(Token = "0x40149D5")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ChargeBtn;

	[Token(Token = "0x60161CA")]
	[Address(RVA = "0x11F54D0", Offset = "0x11F54D0", VA = "0x11F54D0")]
	public UIDebtWindowView()
	{
	}

	[Token(Token = "0x60161CB")]
	[Address(RVA = "0x11F54D8", Offset = "0x11F54D8", VA = "0x11F54D8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161CC")]
	[Address(RVA = "0x11F56E0", Offset = "0x11F56E0", VA = "0x11F56E0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
