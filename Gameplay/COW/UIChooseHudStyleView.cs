using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200343D")]
public class UIChooseHudStyleView : UIBaseView
{
	[Token(Token = "0x40143C1")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnOld;

	[Token(Token = "0x40143C2")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnNew;

	[Token(Token = "0x601606B")]
	[Address(RVA = "0x208E308", Offset = "0x208E308", VA = "0x208E308")]
	public UIChooseHudStyleView()
	{
	}

	[Token(Token = "0x601606C")]
	[Address(RVA = "0x208E310", Offset = "0x208E310", VA = "0x208E310", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601606D")]
	[Address(RVA = "0x208E518", Offset = "0x208E518", VA = "0x208E518")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
