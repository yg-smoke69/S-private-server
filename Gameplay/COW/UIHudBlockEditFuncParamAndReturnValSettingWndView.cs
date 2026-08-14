using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035ED")]
public class UIHudBlockEditFuncParamAndReturnValSettingWndView : UIBaseView
{
	[Token(Token = "0x4015966")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnApply;

	[Token(Token = "0x4015967")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid TypeSet;

	[Token(Token = "0x4015968")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput InputField;

	[Token(Token = "0x4015969")]
	[FieldOffset(Offset = "0x20")]
	public Transform ParamSet;

	[Token(Token = "0x401596A")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid Grid;

	[Token(Token = "0x6016575")]
	[Address(RVA = "0x1E05C8C", Offset = "0x1E05C8C", VA = "0x1E05C8C")]
	public UIHudBlockEditFuncParamAndReturnValSettingWndView()
	{
	}

	[Token(Token = "0x6016576")]
	[Address(RVA = "0x1E05C94", Offset = "0x1E05C94", VA = "0x1E05C94", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016577")]
	[Address(RVA = "0x1E05F94", Offset = "0x1E05F94", VA = "0x1E05F94")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
