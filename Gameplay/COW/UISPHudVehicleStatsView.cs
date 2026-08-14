using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039E0")]
internal class UISPHudVehicleStatsView : UIBaseView
{
	[Token(Token = "0x40185C5")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Go;

	[Token(Token = "0x40185C6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Container;

	[Token(Token = "0x40185C7")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelSpeed;

	[Token(Token = "0x40185C8")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HPNode;

	[Token(Token = "0x40185C9")]
	[FieldOffset(Offset = "0x24")]
	public UISprite HPIcon;

	[Token(Token = "0x6017146")]
	[Address(RVA = "0x14A8700", Offset = "0x14A8700", VA = "0x14A8700")]
	public UISPHudVehicleStatsView()
	{
	}

	[Token(Token = "0x6017147")]
	[Address(RVA = "0x14A8708", Offset = "0x14A8708", VA = "0x14A8708", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017148")]
	[Address(RVA = "0x14A894C", Offset = "0x14A894C", VA = "0x14A894C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
