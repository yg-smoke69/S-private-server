using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003998")]
public class UISceneEditRoomListView : UIBaseView
{
	[Token(Token = "0x401823A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Content;

	[Token(Token = "0x401823B")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget Listbg;

	[Token(Token = "0x401823C")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ListScrollView;

	[Token(Token = "0x401823D")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList ListGrid;

	[Token(Token = "0x401823E")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Result;

	[Token(Token = "0x401823F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Arrow;

	[Token(Token = "0x4018240")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton RoomCreate;

	[Token(Token = "0x4018241")]
	[FieldOffset(Offset = "0x30")]
	public GameObject SearchBarContainer;

	[Token(Token = "0x4018242")]
	[FieldOffset(Offset = "0x34")]
	public UIButton RefreshBtn;

	[Token(Token = "0x4018243")]
	[FieldOffset(Offset = "0x38")]
	public GameObject SpriteRefresh;

	[Token(Token = "0x4018244")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel RefreshTxt;

	[Token(Token = "0x4018245")]
	[FieldOffset(Offset = "0x40")]
	public UICountDownLabel CountDownTxt;

	[Token(Token = "0x4018246")]
	[FieldOffset(Offset = "0x44")]
	public UIInput SearchInput;

	[Token(Token = "0x4018247")]
	[FieldOffset(Offset = "0x48")]
	public UIButton SearchBtn;

	[Token(Token = "0x4018248")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite SearchBtnSprite;

	[Token(Token = "0x4018249")]
	[FieldOffset(Offset = "0x50")]
	public UIButton ClearBtn;

	[Token(Token = "0x601706F")]
	[Address(RVA = "0x2DAAF2C", Offset = "0x2DAAF2C", VA = "0x2DAAF2C")]
	public UISceneEditRoomListView()
	{
	}

	[Token(Token = "0x6017070")]
	[Address(RVA = "0x2DAAF34", Offset = "0x2DAAF34", VA = "0x2DAAF34", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017071")]
	[Address(RVA = "0x2DAB64C", Offset = "0x2DAB64C", VA = "0x2DAB64C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
