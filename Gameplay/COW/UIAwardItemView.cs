using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033E4")]
public class UIAwardItemView : UIBaseView
{
	[Token(Token = "0x4013EEC")]
	[FieldOffset(Offset = "0x14")]
	public AwardItemView AwardItem;

	[Token(Token = "0x4013EED")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ItemNameLabel;

	[Token(Token = "0x4013EEE")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggle AwardToggle;

	[Token(Token = "0x4013EEF")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SelectedSprite;

	[Token(Token = "0x4013EF0")]
	[FieldOffset(Offset = "0x24")]
	public UISprite UnSelectedSprite;

	[Token(Token = "0x6015F62")]
	[Address(RVA = "0x1402DD0", Offset = "0x1402DD0", VA = "0x1402DD0")]
	public UIAwardItemView()
	{
	}

	[Token(Token = "0x6015F63")]
	[Address(RVA = "0x1402DD8", Offset = "0x1402DD8", VA = "0x1402DD8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F64")]
	[Address(RVA = "0x1403100", Offset = "0x1403100", VA = "0x1403100")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
