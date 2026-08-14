using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A6B")]
public class UIVoucherListView : UIBaseView
{
	[Token(Token = "0x4018C53")]
	[FieldOffset(Offset = "0x14")]
	public UISprite VoucherBorder;

	[Token(Token = "0x4018C54")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList VoucherItemGrid;

	[Token(Token = "0x4018C55")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget VoucherContainer;

	[Token(Token = "0x60172E7")]
	[Address(RVA = "0x101B82C", Offset = "0x101B82C", VA = "0x101B82C")]
	public UIVoucherListView()
	{
	}

	[Token(Token = "0x60172E8")]
	[Address(RVA = "0x101B834", Offset = "0x101B834", VA = "0x101B834", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172E9")]
	[Address(RVA = "0x101BA9C", Offset = "0x101BA9C", VA = "0x101BA9C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
