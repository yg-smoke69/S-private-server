using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003971")]
public class UIRoomQuadPlayerItemView : UIBaseView
{
	[Token(Token = "0x40180E8")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIRoomQuadPlayerItem;

	[Token(Token = "0x40180E9")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Selected;

	[Token(Token = "0x40180EA")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Id;

	[Token(Token = "0x40180EB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PlayerGo1;

	[Token(Token = "0x40180EC")]
	[FieldOffset(Offset = "0x24")]
	public GameObject PlayerGo2;

	[Token(Token = "0x40180ED")]
	[FieldOffset(Offset = "0x28")]
	public GameObject PlayerGo3;

	[Token(Token = "0x40180EE")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject PlayerGo4;

	[Token(Token = "0x6016FFA")]
	[Address(RVA = "0x2BE8F14", Offset = "0x2BE8F14", VA = "0x2BE8F14")]
	public UIRoomQuadPlayerItemView()
	{
	}

	[Token(Token = "0x6016FFB")]
	[Address(RVA = "0x2BE8F1C", Offset = "0x2BE8F1C", VA = "0x2BE8F1C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FFC")]
	[Address(RVA = "0x2BE92C8", Offset = "0x2BE92C8", VA = "0x2BE92C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
