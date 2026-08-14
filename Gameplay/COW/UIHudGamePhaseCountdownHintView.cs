using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003660")]
public class UIHudGamePhaseCountdownHintView : UIBaseView
{
	[Token(Token = "0x4015D22")]
	[FieldOffset(Offset = "0x14")]
	public UISprite IconHint;

	[Token(Token = "0x4015D23")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Label;

	[Token(Token = "0x4015D24")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject NormalBg;

	[Token(Token = "0x4015D25")]
	[FieldOffset(Offset = "0x20")]
	public UILabel BigCountdownLabel;

	[Token(Token = "0x4015D26")]
	[FieldOffset(Offset = "0x24")]
	public GameObject EnhanceBg;

	[Token(Token = "0x60166CD")]
	[Address(RVA = "0x188BAAC", Offset = "0x188BAAC", VA = "0x188BAAC")]
	public UIHudGamePhaseCountdownHintView()
	{
	}

	[Token(Token = "0x60166CE")]
	[Address(RVA = "0x188BAB4", Offset = "0x188BAB4", VA = "0x188BAB4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166CF")]
	[Address(RVA = "0x188BDC4", Offset = "0x188BDC4", VA = "0x188BDC4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
