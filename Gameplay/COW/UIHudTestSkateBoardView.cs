using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003770")]
public class UIHudTestSkateBoardView : UIBaseView
{
	[Token(Token = "0x4016756")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ToggleDebug;

	[Token(Token = "0x4016757")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Test;

	[Token(Token = "0x4016758")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject skateboardBtnTemplate;

	[Token(Token = "0x4016759")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList easyList;

	[Token(Token = "0x401675A")]
	[FieldOffset(Offset = "0x24")]
	public UIInput searchInput;

	[Token(Token = "0x401675B")]
	[FieldOffset(Offset = "0x28")]
	public UIEasyList searchEasyList;

	[Token(Token = "0x60169FB")]
	[Address(RVA = "0x157A120", Offset = "0x157A120", VA = "0x157A120")]
	public UIHudTestSkateBoardView()
	{
	}

	[Token(Token = "0x60169FC")]
	[Address(RVA = "0x157A128", Offset = "0x157A128", VA = "0x157A128", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169FD")]
	[Address(RVA = "0x157A3D0", Offset = "0x157A3D0", VA = "0x157A3D0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
