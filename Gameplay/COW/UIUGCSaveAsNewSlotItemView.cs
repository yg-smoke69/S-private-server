using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A46")]
public class UIUGCSaveAsNewSlotItemView : UIBaseView
{
	[Token(Token = "0x4018A09")]
	[FieldOffset(Offset = "0x14")]
	public GameObject LockState;

	[Token(Token = "0x4018A0A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LockTxt;

	[Token(Token = "0x4018A0B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject UnLockState;

	[Token(Token = "0x4018A0C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SpecialStateMask;

	[Token(Token = "0x4018A0D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SlotIcon;

	[Token(Token = "0x4018A0E")]
	[FieldOffset(Offset = "0x28")]
	public UINetworkTexture CDNIcon;

	[Token(Token = "0x4018A0F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject EmptySlotIcon;

	[Token(Token = "0x4018A10")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LostIcon;

	[Token(Token = "0x4018A11")]
	[FieldOffset(Offset = "0x34")]
	public GameObject WarningIcon;

	[Token(Token = "0x4018A12")]
	[FieldOffset(Offset = "0x38")]
	public UILabel NameTxt;

	[Token(Token = "0x4018A13")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Upload;

	[Token(Token = "0x4018A14")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Download;

	[Token(Token = "0x4018A15")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Share;

	[Token(Token = "0x4018A16")]
	[FieldOffset(Offset = "0x48")]
	public UILabel IndexTxt;

	[Token(Token = "0x4018A17")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject SelectedBg;

	[Token(Token = "0x4018A18")]
	[FieldOffset(Offset = "0x50")]
	public UIButton Btn;

	[Token(Token = "0x4018A19")]
	[FieldOffset(Offset = "0x54")]
	public GameObject Publiished;

	[Token(Token = "0x4018A1A")]
	[FieldOffset(Offset = "0x58")]
	public UITexture GameMapBg;

	[Token(Token = "0x4018A1B")]
	[FieldOffset(Offset = "0x5C")]
	public UITexture GameBitMap;

	[Token(Token = "0x4018A1C")]
	[FieldOffset(Offset = "0x60")]
	public UITexture GameBitOutLineMap;

	[Token(Token = "0x4018A1D")]
	[FieldOffset(Offset = "0x64")]
	public UISprite IconItemSpite;

	[Token(Token = "0x4018A1E")]
	[FieldOffset(Offset = "0x68")]
	public UISprite GemIcon;

	[Token(Token = "0x4018A1F")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel GemTxt;

	[Token(Token = "0x4018A20")]
	[FieldOffset(Offset = "0x70")]
	public GameObject GameMap;

	[Token(Token = "0x6017278")]
	[Address(RVA = "0xF3DAC8", Offset = "0xF3DAC8", VA = "0xF3DAC8")]
	public UIUGCSaveAsNewSlotItemView()
	{
	}

	[Token(Token = "0x6017279")]
	[Address(RVA = "0xF3DAD0", Offset = "0xF3DAD0", VA = "0xF3DAD0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601727A")]
	[Address(RVA = "0xF3E47C", Offset = "0xF3E47C", VA = "0xF3E47C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
