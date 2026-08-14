using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026DF")]
internal class UIHudAuxFireController : UIHudButtonBaseController
{
	[Token(Token = "0x400F00E")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudAuxFireView m_View;

	[Token(Token = "0x400F00F")]
	private const string ACTION_CANCEL_FIRE = "Action8";

	[Token(Token = "0x400F010")]
	private const string ACTION_AUX_FIRE = "ACTION_AUX_FIRE";

	[Token(Token = "0x400F011")]
	private const string SPRITE_ICON_AUX_FIRE = "SG_UI_btn_fire";

	[Token(Token = "0x400F012")]
	private const string SPRITE_ICON_CANCEL_FIRE = "SG_UI_main_events_close";

	[Token(Token = "0x400F013")]
	private const string SPRITE_ICON_GRENADE = "SG_UI_icon_Grenade";

	[Token(Token = "0x400F014")]
	private const string SPRITE_ICON_CAMPFIRE = "SG_UI_btn_Bonfire";

	[Token(Token = "0x400F015")]
	private const string SPRITE_ICON_CAREPACKAGE = "SG_UI_icon_AirdropBar";

	[Token(Token = "0x400F016")]
	private const string SPRITE_ICON_ICEWALL = "SG_UI_icon_GlooShield";

	[Token(Token = "0x400F017")]
	private const string SPRITE_ICON_LANDMINE = "SG_UI_icon_Landmine";

	[Token(Token = "0x400F018")]
	private const string SPRITE_ICON_GRAPPLINGHOOK = "SG_UI_icon_GrapplingHook";

	[Token(Token = "0x400F019")]
	private const string SPRITE_ICON_MINISENTRY = "SG_UI_icon_MiniSentryGun";

	[Token(Token = "0x400F01A")]
	private const string SPRITE_ICON_FLASH = "SG_UI_icon_EW_Flash";

	[Token(Token = "0x400F01B")]
	private const string SPRITE_ICON_SMOKE = "SG_UI_icon_SmokeBomb";

	[Token(Token = "0x400F01C")]
	private const string SPRITE_ICON_WATERBALL = "SG_UI_icon_waterball";

	[Token(Token = "0x400F01D")]
	private const string SPRITE_ICON_CANCEL_CHARGE = "SG_UI_main_events_close";

	[Token(Token = "0x400F01E")]
	private const string SPRITE_ICON_PAINTSPRAYER = "SG_Icon_paintsprayer_second_year_hud";

	[Token(Token = "0x400F01F")]
	private const string SPRITE_ICON_DUMMY = "SG_UI_icon_DUMMY_2";

	[Token(Token = "0x400F020")]
	private const string SPRITE_ICON_Fireworks = "SG_UI_Icon_fireworks";

	[Token(Token = "0x400F021")]
	private const string SPRITE_ICON_DICE = "SG_UI_Icon_dice";

	[Token(Token = "0x400F022")]
	private const string SPRITE_ICON_MAGNETICFIELD = "SG_UI_icon_MagneticField";

	[Token(Token = "0x400F023")]
	private const string SPRITE_ICON_FROZENGRENADE = "SG_UI_icon_ice_grenade";

	[Token(Token = "0x400F024")]
	private const string SPRITE_ICON_SNOWBALL = "SG_Icon_HUD_Snowball";

	[Token(Token = "0x400F025")]
	private const string SPRITE_ICON_FLAMEFLASK = "SG_ingame_hud_LWSO_Molotov";

	[Token(Token = "0x400F026")]
	private const string SPRITE_ICON_SMOKEFLASK = "SG_ingame_hud_LWSO_Poison";

	[Token(Token = "0x400F027")]
	[FieldOffset(Offset = "0x30")]
	private ELeftFireSetting m_ShowTiming;

	[Token(Token = "0x400F028")]
	[FieldOffset(Offset = "0x34")]
	private bool m_Sighting;

	[Token(Token = "0x400F029")]
	[FieldOffset(Offset = "0x38")]
	private string m_strButtonAction;

	[Token(Token = "0x400F02A")]
	[FieldOffset(Offset = "0x3C")]
	private BitArrayBoolean m_IsVisible;

	[Token(Token = "0x400F02B")]
	public const uint AuxAimingVisible = 1u;

	[Token(Token = "0x600EB61")]
	[Address(RVA = "0x170F16C", Offset = "0x170F16C", VA = "0x170F16C")]
	public UIHudAuxFireController()
	{
	}

	[Token(Token = "0x600EB62")]
	[Address(RVA = "0x170F204", Offset = "0x170F204", VA = "0x170F204")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EB63")]
	[Address(RVA = "0x170F2A8", Offset = "0x170F2A8", VA = "0x170F2A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EB64")]
	[Address(RVA = "0x170F860", Offset = "0x170F860", VA = "0x170F860", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600EB65")]
	[Address(RVA = "0x170FB30", Offset = "0x170FB30", VA = "0x170FB30", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EB66")]
	[Address(RVA = "0x170FFE8", Offset = "0x170FFE8", VA = "0x170FFE8")]
	private void OnShowNewItemFire(object[] param)
	{
	}

	[Token(Token = "0x600EB67")]
	[Address(RVA = "0x1711160", Offset = "0x1711160", VA = "0x1711160")]
	private void OnBuildingGunIndexChange(object[] data)
	{
	}

	[Token(Token = "0x600EB68")]
	[Address(RVA = "0x1711374", Offset = "0x1711374", VA = "0x1711374")]
	private void OnDragUseIceWall(object[] param)
	{
	}

	[Token(Token = "0x600EB69")]
	[Address(RVA = "0x1711570", Offset = "0x1711570", VA = "0x1711570")]
	private void OnChangeVisible(object[] param)
	{
	}

	[Token(Token = "0x600EB6A")]
	[Address(RVA = "0x1711678", Offset = "0x1711678", VA = "0x1711678")]
	private void OnSightingStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600EB6B")]
	[Address(RVA = "0x1711CDC", Offset = "0x1711CDC", VA = "0x1711CDC")]
	private void OnChargeStateChange(object[] data)
	{
	}

	[Token(Token = "0x600EB6C")]
	[Address(RVA = "0x17122C8", Offset = "0x17122C8", VA = "0x17122C8", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600EB6D")]
	[Address(RVA = "0x17123F4", Offset = "0x17123F4", VA = "0x17123F4")]
	private void ShowTutorialFiringWhenGunSightOpening(object[] param)
	{
	}

	[Token(Token = "0x600EB6E")]
	[Address(RVA = "0x1712550", Offset = "0x1712550", VA = "0x1712550", Slot = "37")]
	protected virtual void OnPlayerGetOnVehicle(object[] ps)
	{
	}

	[Token(Token = "0x600EB6F")]
	[Address(RVA = "0x17125B8", Offset = "0x17125B8", VA = "0x17125B8")]
	private void OnHudSettingChange(object[] param)
	{
	}

	[Token(Token = "0x600EB70")]
	[Address(RVA = "0x170F8DC", Offset = "0x170F8DC", VA = "0x170F8DC")]
	private void UpdateShowTiming()
	{
	}

	[Token(Token = "0x600EB71")]
	[Address(RVA = "0x1712628", Offset = "0x1712628", VA = "0x1712628")]
	private void OnAuxAimVisibleChanged(object[] param)
	{
	}

	[Token(Token = "0x600EB72")]
	[Address(RVA = "0x1712724", Offset = "0x1712724", VA = "0x1712724")]
	private void SetVisible(uint flag, bool bVisible)
	{
	}

	[Token(Token = "0x600EB73")]
	[Address(RVA = "0x1712160", Offset = "0x1712160", VA = "0x1712160")]
	private void UpdateChargeShowHide()
	{
	}

	[Token(Token = "0x600EB74")]
	[Address(RVA = "0x170F9A8", Offset = "0x170F9A8", VA = "0x170F9A8")]
	private void UpdateShowHide()
	{
	}

	[Token(Token = "0x600EB75")]
	[Address(RVA = "0x17127F8", Offset = "0x17127F8", VA = "0x17127F8")]
	private void OnMiniPhaseChanged(object[] data)
	{
	}

	[Token(Token = "0x600EB76")]
	[Address(RVA = "0x17128F4", Offset = "0x17128F4", VA = "0x17128F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EB77")]
	[Address(RVA = "0x17128FC", Offset = "0x17128FC", VA = "0x17128FC")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600EB78")]
	[Address(RVA = "0x1712904", Offset = "0x1712904", VA = "0x1712904")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
