using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003737")]
public class UIHudSceneEditModifyView : UIBaseView
{
	[Token(Token = "0x4016512")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnRotate;

	[Token(Token = "0x4016513")]
	[FieldOffset(Offset = "0x18")]
	public UIEventListener BtnDelete;

	[Token(Token = "0x4016514")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnDuplicate;

	[Token(Token = "0x6016950")]
	[Address(RVA = "0x24E6128", Offset = "0x24E6128", VA = "0x24E6128")]
	public UIHudSceneEditModifyView()
	{
	}

	[Token(Token = "0x6016951")]
	[Address(RVA = "0x24E6130", Offset = "0x24E6130", VA = "0x24E6130", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016952")]
	[Address(RVA = "0x24E6398", Offset = "0x24E6398", VA = "0x24E6398")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
