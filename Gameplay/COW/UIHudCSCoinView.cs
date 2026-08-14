using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200361E")]
public class UIHudCSCoinView : UIBaseView
{
	[Token(Token = "0x4015AAA")]
	[FieldOffset(Offset = "0x14")]
	public UILabel coin;

	[Token(Token = "0x6016609")]
	[Address(RVA = "0x1EFF9D4", Offset = "0x1EFF9D4", VA = "0x1EFF9D4")]
	public UIHudCSCoinView()
	{
	}

	[Token(Token = "0x601660A")]
	[Address(RVA = "0x1EFF9DC", Offset = "0x1EFF9DC", VA = "0x1EFF9DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601660B")]
	[Address(RVA = "0x1EFFB84", Offset = "0x1EFFB84", VA = "0x1EFFB84")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
