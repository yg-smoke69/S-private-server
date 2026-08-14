using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003974")]
public class UIRoomSinglePlayerItemView : UIBaseView
{
	[Token(Token = "0x40180FF")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIRoomSinglePlayerItem;

	[Token(Token = "0x4018100")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Selected;

	[Token(Token = "0x4018101")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Id;

	[Token(Token = "0x4018102")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PlayerGo;

	[Token(Token = "0x6017003")]
	[Address(RVA = "0x2BEC408", Offset = "0x2BEC408", VA = "0x2BEC408")]
	public UIRoomSinglePlayerItemView()
	{
	}

	[Token(Token = "0x6017004")]
	[Address(RVA = "0x2BEC410", Offset = "0x2BEC410", VA = "0x2BEC410", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017005")]
	[Address(RVA = "0x2BEC6C0", Offset = "0x2BEC6C0", VA = "0x2BEC6C0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
