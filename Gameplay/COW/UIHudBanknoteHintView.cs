using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035DF")]
public class UIHudBanknoteHintView : UIBaseView
{
	[Token(Token = "0x4015903")]
	[FieldOffset(Offset = "0x14")]
	public UILabel InfoLabel;

	[Token(Token = "0x4015904")]
	[FieldOffset(Offset = "0x18")]
	public UISprite WarningIcon;

	[Token(Token = "0x601654B")]
	[Address(RVA = "0x171514C", Offset = "0x171514C", VA = "0x171514C")]
	public UIHudBanknoteHintView()
	{
	}

	[Token(Token = "0x601654C")]
	[Address(RVA = "0x1715154", Offset = "0x1715154", VA = "0x1715154", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601654D")]
	[Address(RVA = "0x171535C", Offset = "0x171535C", VA = "0x171535C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
