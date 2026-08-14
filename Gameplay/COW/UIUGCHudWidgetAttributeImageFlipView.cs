using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A31")]
public class UIUGCHudWidgetAttributeImageFlipView : UIBaseView
{
	[Token(Token = "0x401893C")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Title;

	[Token(Token = "0x401893D")]
	[FieldOffset(Offset = "0x18")]
	public UIToggle Horizontal;

	[Token(Token = "0x401893E")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggle Vertical;

	[Token(Token = "0x6017239")]
	[Address(RVA = "0x2FF6BE0", Offset = "0x2FF6BE0", VA = "0x2FF6BE0")]
	public UIUGCHudWidgetAttributeImageFlipView()
	{
	}

	[Token(Token = "0x601723A")]
	[Address(RVA = "0x2FF6BE8", Offset = "0x2FF6BE8", VA = "0x2FF6BE8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601723B")]
	[Address(RVA = "0x2FF6E50", Offset = "0x2FF6E50", VA = "0x2FF6E50")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
