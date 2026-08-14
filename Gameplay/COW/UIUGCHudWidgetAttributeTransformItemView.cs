using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A38")]
public class UIUGCHudWidgetAttributeTransformItemView : UIBaseView
{
	[Token(Token = "0x4018953")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Title;

	[Token(Token = "0x4018954")]
	[FieldOffset(Offset = "0x18")]
	public UIInputEnhance Input;

	[Token(Token = "0x4018955")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton Minus;

	[Token(Token = "0x4018956")]
	[FieldOffset(Offset = "0x20")]
	public UIButton Add;

	[Token(Token = "0x4018957")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Icon;

	[Token(Token = "0x601724E")]
	[Address(RVA = "0x2FFE0B4", Offset = "0x2FFE0B4", VA = "0x2FFE0B4")]
	public UIUGCHudWidgetAttributeTransformItemView()
	{
	}

	[Token(Token = "0x601724F")]
	[Address(RVA = "0x2FFE0BC", Offset = "0x2FFE0BC", VA = "0x2FFE0BC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017250")]
	[Address(RVA = "0x2FFE3E4", Offset = "0x2FFE3E4", VA = "0x2FFE3E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
