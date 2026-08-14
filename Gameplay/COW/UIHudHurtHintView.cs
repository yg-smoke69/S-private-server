using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003670")]
public class UIHudHurtHintView : UIBaseView
{
	[Token(Token = "0x4015D95")]
	[FieldOffset(Offset = "0x14")]
	public GameObject HintGo;

	[Token(Token = "0x4015D96")]
	[FieldOffset(Offset = "0x18")]
	public GameObject HintPenetrateGo;

	[Token(Token = "0x4015D97")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject HintStrongerGo;

	[Token(Token = "0x4015D98")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HintWeakerGo;

	[Token(Token = "0x60166FD")]
	[Address(RVA = "0x13466F0", Offset = "0x13466F0", VA = "0x13466F0")]
	public UIHudHurtHintView()
	{
	}

	[Token(Token = "0x60166FE")]
	[Address(RVA = "0x13466F8", Offset = "0x13466F8", VA = "0x13466F8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166FF")]
	[Address(RVA = "0x1346990", Offset = "0x1346990", VA = "0x1346990")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
