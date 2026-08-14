using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003590")]
public class UIGachaLimitRuleShowWndView : UIBaseView
{
	[Token(Token = "0x401550D")]
	[FieldOffset(Offset = "0x14")]
	public UITable txtTable;

	[Token(Token = "0x401550E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TipsLabel_1;

	[Token(Token = "0x401550F")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TipsLabel_4;

	[Token(Token = "0x6016460")]
	[Address(RVA = "0x2A17584", Offset = "0x2A17584", VA = "0x2A17584")]
	public UIGachaLimitRuleShowWndView()
	{
	}

	[Token(Token = "0x6016461")]
	[Address(RVA = "0x2A1758C", Offset = "0x2A1758C", VA = "0x2A1758C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016462")]
	[Address(RVA = "0x2A177F4", Offset = "0x2A177F4", VA = "0x2A177F4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
