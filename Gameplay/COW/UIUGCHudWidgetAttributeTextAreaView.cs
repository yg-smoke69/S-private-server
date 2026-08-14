using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A36")]
public class UIUGCHudWidgetAttributeTextAreaView : UIBaseView
{
	[Token(Token = "0x401894D")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Title;

	[Token(Token = "0x401894E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel CharLimit;

	[Token(Token = "0x401894F")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput Input;

	[Token(Token = "0x6017248")]
	[Address(RVA = "0x2FFAAE8", Offset = "0x2FFAAE8", VA = "0x2FFAAE8")]
	public UIUGCHudWidgetAttributeTextAreaView()
	{
	}

	[Token(Token = "0x6017249")]
	[Address(RVA = "0x2FFAAF0", Offset = "0x2FFAAF0", VA = "0x2FFAAF0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601724A")]
	[Address(RVA = "0x2FFAD58", Offset = "0x2FFAD58", VA = "0x2FFAD58")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
