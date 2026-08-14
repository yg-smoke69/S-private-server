using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A35")]
public class UIUGCHudWidgetAttributeTextAlignmentView : UIBaseView
{
	[Token(Token = "0x4018949")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Title;

	[Token(Token = "0x401894A")]
	[FieldOffset(Offset = "0x18")]
	public UIToggle Left;

	[Token(Token = "0x401894B")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggle Center;

	[Token(Token = "0x401894C")]
	[FieldOffset(Offset = "0x20")]
	public UIToggle Right;

	[Token(Token = "0x6017245")]
	[Address(RVA = "0x2FF9E00", Offset = "0x2FF9E00", VA = "0x2FF9E00")]
	public UIUGCHudWidgetAttributeTextAlignmentView()
	{
	}

	[Token(Token = "0x6017246")]
	[Address(RVA = "0x2FF9E08", Offset = "0x2FF9E08", VA = "0x2FF9E08", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017247")]
	[Address(RVA = "0x2FFA0D0", Offset = "0x2FFA0D0", VA = "0x2FFA0D0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
