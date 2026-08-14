using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003632")]
public class UIHudDebugSSAOView : UIBaseView
{
	[Token(Token = "0x4015BDD")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ToggleDebugSSAO;

	[Token(Token = "0x4015BDE")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Label;

	[Token(Token = "0x6016643")]
	[Address(RVA = "0x1CCFE7C", Offset = "0x1CCFE7C", VA = "0x1CCFE7C")]
	public UIHudDebugSSAOView()
	{
	}

	[Token(Token = "0x6016644")]
	[Address(RVA = "0x1CCFE84", Offset = "0x1CCFE84", VA = "0x1CCFE84", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016645")]
	[Address(RVA = "0x1CD008C", Offset = "0x1CD008C", VA = "0x1CD008C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
