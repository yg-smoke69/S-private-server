using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200388C")]
public class UIMapMarkView : UIBaseView
{
	[Token(Token = "0x40175B5")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Mark;

	[Token(Token = "0x6016D4F")]
	[Address(RVA = "0x2801D2C", Offset = "0x2801D2C", VA = "0x2801D2C")]
	public UIMapMarkView()
	{
	}

	[Token(Token = "0x6016D50")]
	[Address(RVA = "0x2801D34", Offset = "0x2801D34", VA = "0x2801D34", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D51")]
	[Address(RVA = "0x2801EDC", Offset = "0x2801EDC", VA = "0x2801EDC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
