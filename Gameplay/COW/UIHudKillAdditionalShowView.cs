using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200368C")]
public class UIHudKillAdditionalShowView : UIBaseView
{
	[Token(Token = "0x4015EF6")]
	[FieldOffset(Offset = "0x14")]
	public GameObject KillKillerKing;

	[Token(Token = "0x4015EF7")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Revenge;

	[Token(Token = "0x6016751")]
	[Address(RVA = "0x20B55D4", Offset = "0x20B55D4", VA = "0x20B55D4")]
	public UIHudKillAdditionalShowView()
	{
	}

	[Token(Token = "0x6016752")]
	[Address(RVA = "0x20B55DC", Offset = "0x20B55DC", VA = "0x20B55DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016753")]
	[Address(RVA = "0x20B57CC", Offset = "0x20B57CC", VA = "0x20B57CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
