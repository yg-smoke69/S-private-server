using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200372C")]
public class UIHudSceneEditFuncAttributeSettingView : UIBaseView
{
	[Token(Token = "0x40164D1")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Container;

	[Token(Token = "0x40164D2")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnReset;

	[Token(Token = "0x601692F")]
	[Address(RVA = "0x24D179C", Offset = "0x24D179C", VA = "0x24D179C")]
	public UIHudSceneEditFuncAttributeSettingView()
	{
	}

	[Token(Token = "0x6016930")]
	[Address(RVA = "0x24D17A4", Offset = "0x24D17A4", VA = "0x24D17A4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016931")]
	[Address(RVA = "0x24D19AC", Offset = "0x24D19AC", VA = "0x24D19AC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
