using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039D1")]
public class UISPHudResultPlayerItemView : UIBaseView
{
	[Token(Token = "0x4018537")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UISPHudResultPlayerItem;

	[Token(Token = "0x4018538")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Name;

	[Token(Token = "0x4018539")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Cnt;

	[Token(Token = "0x6017119")]
	[Address(RVA = "0x1D2B8BC", Offset = "0x1D2B8BC", VA = "0x1D2B8BC")]
	public UISPHudResultPlayerItemView()
	{
	}

	[Token(Token = "0x601711A")]
	[Address(RVA = "0x1D2B8C4", Offset = "0x1D2B8C4", VA = "0x1D2B8C4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601711B")]
	[Address(RVA = "0x1D2BB2C", Offset = "0x1D2BB2C", VA = "0x1D2BB2C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
