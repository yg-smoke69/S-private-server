using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003890")]
public class UIMaskView : UIBaseView
{
	[Token(Token = "0x40175D3")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Mask;

	[Token(Token = "0x6016D5B")]
	[Address(RVA = "0x2815044", Offset = "0x2815044", VA = "0x2815044")]
	public UIMaskView()
	{
	}

	[Token(Token = "0x6016D5C")]
	[Address(RVA = "0x281504C", Offset = "0x281504C", VA = "0x281504C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D5D")]
	[Address(RVA = "0x28151F4", Offset = "0x28151F4", VA = "0x28151F4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
