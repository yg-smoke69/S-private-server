using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200274C")]
internal class UIHudFireController : UIHudButtonBaseController
{
	[Token(Token = "0x400F269")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudFireView m_View;

	[Token(Token = "0x400F26A")]
	[FieldOffset(Offset = "0x30")]
	private bool m_HasRegistedButton;

	[Token(Token = "0x400F26B")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 m_DefaultPos;

	[Token(Token = "0x400F26C")]
	private const string SPRITE_ICON_FIRE = "SG_UI_btn_fire";

	[Token(Token = "0x400F26D")]
	private const string SPRITE_ICON_GRENADE = "SG_UI_icon_Grenade";

	[Token(Token = "0x400F26E")]
	private const string SPRITE_ICON_CAMPFIRE = "SG_UI_btn_Bonfire";

	[Token(Token = "0x400F26F")]
	private const string SPRITE_ICON_CAREPACKAGE = "SG_UI_icon_AirdropBar";

	[Token(Token = "0x400F270")]
	private const string SPRITE_ICON_ICEWALL = "SG_UI_icon_GlooShield";

	[Token(Token = "0x400F271")]
	private const string SPRITE_ICON_LANDMINE = "SG_UI_icon_Landmine";

	[Token(Token = "0x400F272")]
	private const string SPRITE_ICON_FIREWORK = "SG_UI_Icon_fireworks";

	[Token(Token = "0x400F273")]
	private const string SPRITE_ICON_GRAPPLINGHOOK = "SG_UI_icon_GrapplingHook";

	[Token(Token = "0x400F274")]
	private const string SPRITE_ICON_MINISENTRY = "SG_UI_icon_MiniSentryGun";

	[Token(Token = "0x400F275")]
	private const string SPRITE_ICON_REDENVELOPE = "SG_UI_icon_Bonus_Tree";

	[Token(Token = "0x400F276")]
	private const string SPRITE_ICON_FLASH = "SG_UI_icon_EW_Flash";

	[Token(Token = "0x400F277")]
	private const string SPRITE_ICON_WATERBALL = "SG_UI_icon_waterball";

	[Token(Token = "0x400F278")]
	private const string SPRITE_ICON_CANCEL_CHARGE = "SG_UI_main_events_close";

	[Token(Token = "0x400F279")]
	private const string SPRITE_ICON_PAINTSPRAYER = "SG_Icon_paintsprayer_second_year_hud";

	[Token(Token = "0x400F27A")]
	private const string SPRITE_ICON_DUMMY = "SG_UI_icon_DUMMY_2";

	[Token(Token = "0x400F27B")]
	private const string SPRITE_ICON_LIGHTSTICK = "SG_UI_btn_lightstick";

	[Token(Token = "0x400F27C")]
	private const string SPRITE_ICON_SKATEBOARD_JUMP = "SG_UI_icon_hoverboard_jump";

	[Token(Token = "0x400F27D")]
	private const string SPRITE_ICON_SMOKE_GRENADE = "SG_UI_icon_SmokeBomb";

	[Token(Token = "0x400F27E")]
	private const string SPRITE_ICON_BIGTOY_GRENADE = "SG_UI_Icon_dice";

	[Token(Token = "0x400F27F")]
	private const string SPRITE_ICON_REAPER_SICKLE = "SG_UI_CfD_btn_Kill";

	[Token(Token = "0x400F280")]
	private const string SPRITE_ICON_MAGNETICFIELD = "SG_UI_icon_MagneticField";

	[Token(Token = "0x400F281")]
	private const string SPRITE_ICON_PERSONALUAV = "SG_UI_btn_UAV_Controller";

	[Token(Token = "0x400F282")]
	private const string SPRITE_ICON_FROZENGRENADE = "SG_UI_icon_ice_grenade";

	[Token(Token = "0x400F283")]
	private const string SPRITE_ICON_SNOWBALL = "SG_Icon_HUD_Snowball";

	[Token(Token = "0x400F284")]
	private const string SPRITE_ICON_FLAMEFLASK = "SG_ingame_hud_LWSO_Molotov";

	[Token(Token = "0x400F285")]
	private const string SPRITE_ICON_SMOKEFLASK = "SG_ingame_hud_LWSO_Poison";

	[Token(Token = "0x400F286")]
	private const string SPRITE_ICON_BALLOONGENERATE = "SG_UI_btn_GenerateBalloon";

	[Token(Token = "0x400F287")]
	private const string ACTION_CANCEL_FIRE = "Action8";

	[Token(Token = "0x400F288")]
	private const string ACTION_FIRE = "Action1";

	[Token(Token = "0x400F289")]
	private const string ACTION_SKATEBOARD_JUMP = "Action5";

	[Token(Token = "0x400F28A")]
	[FieldOffset(Offset = "0x40")]
	private string m_strButtonAction;

	[Token(Token = "0x400F28B")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 m_StartPos;

	[Token(Token = "0x400F28C")]
	[FieldOffset(Offset = "0x50")]
	private float iconScale;

	[Token(Token = "0x400F28D")]
	[FieldOffset(Offset = "0x54")]
	private BitArrayBoolean m_IsVisible;

	[Token(Token = "0x400F28E")]
	public const uint ParachutingVehicleVisible = 1u;

	[Token(Token = "0x400F28F")]
	public const uint AuxAimingVisible = 2u;

	[Token(Token = "0x400F290")]
	[FieldOffset(Offset = "0x58")]
	private float m_BGRangeRadius;

	[Token(Token = "0x400F291")]
	[FieldOffset(Offset = "0x5C")]
	private float multiscale;

	[Token(Token = "0x400F292")]
	[FieldOffset(Offset = "0x60")]
	private uint m_DamageBuffFlag;

	[Token(Token = "0x400F293")]
	[FieldOffset(Offset = "0x64")]
	private float m_CdTime;

	[Token(Token = "0x400F294")]
	[FieldOffset(Offset = "0x68")]
	private float m_LeftTime;

	[Token(Token = "0x400F295")]
	[FieldOffset(Offset = "0x6C")]
	private float m_nextBalloonCoolDownTime;

	[Token(Token = "0x400F296")]
	[FieldOffset(Offset = "0x70")]
	private string m_FireIconBackSprite;

	[Token(Token = "0x400F297")]
	[FieldOffset(Offset = "0x74")]
	private UIAtlas m_FireIconBackAtlas;

	[Token(Token = "0x600EFC7")]
	[Address(RVA = "0x1BA25E4", Offset = "0x1BA25E4", VA = "0x1BA25E4")]
	public UIHudFireController()
	{
	}

	[Token(Token = "0x600EFC8")]
	[Address(RVA = "0x1BA2694", Offset = "0x1BA2694", VA = "0x1BA2694")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EFC9")]
	[Address(RVA = "0x1BA2738", Offset = "0x1BA2738", VA = "0x1BA2738", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EFCA")]
	[Address(RVA = "0x1BA2FF0", Offset = "0x1BA2FF0", VA = "0x1BA2FF0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EFCB")]
	[Address(RVA = "0x1BA35D8", Offset = "0x1BA35D8", VA = "0x1BA35D8", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600EFCC")]
	[Address(RVA = "0x1BA3CE4", Offset = "0x1BA3CE4", VA = "0x1BA3CE4", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600EFCD")]
	[Address(RVA = "0x1BA3908", Offset = "0x1BA3908", VA = "0x1BA3908")]
	private void UpdateAxisTouchingThroughArea()
	{
	}

	[Token(Token = "0x600EFCE")]
	[Address(RVA = "0x1BA3E9C", Offset = "0x1BA3E9C", VA = "0x1BA3E9C")]
	private void OnLocalPlayerAdd(object[] data)
	{
	}

	[Token(Token = "0x600EFCF")]
	[Address(RVA = "0x1BA3F04", Offset = "0x1BA3F04", VA = "0x1BA3F04")]
	private void Update()
	{
	}

	[Token(Token = "0x600EFD0")]
	[Address(RVA = "0x1BA4DAC", Offset = "0x1BA4DAC", VA = "0x1BA4DAC", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600EFD1")]
	[Address(RVA = "0x1BA4D50", Offset = "0x1BA4D50", VA = "0x1BA4D50")]
	private void ActiveFirePosition(bool v)
	{
	}

	[Token(Token = "0x600EFD2")]
	[Address(RVA = "0x1BA4ED8", Offset = "0x1BA4ED8", VA = "0x1BA4ED8")]
	private void OnGetOnOffSkateboard(object[] data)
	{
	}

	[Token(Token = "0x600EFD3")]
	[Address(RVA = "0x1BA6938", Offset = "0x1BA6938", VA = "0x1BA6938")]
	private void OnLocalPlayerSkateboardJumpCd(object[] param)
	{
	}

	[Token(Token = "0x600EFD4")]
	[Address(RVA = "0x1BA6A28", Offset = "0x1BA6A28", VA = "0x1BA6A28")]
	private void OnChargeStateChange(object[] data)
	{
	}

	[Token(Token = "0x600EFD5")]
	[Address(RVA = "0x1BA5C58", Offset = "0x1BA5C58", VA = "0x1BA5C58")]
	private void OnShowNewItemFire(object[] param)
	{
	}

	[Token(Token = "0x600EFD6")]
	[Address(RVA = "0x1BA5474", Offset = "0x1BA5474", VA = "0x1BA5474")]
	private void ChangeAtlas(AAHMJHHPECM itemOnHand)
	{
	}

	[Token(Token = "0x600EFD7")]
	[Address(RVA = "0x1BA6DDC", Offset = "0x1BA6DDC", VA = "0x1BA6DDC")]
	private void OnHudSettingChanged(object[] param)
	{
	}

	[Token(Token = "0x600EFD8")]
	[Address(RVA = "0x1BA6E44", Offset = "0x1BA6E44", VA = "0x1BA6E44")]
	private void OnShowSelf(object[] param)
	{
	}

	[Token(Token = "0x600EFD9")]
	[Address(RVA = "0x1BA7034", Offset = "0x1BA7034", VA = "0x1BA7034")]
	private void OnAuxAimVisibleChanged(object[] param)
	{
	}

	[Token(Token = "0x600EFDA")]
	[Address(RVA = "0x1BA6F34", Offset = "0x1BA6F34", VA = "0x1BA6F34")]
	private void SetVisible(uint flag, bool bVisible)
	{
	}

	[Token(Token = "0x600EFDB")]
	[Address(RVA = "0x1BA7130", Offset = "0x1BA7130", VA = "0x1BA7130", Slot = "18")]
	protected override void OnUIActiveGroupSwitch(ulong activeGroup)
	{
	}

	[Token(Token = "0x600EFDC")]
	[Address(RVA = "0x1BA72E8", Offset = "0x1BA72E8", VA = "0x1BA72E8")]
	private void OnAimingEnemy(object[] data)
	{
	}

	[Token(Token = "0x600EFDD")]
	[Address(RVA = "0x1BA7444", Offset = "0x1BA7444", VA = "0x1BA7444")]
	private void OnAimingEnemyInForceTutorial(object[] data)
	{
	}

	[Token(Token = "0x600EFDE")]
	[Address(RVA = "0x1BA75DC", Offset = "0x1BA75DC", VA = "0x1BA75DC")]
	public void OnReaperTransform(bool toReaper)
	{
	}

	[Token(Token = "0x600EFDF")]
	[Address(RVA = "0x1BA77A8", Offset = "0x1BA77A8", VA = "0x1BA77A8")]
	public void FireIconChangeWithoutItem(ResourceID spriteRes)
	{
	}

	[Token(Token = "0x600EFE0")]
	[Address(RVA = "0x1BA79E4", Offset = "0x1BA79E4", VA = "0x1BA79E4")]
	private void OnMiniPhaseChanged(object[] data)
	{
	}

	[Token(Token = "0x600EFE1")]
	[Address(RVA = "0x1BA2F00", Offset = "0x1BA2F00", VA = "0x1BA2F00")]
	private void HideCdBar()
	{
	}

	[Token(Token = "0x600EFE2")]
	[Address(RVA = "0x1BA5360", Offset = "0x1BA5360", VA = "0x1BA5360")]
	private void ShowCdBar(float cd, float remain)
	{
	}

	[Token(Token = "0x600EFE3")]
	[Address(RVA = "0x1BA7AE0", Offset = "0x1BA7AE0", VA = "0x1BA7AE0")]
	private void OnBuildingGunIndexChange(object[] data)
	{
	}

	[Token(Token = "0x600EFE4")]
	[Address(RVA = "0x1BA7CF4", Offset = "0x1BA7CF4", VA = "0x1BA7CF4")]
	private void UpdateDamageBuff(object[] data)
	{
	}

	[Token(Token = "0x600EFE5")]
	[Address(RVA = "0x1BA7EC0", Offset = "0x1BA7EC0", VA = "0x1BA7EC0")]
	private void OnInfectionShowTutorial(object[] data)
	{
	}

	[Token(Token = "0x600EFE6")]
	[Address(RVA = "0x1BA806C", Offset = "0x1BA806C", VA = "0x1BA806C", Slot = "33")]
	protected override void OnBtnClick()
	{
	}

	[Token(Token = "0x600EFE7")]
	[Address(RVA = "0x1BA81B0", Offset = "0x1BA81B0", VA = "0x1BA81B0")]
	private bool IsBalloonGeneratorOnHand([Optional] AAHMJHHPECM itemOnHand)
	{
		return default(bool);
	}

	[Token(Token = "0x600EFE8")]
	[Address(RVA = "0x1BA6CA0", Offset = "0x1BA6CA0", VA = "0x1BA6CA0")]
	private void CheckBalloonGenCDOnWeaponChange(AAHMJHHPECM itemOnHand)
	{
	}

	[Token(Token = "0x600EFE9")]
	[Address(RVA = "0x1BA8398", Offset = "0x1BA8398", VA = "0x1BA8398", Slot = "31")]
	protected override void OnBtnDown()
	{
	}

	[Token(Token = "0x600EFEA")]
	[Address(RVA = "0x1BA85DC", Offset = "0x1BA85DC", VA = "0x1BA85DC", Slot = "32")]
	protected override void OnBtnUp()
	{
	}

	[Token(Token = "0x600EFEB")]
	[Address(RVA = "0x1BA86D4", Offset = "0x1BA86D4", VA = "0x1BA86D4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EFEC")]
	[Address(RVA = "0x1BA86DC", Offset = "0x1BA86DC", VA = "0x1BA86DC")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600EFED")]
	[Address(RVA = "0x1BA86E4", Offset = "0x1BA86E4", VA = "0x1BA86E4")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600EFEE")]
	[Address(RVA = "0x1BA86EC", Offset = "0x1BA86EC", VA = "0x1BA86EC")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600EFEF")]
	[Address(RVA = "0x1BA86F4", Offset = "0x1BA86F4", VA = "0x1BA86F4")]
	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(ulong P0)
	{
	}

	[Token(Token = "0x600EFF0")]
	[Address(RVA = "0x1BA8714", Offset = "0x1BA8714", VA = "0x1BA8714")]
	public void _003C_003EiFixBaseProxy_OnBtnClick()
	{
	}

	[Token(Token = "0x600EFF1")]
	[Address(RVA = "0x1BA871C", Offset = "0x1BA871C", VA = "0x1BA871C")]
	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	[Token(Token = "0x600EFF2")]
	[Address(RVA = "0x1BA8724", Offset = "0x1BA8724", VA = "0x1BA8724")]
	public void _003C_003EiFixBaseProxy_OnBtnUp()
	{
	}
}
