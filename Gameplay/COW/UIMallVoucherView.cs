using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200387A")]
public class UIMallVoucherView : UIBaseView
{
	[Token(Token = "0x4017417")]
	[FieldOffset(Offset = "0x14")]
	public UIButton VoucherBtn;

	[Token(Token = "0x4017418")]
	[FieldOffset(Offset = "0x18")]
	public UILabel VoucherLabel;

	[Token(Token = "0x4017419")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite VoucherBG;

	[Token(Token = "0x401741A")]
	[FieldOffset(Offset = "0x20")]
	public Transform Arrow;

	[Token(Token = "0x401741B")]
	[FieldOffset(Offset = "0x24")]
	public UISprite VoucherIcon;

	[Token(Token = "0x401741C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ArrowBG;

	[Token(Token = "0x401741D")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject VoucherListContainer;

	[Token(Token = "0x6016D19")]
	[Address(RVA = "0x226EA74", Offset = "0x226EA74", VA = "0x226EA74")]
	public UIMallVoucherView()
	{
	}

	[Token(Token = "0x6016D1A")]
	[Address(RVA = "0x226EA7C", Offset = "0x226EA7C", VA = "0x226EA7C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D1B")]
	[Address(RVA = "0x226EE24", Offset = "0x226EE24", VA = "0x226EE24")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
