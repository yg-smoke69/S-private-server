using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003999")]
public class UISceneEditSlotItemView : UIBaseView
{
	[Token(Token = "0x401824A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject LockState;

	[Token(Token = "0x401824B")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LockTxt;

	[Token(Token = "0x401824C")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject UnLockState;

	[Token(Token = "0x401824D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SpecialStateMask;

	[Token(Token = "0x401824E")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SlotIcon;

	[Token(Token = "0x401824F")]
	[FieldOffset(Offset = "0x28")]
	public UINetworkTexture CDNMap;

	[Token(Token = "0x4018250")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject EmptySlotIcon;

	[Token(Token = "0x4018251")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LostIcon;

	[Token(Token = "0x4018252")]
	[FieldOffset(Offset = "0x34")]
	public GameObject WarningIcon;

	[Token(Token = "0x4018253")]
	[FieldOffset(Offset = "0x38")]
	public UILabel NameTxt;

	[Token(Token = "0x4018254")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Upload;

	[Token(Token = "0x4018255")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Download;

	[Token(Token = "0x4018256")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Share;

	[Token(Token = "0x4018257")]
	[FieldOffset(Offset = "0x48")]
	public UILabel IndexTxt;

	[Token(Token = "0x4018258")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject SelectedBg;

	[Token(Token = "0x4018259")]
	[FieldOffset(Offset = "0x50")]
	public UIButton Btn;

	[Token(Token = "0x6017072")]
	[Address(RVA = "0x2DADED4", Offset = "0x2DADED4", VA = "0x2DADED4")]
	public UISceneEditSlotItemView()
	{
	}

	[Token(Token = "0x6017073")]
	[Address(RVA = "0x2DADEDC", Offset = "0x2DADEDC", VA = "0x2DADEDC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017074")]
	[Address(RVA = "0x2DAE5A0", Offset = "0x2DAE5A0", VA = "0x2DAE5A0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
