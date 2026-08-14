using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003464")]
public class UIClanWarNewsRewardItemView : UIBaseView
{
	[Token(Token = "0x40145A0")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Item;

	[Token(Token = "0x40145A1")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Icon;

	[Token(Token = "0x60160E0")]
	[Address(RVA = "0x2903AF4", Offset = "0x2903AF4", VA = "0x2903AF4")]
	public UIClanWarNewsRewardItemView()
	{
	}

	[Token(Token = "0x60160E1")]
	[Address(RVA = "0x2903AFC", Offset = "0x2903AFC", VA = "0x2903AFC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160E2")]
	[Address(RVA = "0x2903D04", Offset = "0x2903D04", VA = "0x2903D04")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
