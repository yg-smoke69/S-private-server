using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A6F")]
public class UIWeaponKillNotificationItemView : UIBaseView
{
	[Token(Token = "0x4018C6E")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition tween;

	[Token(Token = "0x4018C6F")]
	[FieldOffset(Offset = "0x18")]
	public UISprite qualityBG;

	[Token(Token = "0x4018C70")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite iconQualityBg;

	[Token(Token = "0x4018C71")]
	[FieldOffset(Offset = "0x20")]
	public UISprite icon;

	[Token(Token = "0x4018C72")]
	[FieldOffset(Offset = "0x24")]
	public UILabel content;

	[Token(Token = "0x60172F3")]
	[Address(RVA = "0x102328C", Offset = "0x102328C", VA = "0x102328C")]
	public UIWeaponKillNotificationItemView()
	{
	}

	[Token(Token = "0x60172F4")]
	[Address(RVA = "0x1023294", Offset = "0x1023294", VA = "0x1023294", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172F5")]
	[Address(RVA = "0x10235BC", Offset = "0x10235BC", VA = "0x10235BC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
