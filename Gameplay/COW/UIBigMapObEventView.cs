using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003401")]
public class UIBigMapObEventView : UIBaseView
{
	[Token(Token = "0x4014060")]
	[FieldOffset(Offset = "0x14")]
	public GameObject eventContainer;

	[Token(Token = "0x4014061")]
	[FieldOffset(Offset = "0x18")]
	public UIBigMapObEventDragDropItem DragDropItem;

	[Token(Token = "0x4014062")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite eventIcon;

	[Token(Token = "0x4014063")]
	[FieldOffset(Offset = "0x20")]
	public GameObject onRelease;

	[Token(Token = "0x4014064")]
	[FieldOffset(Offset = "0x24")]
	public UIButton yes;

	[Token(Token = "0x4014065")]
	[FieldOffset(Offset = "0x28")]
	public UISprite yesSprite;

	[Token(Token = "0x4014066")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton no;

	[Token(Token = "0x4014067")]
	[FieldOffset(Offset = "0x30")]
	public GameObject targetPos;

	[Token(Token = "0x6015FB7")]
	[Address(RVA = "0x10D2878", Offset = "0x10D2878", VA = "0x10D2878")]
	public UIBigMapObEventView()
	{
	}

	[Token(Token = "0x6015FB8")]
	[Address(RVA = "0x10D2880", Offset = "0x10D2880", VA = "0x10D2880", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FB9")]
	[Address(RVA = "0x10D2CA4", Offset = "0x10D2CA4", VA = "0x10D2CA4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
