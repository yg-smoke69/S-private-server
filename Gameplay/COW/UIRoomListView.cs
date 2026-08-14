using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003966")]
public class UIRoomListView : UIBaseView
{
	[Token(Token = "0x4018074")]
	[FieldOffset(Offset = "0x14")]
	public Transform RoomTypeTab;

	[Token(Token = "0x4018075")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Content;

	[Token(Token = "0x4018076")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget Listbg;

	[Token(Token = "0x4018077")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView ListScrollView;

	[Token(Token = "0x4018078")]
	[FieldOffset(Offset = "0x24")]
	public UIEasyList ListGrid;

	[Token(Token = "0x4018079")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Result;

	[Token(Token = "0x401807A")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Arrow;

	[Token(Token = "0x401807B")]
	[FieldOffset(Offset = "0x30")]
	public UIButton RoomCreate;

	[Token(Token = "0x401807C")]
	[FieldOffset(Offset = "0x34")]
	public GameObject newModeGuide;

	[Token(Token = "0x401807D")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LabelDailyTask;

	[Token(Token = "0x401807E")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject SearchBarContainer;

	[Token(Token = "0x401807F")]
	[FieldOffset(Offset = "0x40")]
	public UIButton RefreshBtn;

	[Token(Token = "0x4018080")]
	[FieldOffset(Offset = "0x44")]
	public GameObject SpriteRefresh;

	[Token(Token = "0x4018081")]
	[FieldOffset(Offset = "0x48")]
	public UILabel RefreshTxt;

	[Token(Token = "0x4018082")]
	[FieldOffset(Offset = "0x4C")]
	public UICountDownLabel CountDownTxt;

	[Token(Token = "0x4018083")]
	[FieldOffset(Offset = "0x50")]
	public UIInput SearchInput;

	[Token(Token = "0x4018084")]
	[FieldOffset(Offset = "0x54")]
	public UIButton SearchBtn;

	[Token(Token = "0x4018085")]
	[FieldOffset(Offset = "0x58")]
	public UISprite SearchBtnSprite;

	[Token(Token = "0x4018086")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton ClearBtn;

	[Token(Token = "0x4018087")]
	[FieldOffset(Offset = "0x60")]
	public GameObject FreeRoomCreate;

	[Token(Token = "0x4018088")]
	[FieldOffset(Offset = "0x64")]
	public GameObject NormalRoomCreate;

	[Token(Token = "0x4018089")]
	[FieldOffset(Offset = "0x68")]
	public Transform ModeDropList;

	[Token(Token = "0x401808A")]
	[FieldOffset(Offset = "0x6C")]
	public Transform GroupDropList;

	[Token(Token = "0x401808B")]
	[FieldOffset(Offset = "0x70")]
	public UIButton QuickJoinBtn;

	[Token(Token = "0x6016FD9")]
	[Address(RVA = "0x23D2394", Offset = "0x23D2394", VA = "0x23D2394")]
	public UIRoomListView()
	{
	}

	[Token(Token = "0x6016FDA")]
	[Address(RVA = "0x23D239C", Offset = "0x23D239C", VA = "0x23D239C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FDB")]
	[Address(RVA = "0x23D2D18", Offset = "0x23D2D18", VA = "0x23D2D18")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
