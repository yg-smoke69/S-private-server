using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003980")]
public class UIRuleSafeZoneSettingV2View : UIBaseView
{
	[Token(Token = "0x4018149")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIRuleSafeZoneSettingV2;

	[Token(Token = "0x401814A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BG;

	[Token(Token = "0x401814B")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Title;

	[Token(Token = "0x401814C")]
	[FieldOffset(Offset = "0x20")]
	public UIButton Tip;

	[Token(Token = "0x401814D")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Value;

	[Token(Token = "0x401814E")]
	[FieldOffset(Offset = "0x28")]
	public UIButton PlusBtn;

	[Token(Token = "0x401814F")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton SubBtn;

	[Token(Token = "0x4018150")]
	[FieldOffset(Offset = "0x30")]
	public UISlider Slider;

	[Token(Token = "0x4018151")]
	[FieldOffset(Offset = "0x34")]
	public UISprite Indicator;

	[Token(Token = "0x4018152")]
	[FieldOffset(Offset = "0x38")]
	public UISprite Effect;

	[Token(Token = "0x4018153")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject WorkMapRoot;

	[Token(Token = "0x4018154")]
	[FieldOffset(Offset = "0x40")]
	public UITexture WorkShopItemMap;

	[Token(Token = "0x4018155")]
	[FieldOffset(Offset = "0x44")]
	public UITexture WorkShopItemMapOutline;

	[Token(Token = "0x4018156")]
	[FieldOffset(Offset = "0x48")]
	public UITexture MapBG;

	[Token(Token = "0x6017027")]
	[Address(RVA = "0x2BFFB80", Offset = "0x2BFFB80", VA = "0x2BFFB80")]
	public UIRuleSafeZoneSettingV2View()
	{
	}

	[Token(Token = "0x6017028")]
	[Address(RVA = "0x2BFFB88", Offset = "0x2BFFB88", VA = "0x2BFFB88", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017029")]
	[Address(RVA = "0x2C00204", Offset = "0x2C00204", VA = "0x2C00204")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
