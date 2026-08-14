using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039D2")]
internal class UISPHudResultPlayerScoreItemView : UIBaseView
{
	[Token(Token = "0x401853A")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UISPHudResultPlayerScoreItem;

	[Token(Token = "0x401853B")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Name;

	[Token(Token = "0x401853C")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Cnt;

	[Token(Token = "0x601711C")]
	[Address(RVA = "0x1D2BB34", Offset = "0x1D2BB34", VA = "0x1D2BB34")]
	public UISPHudResultPlayerScoreItemView()
	{
	}

	[Token(Token = "0x601711D")]
	[Address(RVA = "0x1D2BB3C", Offset = "0x1D2BB3C", VA = "0x1D2BB3C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601711E")]
	[Address(RVA = "0x1D2BCE0", Offset = "0x1D2BCE0", VA = "0x1D2BCE0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
