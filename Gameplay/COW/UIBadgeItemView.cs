using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033E6")]
public class UIBadgeItemView : UIBaseView
{
	[Token(Token = "0x4013EF5")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BadgeSprite;

	[Token(Token = "0x4013EF6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BadgeBorder;

	[Token(Token = "0x4013EF7")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject BadgeLock;

	[Token(Token = "0x4013EF8")]
	[FieldOffset(Offset = "0x20")]
	public GameObject BadgeUsed;

	[Token(Token = "0x4013EF9")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButton BadegItemBtn;

	[Token(Token = "0x4013EFA")]
	[FieldOffset(Offset = "0x28")]
	public UILabel BadegCountdownLabel;

	[Token(Token = "0x4013EFB")]
	[FieldOffset(Offset = "0x2C")]
	public UICountDownLabel UICountDownLabel;

	[Token(Token = "0x4013EFC")]
	[FieldOffset(Offset = "0x30")]
	public GameObject SpecialEffects;

	[Token(Token = "0x4013EFD")]
	[FieldOffset(Offset = "0x34")]
	public GameObject UnLock;

	[Token(Token = "0x6015F68")]
	[Address(RVA = "0x140425C", Offset = "0x140425C", VA = "0x140425C")]
	public UIBadgeItemView()
	{
	}

	[Token(Token = "0x6015F69")]
	[Address(RVA = "0x1404264", Offset = "0x1404264", VA = "0x1404264", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F6A")]
	[Address(RVA = "0x14046D0", Offset = "0x14046D0", VA = "0x14046D0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
