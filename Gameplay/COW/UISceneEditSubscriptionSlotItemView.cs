using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200399B")]
public class UISceneEditSubscriptionSlotItemView : UIBaseView
{
	[Token(Token = "0x4018265")]
	[FieldOffset(Offset = "0x14")]
	public GameObject LockState;

	[Token(Token = "0x4018266")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SpecialStateMask;

	[Token(Token = "0x4018267")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LockTxt;

	[Token(Token = "0x4018268")]
	[FieldOffset(Offset = "0x20")]
	public GameObject NormalState;

	[Token(Token = "0x4018269")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SlotIcon;

	[Token(Token = "0x401826A")]
	[FieldOffset(Offset = "0x28")]
	public UILabel NameTxt;

	[Token(Token = "0x401826B")]
	[FieldOffset(Offset = "0x2C")]
	public UINetworkTexture CdnSlotIcon;

	[Token(Token = "0x401826C")]
	[FieldOffset(Offset = "0x30")]
	public GameObject GameMap;

	[Token(Token = "0x401826D")]
	[FieldOffset(Offset = "0x34")]
	public UITexture GameMapBg;

	[Token(Token = "0x401826E")]
	[FieldOffset(Offset = "0x38")]
	public UITexture GameBitMap;

	[Token(Token = "0x401826F")]
	[FieldOffset(Offset = "0x3C")]
	public UITexture GameBitOutLineMap;

	[Token(Token = "0x4018270")]
	[FieldOffset(Offset = "0x40")]
	public UISprite IconItemSpite;

	[Token(Token = "0x4018271")]
	[FieldOffset(Offset = "0x44")]
	public UIButton Btn;

	[Token(Token = "0x4018272")]
	[FieldOffset(Offset = "0x48")]
	public UISprite ModeTag;

	[Token(Token = "0x4018273")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel LabelTag;

	[Token(Token = "0x4018274")]
	[FieldOffset(Offset = "0x50")]
	public UILabel UpdateTime;

	[Token(Token = "0x4018275")]
	[FieldOffset(Offset = "0x54")]
	public UISprite WarningIcon;

	[Token(Token = "0x6017078")]
	[Address(RVA = "0x2DB3A44", Offset = "0x2DB3A44", VA = "0x2DB3A44")]
	public UISceneEditSubscriptionSlotItemView()
	{
	}

	[Token(Token = "0x6017079")]
	[Address(RVA = "0x2DB3A4C", Offset = "0x2DB3A4C", VA = "0x2DB3A4C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601707A")]
	[Address(RVA = "0x2DB41B8", Offset = "0x2DB41B8", VA = "0x2DB41B8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
