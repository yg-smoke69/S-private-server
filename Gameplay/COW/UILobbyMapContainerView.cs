using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003846")]
public class UILobbyMapContainerView : UIBaseView
{
	[Token(Token = "0x4016FB9")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid MapModesContainer;

	[Token(Token = "0x4016FBA")]
	[FieldOffset(Offset = "0x18")]
	public UIToggleButtonGroup MapModesGroup;

	[Token(Token = "0x4016FBB")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite ContainerBGCollider;

	[Token(Token = "0x4016FBC")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ContainerBG;

	[Token(Token = "0x4016FBD")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnCustomRoomTest;

	[Token(Token = "0x4016FBE")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget CustomRoomWidget;

	[Token(Token = "0x6016C7D")]
	[Address(RVA = "0xDBF418", Offset = "0xDBF418", VA = "0xDBF418")]
	public UILobbyMapContainerView()
	{
	}

	[Token(Token = "0x6016C7E")]
	[Address(RVA = "0xDBF420", Offset = "0xDBF420", VA = "0xDBF420", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C7F")]
	[Address(RVA = "0xDBF7A8", Offset = "0xDBF7A8", VA = "0xDBF7A8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
