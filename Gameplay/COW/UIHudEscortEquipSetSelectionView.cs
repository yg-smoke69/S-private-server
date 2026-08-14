using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003648")]
public class UIHudEscortEquipSetSelectionView : UIBaseView
{
	[Token(Token = "0x4015C6C")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LastTime;

	[Token(Token = "0x4015C6D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject InGameContainer;

	[Token(Token = "0x4015C6E")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject LeftTimeShow;

	[Token(Token = "0x4015C6F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LeftTime;

	[Token(Token = "0x4015C70")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnConfirm;

	[Token(Token = "0x4015C71")]
	[FieldOffset(Offset = "0x28")]
	public GameObject LobbyContainer;

	[Token(Token = "0x4015C72")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnClose;

	[Token(Token = "0x4015C73")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid Grid;

	[Token(Token = "0x4015C74")]
	[FieldOffset(Offset = "0x34")]
	public GameObject LabelNumShow;

	[Token(Token = "0x6016685")]
	[Address(RVA = "0x1B9398C", Offset = "0x1B9398C", VA = "0x1B9398C")]
	public UIHudEscortEquipSetSelectionView()
	{
	}

	[Token(Token = "0x6016686")]
	[Address(RVA = "0x1B93994", Offset = "0x1B93994", VA = "0x1B93994", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016687")]
	[Address(RVA = "0x1B93E0C", Offset = "0x1B93E0C", VA = "0x1B93E0C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
