using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200395D")]
public class UIRoomCardListView : UIBaseView
{
	[Token(Token = "0x4018030")]
	[FieldOffset(Offset = "0x14")]
	public UITable RoomCardTable;

	[Token(Token = "0x4018031")]
	[FieldOffset(Offset = "0x18")]
	public UIRoomCardView RoomTimeCardTemplate;

	[Token(Token = "0x4018032")]
	[FieldOffset(Offset = "0x1C")]
	public UIRoomCardView RoomCardTemplate;

	[Token(Token = "0x6016FBE")]
	[Address(RVA = "0x23B9504", Offset = "0x23B9504", VA = "0x23B9504")]
	public UIRoomCardListView()
	{
	}

	[Token(Token = "0x6016FBF")]
	[Address(RVA = "0x23B950C", Offset = "0x23B950C", VA = "0x23B950C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FC0")]
	[Address(RVA = "0x23B9774", Offset = "0x23B9774", VA = "0x23B9774")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
