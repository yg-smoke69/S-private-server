using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039CD")]
public class UISPHudResultNameCardView : UIBaseView
{
	[Token(Token = "0x4018523")]
	[FieldOffset(Offset = "0x14")]
	public GameObject OldCard;

	[Token(Token = "0x4018524")]
	[FieldOffset(Offset = "0x18")]
	public UILabel NameLabel;

	[Token(Token = "0x4018525")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject NewCard;

	[Token(Token = "0x4018526")]
	[FieldOffset(Offset = "0x20")]
	public UILabel NewNameLabel;

	[Token(Token = "0x4018527")]
	[FieldOffset(Offset = "0x24")]
	public GameObject MVP;

	[Token(Token = "0x601710D")]
	[Address(RVA = "0x1D2AE80", Offset = "0x1D2AE80", VA = "0x1D2AE80")]
	public UISPHudResultNameCardView()
	{
	}

	[Token(Token = "0x601710E")]
	[Address(RVA = "0x1D2AE88", Offset = "0x1D2AE88", VA = "0x1D2AE88", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601710F")]
	[Address(RVA = "0x1D2B0CC", Offset = "0x1D2B0CC", VA = "0x1D2B0CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
