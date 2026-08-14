using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A85")]
public class UIWorkshopCreateRoomSlotItemView : UIBaseView
{
	[Token(Token = "0x4018E11")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UnLockState;

	[Token(Token = "0x4018E12")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SlotIcon;

	[Token(Token = "0x4018E13")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture CDNIcon;

	[Token(Token = "0x4018E14")]
	[FieldOffset(Offset = "0x20")]
	public UILabel NameTxt;

	[Token(Token = "0x4018E15")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SelectedBg;

	[Token(Token = "0x4018E16")]
	[FieldOffset(Offset = "0x28")]
	public UIButton Btn;

	[Token(Token = "0x4018E17")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel IndexTxt;

	[Token(Token = "0x4018E18")]
	[FieldOffset(Offset = "0x30")]
	public UISprite IndexBg;

	[Token(Token = "0x6017335")]
	[Address(RVA = "0x1A2AF90", Offset = "0x1A2AF90", VA = "0x1A2AF90")]
	public UIWorkshopCreateRoomSlotItemView()
	{
	}

	[Token(Token = "0x6017336")]
	[Address(RVA = "0x1A2AF98", Offset = "0x1A2AF98", VA = "0x1A2AF98", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017337")]
	[Address(RVA = "0x1A2B3BC", Offset = "0x1A2B3BC", VA = "0x1A2B3BC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
