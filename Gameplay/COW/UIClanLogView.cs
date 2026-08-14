using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200344F")]
public class UIClanLogView : UIBaseView
{
	[Token(Token = "0x40144AA")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView MessageList;

	[Token(Token = "0x40144AB")]
	[FieldOffset(Offset = "0x18")]
	public UITable MessageListTable;

	[Token(Token = "0x40144AC")]
	[FieldOffset(Offset = "0x1C")]
	public UIClanLogItemView ItemInstance;

	[Token(Token = "0x40144AD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject EmptyNode;

	[Token(Token = "0x60160A1")]
	[Address(RVA = "0x2B338E4", Offset = "0x2B338E4", VA = "0x2B338E4")]
	public UIClanLogView()
	{
	}

	[Token(Token = "0x60160A2")]
	[Address(RVA = "0x2B338EC", Offset = "0x2B338EC", VA = "0x2B338EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160A3")]
	[Address(RVA = "0x2B33BA8", Offset = "0x2B33BA8", VA = "0x2B33BA8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
