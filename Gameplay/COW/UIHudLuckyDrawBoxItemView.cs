using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003698")]
public class UIHudLuckyDrawBoxItemView : UIBaseView
{
	[Token(Token = "0x4015F72")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Icon;

	[Token(Token = "0x4015F73")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Count;

	[Token(Token = "0x4015F74")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Bg;

	[Token(Token = "0x4015F75")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ItemName;

	[Token(Token = "0x4015F76")]
	[FieldOffset(Offset = "0x24")]
	public GameObject LuckyItemVfx;

	[Token(Token = "0x6016775")]
	[Address(RVA = "0xFF3164", Offset = "0xFF3164", VA = "0xFF3164")]
	public UIHudLuckyDrawBoxItemView()
	{
	}

	[Token(Token = "0x6016776")]
	[Address(RVA = "0xFF316C", Offset = "0xFF316C", VA = "0xFF316C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016777")]
	[Address(RVA = "0xFF3488", Offset = "0xFF3488", VA = "0xFF3488")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
