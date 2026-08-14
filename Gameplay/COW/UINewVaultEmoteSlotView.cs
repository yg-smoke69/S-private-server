using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038CD")]
public class UINewVaultEmoteSlotView : UIBaseView
{
	[Token(Token = "0x40178A2")]
	[FieldOffset(Offset = "0x14")]
	public UIButton slotBtn;

	[Token(Token = "0x40178A3")]
	[FieldOffset(Offset = "0x18")]
	public UISprite defaultIcon;

	[Token(Token = "0x40178A4")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite icon;

	[Token(Token = "0x40178A5")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HintArrow;

	[Token(Token = "0x40178A6")]
	[FieldOffset(Offset = "0x24")]
	public GameObject DownLoadState;

	[Token(Token = "0x40178A7")]
	[FieldOffset(Offset = "0x28")]
	public UILabel BooyahLabel;

	[Token(Token = "0x40178A8")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject DragItem;

	[Token(Token = "0x40178A9")]
	[FieldOffset(Offset = "0x30")]
	public UISprite DragIcon;

	[Token(Token = "0x6016E10")]
	[Address(RVA = "0x26C4C70", Offset = "0x26C4C70", VA = "0x26C4C70")]
	public UINewVaultEmoteSlotView()
	{
	}

	[Token(Token = "0x6016E11")]
	[Address(RVA = "0x26C4C78", Offset = "0x26C4C78", VA = "0x26C4C78", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E12")]
	[Address(RVA = "0x26C509C", Offset = "0x26C509C", VA = "0x26C509C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
