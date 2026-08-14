using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003693")]
public class UIHUDLeftAndRightMoveView : UIBaseView
{
	[Token(Token = "0x4015F5F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton LeftBtn;

	[Token(Token = "0x4015F60")]
	[FieldOffset(Offset = "0x18")]
	public UIButton RightBtn;

	[Token(Token = "0x6016766")]
	[Address(RVA = "0x167A630", Offset = "0x167A630", VA = "0x167A630")]
	public UIHUDLeftAndRightMoveView()
	{
	}

	[Token(Token = "0x6016767")]
	[Address(RVA = "0x167A638", Offset = "0x167A638", VA = "0x167A638", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016768")]
	[Address(RVA = "0x167A840", Offset = "0x167A840", VA = "0x167A840")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
