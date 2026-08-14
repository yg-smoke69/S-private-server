using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035F5")]
public class UIHUDBountyBOSSInfoView : UIBaseView
{
	[Token(Token = "0x40159B0")]
	[FieldOffset(Offset = "0x14")]
	public GameObject TipRoot;

	[Token(Token = "0x40159B1")]
	[FieldOffset(Offset = "0x18")]
	public GameObject WarningIcon;

	[Token(Token = "0x40159B2")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel WarningTxt;

	[Token(Token = "0x40159B3")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GameWinRoot;

	[Token(Token = "0x40159B4")]
	[FieldOffset(Offset = "0x24")]
	public GameObject BossWeakPointRoot;

	[Token(Token = "0x601658D")]
	[Address(RVA = "0x1674498", Offset = "0x1674498", VA = "0x1674498")]
	public UIHUDBountyBOSSInfoView()
	{
	}

	[Token(Token = "0x601658E")]
	[Address(RVA = "0x16744A0", Offset = "0x16744A0", VA = "0x16744A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601658F")]
	[Address(RVA = "0x16746E4", Offset = "0x16746E4", VA = "0x16746E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
