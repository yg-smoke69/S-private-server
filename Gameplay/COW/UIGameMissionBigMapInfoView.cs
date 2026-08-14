using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035A0")]
public class UIGameMissionBigMapInfoView : UIBaseView
{
	[Token(Token = "0x4015642")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIGameMissionBigMapInfo;

	[Token(Token = "0x4015643")]
	[FieldOffset(Offset = "0x18")]
	public UISprite TitleBackground;

	[Token(Token = "0x4015644")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Icon;

	[Token(Token = "0x4015645")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Title;

	[Token(Token = "0x4015646")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Countdown;

	[Token(Token = "0x4015647")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Description;

	[Token(Token = "0x4015648")]
	[FieldOffset(Offset = "0x2C")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x6016490")]
	[Address(RVA = "0x245FD4C", Offset = "0x245FD4C", VA = "0x245FD4C")]
	public UIGameMissionBigMapInfoView()
	{
	}

	[Token(Token = "0x6016491")]
	[Address(RVA = "0x245FD54", Offset = "0x245FD54", VA = "0x245FD54", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016492")]
	[Address(RVA = "0x246013C", Offset = "0x246013C", VA = "0x246013C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
