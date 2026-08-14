using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033AB")]
public class UIActivityFriendReunionView : UIBaseView
{
	[Token(Token = "0x4013BB3")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4013BB4")]
	[FieldOffset(Offset = "0x18")]
	public UITable ContentTable;

	[Token(Token = "0x4013BB5")]
	[FieldOffset(Offset = "0x1C")]
	public UIDragScrollView DragArea;

	[Token(Token = "0x6015EB7")]
	[Address(RVA = "0x2FB5B50", Offset = "0x2FB5B50", VA = "0x2FB5B50")]
	public UIActivityFriendReunionView()
	{
	}

	[Token(Token = "0x6015EB8")]
	[Address(RVA = "0x2FB5B58", Offset = "0x2FB5B58", VA = "0x2FB5B58", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EB9")]
	[Address(RVA = "0x2FB5DC0", Offset = "0x2FB5DC0", VA = "0x2FB5DC0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
