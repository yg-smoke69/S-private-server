using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200384E")]
public class UILobbyProfileView : UIBaseView
{
	[Token(Token = "0x4017101")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Root;

	[Token(Token = "0x4017102")]
	[FieldOffset(Offset = "0x18")]
	public Transform profileContainer;

	[Token(Token = "0x4017103")]
	[FieldOffset(Offset = "0x1C")]
	public UIProgressBar HPBar;

	[Token(Token = "0x4017104")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HPBarFG;

	[Token(Token = "0x4017105")]
	[FieldOffset(Offset = "0x24")]
	public UILabel accountId;

	[Token(Token = "0x4017106")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ExpLabel;

	[Token(Token = "0x4017107")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnRename;

	[Token(Token = "0x6016C95")]
	[Address(RVA = "0x1CB4CDC", Offset = "0x1CB4CDC", VA = "0x1CB4CDC")]
	public UILobbyProfileView()
	{
	}

	[Token(Token = "0x6016C96")]
	[Address(RVA = "0x1CB4CE4", Offset = "0x1CB4CE4", VA = "0x1CB4CE4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C97")]
	[Address(RVA = "0x1CB50A4", Offset = "0x1CB50A4", VA = "0x1CB50A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
