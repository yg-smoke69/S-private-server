using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003973")]
public class UIRoomReopenPopView : UIBaseView
{
	[Token(Token = "0x40180FA")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ReopenGo;

	[Token(Token = "0x40180FB")]
	[FieldOffset(Offset = "0x18")]
	public UIInput RoomIdInput;

	[Token(Token = "0x40180FC")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel InfoTxt;

	[Token(Token = "0x40180FD")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x40180FE")]
	[FieldOffset(Offset = "0x24")]
	public UISprite BtnSprite;

	[Token(Token = "0x6017000")]
	[Address(RVA = "0x2BEB4B0", Offset = "0x2BEB4B0", VA = "0x2BEB4B0")]
	public UIRoomReopenPopView()
	{
	}

	[Token(Token = "0x6017001")]
	[Address(RVA = "0x2BEB4B8", Offset = "0x2BEB4B8", VA = "0x2BEB4B8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017002")]
	[Address(RVA = "0x2BEB7D4", Offset = "0x2BEB7D4", VA = "0x2BEB7D4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
