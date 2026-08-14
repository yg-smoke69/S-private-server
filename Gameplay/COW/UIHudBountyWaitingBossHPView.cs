using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035F9")]
public class UIHudBountyWaitingBossHPView : UIBaseView
{
	[Token(Token = "0x40159C0")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x40159C1")]
	[FieldOffset(Offset = "0x18")]
	public UISprite HPbarfg;

	[Token(Token = "0x40159C2")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite HPbarbg;

	[Token(Token = "0x40159C3")]
	[FieldOffset(Offset = "0x20")]
	public GameObject WarningIcon;

	[Token(Token = "0x40159C4")]
	[FieldOffset(Offset = "0x24")]
	public UILabel WarningTxt;

	[Token(Token = "0x6016599")]
	[Address(RVA = "0x1E16BB0", Offset = "0x1E16BB0", VA = "0x1E16BB0")]
	public UIHudBountyWaitingBossHPView()
	{
	}

	[Token(Token = "0x601659A")]
	[Address(RVA = "0x1E16BB8", Offset = "0x1E16BB8", VA = "0x1E16BB8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601659B")]
	[Address(RVA = "0x1E16DFC", Offset = "0x1E16DFC", VA = "0x1E16DFC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
