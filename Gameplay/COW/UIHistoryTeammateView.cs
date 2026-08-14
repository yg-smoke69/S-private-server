using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035C1")]
public class UIHistoryTeammateView : UIBaseView
{
	[Token(Token = "0x401584F")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Kill;

	[Token(Token = "0x4015850")]
	[FieldOffset(Offset = "0x18")]
	public UIButton AddFriend;

	[Token(Token = "0x4015851")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel KillLabel;

	[Token(Token = "0x60164F1")]
	[Address(RVA = "0x1633F04", Offset = "0x1633F04", VA = "0x1633F04")]
	public UIHistoryTeammateView()
	{
	}

	[Token(Token = "0x60164F2")]
	[Address(RVA = "0x1633F0C", Offset = "0x1633F0C", VA = "0x1633F0C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164F3")]
	[Address(RVA = "0x1634174", Offset = "0x1634174", VA = "0x1634174")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
