using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003981")]
public class UIRuleSafeZoneSettingView : UIBaseView
{
	[Token(Token = "0x4018157")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x4018158")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4018159")]
	[FieldOffset(Offset = "0x1C")]
	public UISlider Slider;

	[Token(Token = "0x401815A")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Value;

	[Token(Token = "0x401815B")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Effect;

	[Token(Token = "0x401815C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject WorkMapRoot;

	[Token(Token = "0x401815D")]
	[FieldOffset(Offset = "0x2C")]
	public UITexture WorkShopItemMap;

	[Token(Token = "0x401815E")]
	[FieldOffset(Offset = "0x30")]
	public UITexture WorkShopItemMapOutline;

	[Token(Token = "0x601702A")]
	[Address(RVA = "0x2C0020C", Offset = "0x2C0020C", VA = "0x2C0020C")]
	public UIRuleSafeZoneSettingView()
	{
	}

	[Token(Token = "0x601702B")]
	[Address(RVA = "0x2C00214", Offset = "0x2C00214", VA = "0x2C00214", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601702C")]
	[Address(RVA = "0x2C00650", Offset = "0x2C00650", VA = "0x2C00650")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
