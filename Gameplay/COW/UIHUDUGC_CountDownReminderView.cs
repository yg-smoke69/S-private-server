using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003790")]
public class UIHUDUGC_CountDownReminderView : UIBaseView
{
	[Token(Token = "0x401682C")]
	[FieldOffset(Offset = "0x14")]
	public UILabel CountDownLabel;

	[Token(Token = "0x401682D")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Descrption;

	[Token(Token = "0x401682E")]
	[FieldOffset(Offset = "0x1C")]
	public UITable table;

	[Token(Token = "0x6016A5B")]
	[Address(RVA = "0x222B164", Offset = "0x222B164", VA = "0x222B164")]
	public UIHUDUGC_CountDownReminderView()
	{
	}

	[Token(Token = "0x6016A5C")]
	[Address(RVA = "0x222B16C", Offset = "0x222B16C", VA = "0x222B16C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A5D")]
	[Address(RVA = "0x222B3D4", Offset = "0x222B3D4", VA = "0x222B3D4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
