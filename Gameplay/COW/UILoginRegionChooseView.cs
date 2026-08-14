using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003859")]
public class UILoginRegionChooseView : UIBaseView
{
	[Token(Token = "0x4017170")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid InfoContainer;

	[Token(Token = "0x4017171")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x6016CB6")]
	[Address(RVA = "0x21F7C5C", Offset = "0x21F7C5C", VA = "0x21F7C5C")]
	public UILoginRegionChooseView()
	{
	}

	[Token(Token = "0x6016CB7")]
	[Address(RVA = "0x21F7C64", Offset = "0x21F7C64", VA = "0x21F7C64", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CB8")]
	[Address(RVA = "0x21F7E6C", Offset = "0x21F7E6C", VA = "0x21F7E6C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
