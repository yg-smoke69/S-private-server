using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A2F")]
public class UIUGCHudWidgetAttributeColorView : UIBaseView
{
	[Token(Token = "0x401892B")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x401892C")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x401892D")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Hex;

	[Token(Token = "0x401892E")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Color;

	[Token(Token = "0x401892F")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Button;

	[Token(Token = "0x6017233")]
	[Address(RVA = "0x2FF4E48", Offset = "0x2FF4E48", VA = "0x2FF4E48")]
	public UIUGCHudWidgetAttributeColorView()
	{
	}

	[Token(Token = "0x6017234")]
	[Address(RVA = "0x2FF4E50", Offset = "0x2FF4E50", VA = "0x2FF4E50", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017235")]
	[Address(RVA = "0x2FF5178", Offset = "0x2FF5178", VA = "0x2FF5178")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
