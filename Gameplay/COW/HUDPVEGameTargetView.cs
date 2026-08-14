using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003381")]
public class HUDPVEGameTargetView : UIBaseView
{
	[Token(Token = "0x40139E7")]
	[FieldOffset(Offset = "0x14")]
	public GameObject RoundContentContainer;

	[Token(Token = "0x40139E8")]
	[FieldOffset(Offset = "0x18")]
	public UILabel RoundLabel;

	[Token(Token = "0x40139E9")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel RoundLabel_01;

	[Token(Token = "0x40139EA")]
	[FieldOffset(Offset = "0x20")]
	public UILabel RoundLabel_02;

	[Token(Token = "0x40139EB")]
	[FieldOffset(Offset = "0x24")]
	public GameObject GameWinContainer;

	[Token(Token = "0x40139EC")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TimeOutContainer;

	[Token(Token = "0x6015E3A")]
	[Address(RVA = "0x1909894", Offset = "0x1909894", VA = "0x1909894")]
	public HUDPVEGameTargetView()
	{
	}

	[Token(Token = "0x6015E3B")]
	[Address(RVA = "0x190989C", Offset = "0x190989C", VA = "0x190989C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E3C")]
	[Address(RVA = "0x1909C00", Offset = "0x1909C00", VA = "0x1909C00")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
