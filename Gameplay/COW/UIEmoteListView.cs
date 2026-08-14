using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003514")]
public class UIEmoteListView : UIBaseView
{
	[Token(Token = "0x4014F11")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView list;

	[Token(Token = "0x4014F12")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid Grid;

	[Token(Token = "0x4014F13")]
	[FieldOffset(Offset = "0x1C")]
	public Transform Slot1;

	[Token(Token = "0x4014F14")]
	[FieldOffset(Offset = "0x20")]
	public Transform Slot2;

	[Token(Token = "0x4014F15")]
	[FieldOffset(Offset = "0x24")]
	public Transform Slot3;

	[Token(Token = "0x4014F16")]
	[FieldOffset(Offset = "0x28")]
	public Transform Slot4;

	[Token(Token = "0x4014F17")]
	[FieldOffset(Offset = "0x2C")]
	public Transform Slot5;

	[Token(Token = "0x4014F18")]
	[FieldOffset(Offset = "0x30")]
	public Transform Slot6;

	[Token(Token = "0x4014F19")]
	[FieldOffset(Offset = "0x34")]
	public Transform Slot7;

	[Token(Token = "0x4014F1A")]
	[FieldOffset(Offset = "0x38")]
	public Transform Slot8;

	[Token(Token = "0x4014F1B")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget dragScrollView;

	[Token(Token = "0x4014F1C")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget GuideWidgt;

	[Token(Token = "0x60162EC")]
	[Address(RVA = "0x19D2858", Offset = "0x19D2858", VA = "0x19D2858")]
	public UIEmoteListView()
	{
	}

	[Token(Token = "0x60162ED")]
	[Address(RVA = "0x19D2860", Offset = "0x19D2860", VA = "0x19D2860", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162EE")]
	[Address(RVA = "0x19D2CE8", Offset = "0x19D2CE8", VA = "0x19D2CE8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
