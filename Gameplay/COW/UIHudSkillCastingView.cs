using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200374F")]
public class UIHudSkillCastingView : UIBaseView
{
	[Token(Token = "0x401661A")]
	[FieldOffset(Offset = "0x14")]
	public UIProgressBar CastingProgress;

	[Token(Token = "0x6016998")]
	[Address(RVA = "0x16C2098", Offset = "0x16C2098", VA = "0x16C2098")]
	public UIHudSkillCastingView()
	{
	}

	[Token(Token = "0x6016999")]
	[Address(RVA = "0x16C20A0", Offset = "0x16C20A0", VA = "0x16C20A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601699A")]
	[Address(RVA = "0x16C2248", Offset = "0x16C2248", VA = "0x16C2248")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
