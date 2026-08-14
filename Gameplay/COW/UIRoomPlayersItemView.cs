using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200396E")]
public class UIRoomPlayersItemView : UIBaseView
{
	[Token(Token = "0x40180CF")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIRoomPlayersItem;

	[Token(Token = "0x40180D0")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Selected;

	[Token(Token = "0x40180D1")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite LeftLine;

	[Token(Token = "0x40180D2")]
	[FieldOffset(Offset = "0x20")]
	public UISprite LeftBG;

	[Token(Token = "0x40180D3")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Id;

	[Token(Token = "0x40180D4")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid PlayerContainer;

	[Token(Token = "0x6016FF1")]
	[Address(RVA = "0x2BE4A48", Offset = "0x2BE4A48", VA = "0x2BE4A48")]
	public UIRoomPlayersItemView()
	{
	}

	[Token(Token = "0x6016FF2")]
	[Address(RVA = "0x2BE4A50", Offset = "0x2BE4A50", VA = "0x2BE4A50", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FF3")]
	[Address(RVA = "0x2BE4DCC", Offset = "0x2BE4DCC", VA = "0x2BE4DCC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
