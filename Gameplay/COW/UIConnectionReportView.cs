using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003488")]
public class UIConnectionReportView : UIBaseView
{
	[Token(Token = "0x401472B")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Desc_Label;

	[Token(Token = "0x401472C")]
	[FieldOffset(Offset = "0x18")]
	public UIButton SendBtn;

	[Token(Token = "0x401472D")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnCancel;

	[Token(Token = "0x401472E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SendingState;

	[Token(Token = "0x401472F")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SendedState;

	[Token(Token = "0x601614C")]
	[Address(RVA = "0x1EBF210", Offset = "0x1EBF210", VA = "0x1EBF210")]
	public UIConnectionReportView()
	{
	}

	[Token(Token = "0x601614D")]
	[Address(RVA = "0x1EBF218", Offset = "0x1EBF218", VA = "0x1EBF218", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601614E")]
	[Address(RVA = "0x1EBF528", Offset = "0x1EBF528", VA = "0x1EBF528")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
