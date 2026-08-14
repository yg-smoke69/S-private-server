using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200396F")]
public class UIRoomPlayersWithTeamItemView : UIBaseView
{
	[Token(Token = "0x40180D5")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIRoomPlayersWithTeamItem;

	[Token(Token = "0x40180D6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Selected;

	[Token(Token = "0x40180D7")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TeamName;

	[Token(Token = "0x40180D8")]
	[FieldOffset(Offset = "0x20")]
	public UIEffectSprite TeamIcon;

	[Token(Token = "0x40180D9")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TeamFakeIcon;

	[Token(Token = "0x40180DA")]
	[FieldOffset(Offset = "0x28")]
	public UISprite LeftLine;

	[Token(Token = "0x40180DB")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite LeftBG;

	[Token(Token = "0x40180DC")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Id;

	[Token(Token = "0x40180DD")]
	[FieldOffset(Offset = "0x34")]
	public UIGrid PlayerContainer;

	[Token(Token = "0x6016FF4")]
	[Address(RVA = "0x2BE621C", Offset = "0x2BE621C", VA = "0x2BE621C")]
	public UIRoomPlayersWithTeamItemView()
	{
	}

	[Token(Token = "0x6016FF5")]
	[Address(RVA = "0x2BE6224", Offset = "0x2BE6224", VA = "0x2BE6224", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FF6")]
	[Address(RVA = "0x2BE66C0", Offset = "0x2BE66C0", VA = "0x2BE66C0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
