using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034F8")]
public class UIDressUpExchangeItemView : UIBaseView
{
	[Token(Token = "0x4014D66")]
	[FieldOffset(Offset = "0x14")]
	public UIButton SlotBtn;

	[Token(Token = "0x4014D67")]
	[FieldOffset(Offset = "0x18")]
	public UISprite dresssprite;

	[Token(Token = "0x4014D68")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel SlotId;

	[Token(Token = "0x6016298")]
	[Address(RVA = "0x276BA30", Offset = "0x276BA30", VA = "0x276BA30")]
	public UIDressUpExchangeItemView()
	{
	}

	[Token(Token = "0x6016299")]
	[Address(RVA = "0x276BA38", Offset = "0x276BA38", VA = "0x276BA38", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601629A")]
	[Address(RVA = "0x276BCA0", Offset = "0x276BCA0", VA = "0x276BCA0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
