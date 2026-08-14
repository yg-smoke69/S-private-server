using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003697")]
public class UIHudLockedWarningView : UIBaseView
{
	[Token(Token = "0x4015F71")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Message;

	[Token(Token = "0x6016772")]
	[Address(RVA = "0xFEE610", Offset = "0xFEE610", VA = "0xFEE610")]
	public UIHudLockedWarningView()
	{
	}

	[Token(Token = "0x6016773")]
	[Address(RVA = "0xFEE618", Offset = "0xFEE618", VA = "0xFEE618", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016774")]
	[Address(RVA = "0xFEE7C0", Offset = "0xFEE7C0", VA = "0xFEE7C0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
