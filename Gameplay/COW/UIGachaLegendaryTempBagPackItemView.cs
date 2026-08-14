using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200357D")]
public class UIGachaLegendaryTempBagPackItemView : UIBaseView
{
	[Token(Token = "0x40153F2")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ClickBtn;

	[Token(Token = "0x40153F3")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ItemMini;

	[Token(Token = "0x40153F4")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggle RewardToggle;

	[Token(Token = "0x6016427")]
	[Address(RVA = "0x2E6AAA4", Offset = "0x2E6AAA4", VA = "0x2E6AAA4")]
	public UIGachaLegendaryTempBagPackItemView()
	{
	}

	[Token(Token = "0x6016428")]
	[Address(RVA = "0x2E6AAAC", Offset = "0x2E6AAAC", VA = "0x2E6AAAC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016429")]
	[Address(RVA = "0x2E6AD08", Offset = "0x2E6AD08", VA = "0x2E6AD08")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
