using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003995")]
public class UISceneEditMapSelectView : UIBaseView
{
	[Token(Token = "0x4018219")]
	[FieldOffset(Offset = "0x14")]
	public GameObject PopMenuGo;

	[Token(Token = "0x401821A")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ScrollView;

	[Token(Token = "0x401821B")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList GridEasyList;

	[Token(Token = "0x401821C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject InfoGo;

	[Token(Token = "0x401821D")]
	[FieldOffset(Offset = "0x24")]
	public UISceneEditSlotInfoView SlotInfoView;

	[Token(Token = "0x401821E")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid InfoGrid;

	[Token(Token = "0x401821F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject LikeAndSubscribePanel;

	[Token(Token = "0x4018220")]
	[FieldOffset(Offset = "0x30")]
	public GameObject EmptyGo;

	[Token(Token = "0x4018221")]
	[FieldOffset(Offset = "0x34")]
	public UILabel EmptyTips;

	[Token(Token = "0x4018222")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnSelect;

	[Token(Token = "0x6017066")]
	[Address(RVA = "0x2DA4C90", Offset = "0x2DA4C90", VA = "0x2DA4C90")]
	public UISceneEditMapSelectView()
	{
	}

	[Token(Token = "0x6017067")]
	[Address(RVA = "0x2DA4C98", Offset = "0x2DA4C98", VA = "0x2DA4C98", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017068")]
	[Address(RVA = "0x2DA5170", Offset = "0x2DA5170", VA = "0x2DA5170")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
