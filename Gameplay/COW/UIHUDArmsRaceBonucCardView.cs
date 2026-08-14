using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035CF")]
public class UIHUDArmsRaceBonucCardView : UIBaseView
{
	[Token(Token = "0x40158A8")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UseBtn;

	[Token(Token = "0x40158A9")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Btn_cancel;

	[Token(Token = "0x601651B")]
	[Address(RVA = "0x166C4C0", Offset = "0x166C4C0", VA = "0x166C4C0")]
	public UIHUDArmsRaceBonucCardView()
	{
	}

	[Token(Token = "0x601651C")]
	[Address(RVA = "0x166C4C8", Offset = "0x166C4C8", VA = "0x166C4C8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601651D")]
	[Address(RVA = "0x166C6D0", Offset = "0x166C6D0", VA = "0x166C6D0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
