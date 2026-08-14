using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035EB")]
public class UIHudBlockEditCustomFuncWndView : UIBaseView
{
	[Token(Token = "0x4015956")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid Grid;

	[Token(Token = "0x4015957")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnAddParam;

	[Token(Token = "0x4015958")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnAddReturnVal;

	[Token(Token = "0x4015959")]
	[FieldOffset(Offset = "0x20")]
	public UILabel NoReturnValLabel;

	[Token(Token = "0x401595A")]
	[FieldOffset(Offset = "0x24")]
	public UIHudBlockEditCustomFuncItemController FunItem;

	[Token(Token = "0x401595B")]
	[FieldOffset(Offset = "0x28")]
	public UIHudBlockEditCustomFuncItemController ReturnItem;

	[Token(Token = "0x401595C")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnApply;

	[Token(Token = "0x401595D")]
	[FieldOffset(Offset = "0x30")]
	public Transform FuncNamePos;

	[Token(Token = "0x601656F")]
	[Address(RVA = "0x1E038B4", Offset = "0x1E038B4", VA = "0x1E038B4")]
	public UIHudBlockEditCustomFuncWndView()
	{
	}

	[Token(Token = "0x6016570")]
	[Address(RVA = "0x1E038BC", Offset = "0x1E038BC", VA = "0x1E038BC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016571")]
	[Address(RVA = "0x1E03CDC", Offset = "0x1E03CDC", VA = "0x1E03CDC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
