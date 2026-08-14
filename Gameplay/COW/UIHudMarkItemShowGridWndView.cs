using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036A8")]
public class UIHudMarkItemShowGridWndView : UIBaseView
{
	[Token(Token = "0x4016016")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid ItemGrid;

	[Token(Token = "0x4016017")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ItemViewClickMask;

	[Token(Token = "0x60167A5")]
	[Address(RVA = "0xFFAA8C", Offset = "0xFFAA8C", VA = "0xFFAA8C")]
	public UIHudMarkItemShowGridWndView()
	{
	}

	[Token(Token = "0x60167A6")]
	[Address(RVA = "0xFFAA94", Offset = "0xFFAA94", VA = "0xFFAA94", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167A7")]
	[Address(RVA = "0xFFAC9C", Offset = "0xFFAC9C", VA = "0xFFAC9C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
