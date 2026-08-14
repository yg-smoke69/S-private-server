using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A39")]
public class UIUGCHudWidgetAttributeTransformView : UIBaseView
{
	[Token(Token = "0x4018958")]
	[FieldOffset(Offset = "0x14")]
	public UILabel X;

	[Token(Token = "0x4018959")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Y;

	[Token(Token = "0x401895A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Width;

	[Token(Token = "0x401895B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Height;

	[Token(Token = "0x401895C")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Angle;

	[Token(Token = "0x401895D")]
	[FieldOffset(Offset = "0x28")]
	public UIButton Button;

	[Token(Token = "0x401895E")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid Extend;

	[Token(Token = "0x6017251")]
	[Address(RVA = "0x2FFE3EC", Offset = "0x2FFE3EC", VA = "0x2FFE3EC")]
	public UIUGCHudWidgetAttributeTransformView()
	{
	}

	[Token(Token = "0x6017252")]
	[Address(RVA = "0x2FFE3F4", Offset = "0x2FFE3F4", VA = "0x2FFE3F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017253")]
	[Address(RVA = "0x2FFE7DC", Offset = "0x2FFE7DC", VA = "0x2FFE7DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
