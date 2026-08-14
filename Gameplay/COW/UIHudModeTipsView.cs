using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036B6")]
public class UIHudModeTipsView : UIBaseView
{
	[Token(Token = "0x40160E6")]
	[FieldOffset(Offset = "0x14")]
	public UIButton TipsBtn;

	[Token(Token = "0x40160E7")]
	[FieldOffset(Offset = "0x18")]
	public UILabel DescLabel;

	[Token(Token = "0x60167CF")]
	[Address(RVA = "0x1F48F94", Offset = "0x1F48F94", VA = "0x1F48F94")]
	public UIHudModeTipsView()
	{
	}

	[Token(Token = "0x60167D0")]
	[Address(RVA = "0x1F48F9C", Offset = "0x1F48F9C", VA = "0x1F48F9C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167D1")]
	[Address(RVA = "0x1F491A4", Offset = "0x1F491A4", VA = "0x1F491A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
