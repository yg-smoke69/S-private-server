using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200337D")]
public class FFWS03CreateTeamConfirmView : UIBaseView
{
	[Token(Token = "0x40139D6")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnConfirmClose;

	[Token(Token = "0x40139D7")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnConfirmCancel;

	[Token(Token = "0x40139D8")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnConfirmOK;

	[Token(Token = "0x6015E2E")]
	[Address(RVA = "0x2302AB4", Offset = "0x2302AB4", VA = "0x2302AB4")]
	public FFWS03CreateTeamConfirmView()
	{
	}

	[Token(Token = "0x6015E2F")]
	[Address(RVA = "0x2302ABC", Offset = "0x2302ABC", VA = "0x2302ABC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E30")]
	[Address(RVA = "0x2302D24", Offset = "0x2302D24", VA = "0x2302D24")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
