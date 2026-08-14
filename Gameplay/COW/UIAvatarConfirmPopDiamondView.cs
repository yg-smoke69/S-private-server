using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033C4")]
public class UIAvatarConfirmPopDiamondView : UIBaseView
{
	[Token(Token = "0x4013CA9")]
	[FieldOffset(Offset = "0x14")]
	public GameObject PopType2;

	[Token(Token = "0x4013CAA")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BuyBtn;

	[Token(Token = "0x4013CAB")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton CancelBtn1;

	[Token(Token = "0x4013CAC")]
	[FieldOffset(Offset = "0x20")]
	public UILabel MyDesc;

	[Token(Token = "0x6015F02")]
	[Address(RVA = "0x2A7E0F0", Offset = "0x2A7E0F0", VA = "0x2A7E0F0")]
	public UIAvatarConfirmPopDiamondView()
	{
	}

	[Token(Token = "0x6015F03")]
	[Address(RVA = "0x2A7E0F8", Offset = "0x2A7E0F8", VA = "0x2A7E0F8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F04")]
	[Address(RVA = "0x2A7E3B4", Offset = "0x2A7E3B4", VA = "0x2A7E3B4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
