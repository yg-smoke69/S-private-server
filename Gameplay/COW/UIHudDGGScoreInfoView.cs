using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003638")]
public class UIHudDGGScoreInfoView : UIBaseView
{
	[Token(Token = "0x4015BED")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ScoreLabel;

	[Token(Token = "0x4015BEE")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LeadingScoreLabel;

	[Token(Token = "0x6016655")]
	[Address(RVA = "0x1CCDC8C", Offset = "0x1CCDC8C", VA = "0x1CCDC8C")]
	public UIHudDGGScoreInfoView()
	{
	}

	[Token(Token = "0x6016656")]
	[Address(RVA = "0x1CCDC94", Offset = "0x1CCDC94", VA = "0x1CCDC94", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016657")]
	[Address(RVA = "0x1CCDE9C", Offset = "0x1CCDE9C", VA = "0x1CCDE9C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
