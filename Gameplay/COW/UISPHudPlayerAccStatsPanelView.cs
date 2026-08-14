using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039C9")]
internal class UISPHudPlayerAccStatsPanelView : UIBaseView
{
	[Token(Token = "0x40184F1")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x40184F2")]
	[FieldOffset(Offset = "0x18")]
	public GameObject DamageGo;

	[Token(Token = "0x40184F3")]
	[FieldOffset(Offset = "0x1C")]
	public UISPHudPlayerAccStatsItemView DamageView;

	[Token(Token = "0x40184F4")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HeadShotGo;

	[Token(Token = "0x40184F5")]
	[FieldOffset(Offset = "0x24")]
	public UISPHudPlayerAccStatsItemView HeadShotView;

	[Token(Token = "0x40184F6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject KillGo;

	[Token(Token = "0x40184F7")]
	[FieldOffset(Offset = "0x2C")]
	public UISPHudPlayerAccStatsItemView KillVIew;

	[Token(Token = "0x6017101")]
	[Address(RVA = "0x1D276D0", Offset = "0x1D276D0", VA = "0x1D276D0")]
	public UISPHudPlayerAccStatsPanelView()
	{
	}

	[Token(Token = "0x6017102")]
	[Address(RVA = "0x1D276D8", Offset = "0x1D276D8", VA = "0x1D276D8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017103")]
	[Address(RVA = "0x1D279BC", Offset = "0x1D279BC", VA = "0x1D279BC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
