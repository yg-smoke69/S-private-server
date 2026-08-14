using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200393D")]
public class UIQuickMessageCustomView : UIBaseView
{
	[Token(Token = "0x4017F38")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView UnselectList;

	[Token(Token = "0x4017F39")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList UnselectEasyList;

	[Token(Token = "0x4017F3A")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView SelectList;

	[Token(Token = "0x4017F3B")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList SelectEasyList;

	[Token(Token = "0x4017F3C")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButton BRToggleBtn;

	[Token(Token = "0x4017F3D")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButton CSToggleBtn;

	[Token(Token = "0x6016F5E")]
	[Address(RVA = "0x1AC2B04", Offset = "0x1AC2B04", VA = "0x1AC2B04")]
	public UIQuickMessageCustomView()
	{
	}

	[Token(Token = "0x6016F5F")]
	[Address(RVA = "0x1AC2B0C", Offset = "0x1AC2B0C", VA = "0x1AC2B0C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F60")]
	[Address(RVA = "0x1AC2E94", Offset = "0x1AC2E94", VA = "0x1AC2E94")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
