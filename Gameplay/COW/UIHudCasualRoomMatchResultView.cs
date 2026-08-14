using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003605")]
public class UIHudCasualRoomMatchResultView : UIBaseView
{
	[Token(Token = "0x40159ED")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BackBtn;

	[Token(Token = "0x40159EE")]
	[FieldOffset(Offset = "0x18")]
	public UIButton PrevBtn;

	[Token(Token = "0x40159EF")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid LeftGrid;

	[Token(Token = "0x40159F0")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView RightScrollView;

	[Token(Token = "0x40159F1")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid RightGrid;

	[Token(Token = "0x60165BD")]
	[Address(RVA = "0x21475DC", Offset = "0x21475DC", VA = "0x21475DC")]
	public UIHudCasualRoomMatchResultView()
	{
	}

	[Token(Token = "0x60165BE")]
	[Address(RVA = "0x21475E4", Offset = "0x21475E4", VA = "0x21475E4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165BF")]
	[Address(RVA = "0x214790C", Offset = "0x214790C", VA = "0x214790C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
