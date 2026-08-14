using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028B5")]
internal class UIHudWeaponInfoController : UIBaseController
{
	[Token(Token = "0x400FA78")]
	[FieldOffset(Offset = "0x28")]
	protected UIHudWeaponInfoView m_View;

	[Token(Token = "0x400FA79")]
	[FieldOffset(Offset = "0x2C")]
	private GPBDEDFKJNA m_LastWeaponInHand;

	[Token(Token = "0x400FA7A")]
	[FieldOffset(Offset = "0x30")]
	private BMGBKEENCJH m_EquipSlot;

	[Token(Token = "0x400FA7B")]
	[FieldOffset(Offset = "0x34")]
	private BMGBKEENCJH m_LastEquipSlot;

	[Token(Token = "0x400FA7C")]
	[FieldOffset(Offset = "0x38")]
	private int m_LastAmmoLeft;

	[Token(Token = "0x400FA7D")]
	[FieldOffset(Offset = "0x3C")]
	private int m_LastAmmoCapacity;

	[Token(Token = "0x400FA7E")]
	[FieldOffset(Offset = "0x40")]
	private int m_LastAmmoLeftInBag;

	[Token(Token = "0x400FA7F")]
	[FieldOffset(Offset = "0x44")]
	private bool m_LastCombined;

	[Token(Token = "0x400FA80")]
	[FieldOffset(Offset = "0x45")]
	private bool m_LastSecondWeaponDataEffective;

	[Token(Token = "0x400FA81")]
	[FieldOffset(Offset = "0x46")]
	private bool m_LastHasGoldAttachment;

	[Token(Token = "0x400FA82")]
	[FieldOffset(Offset = "0x47")]
	private bool m_weaponChanged;

	[Token(Token = "0x400FA83")]
	[FieldOffset(Offset = "0x48")]
	private bool m_UpdateingVehicleWeapon;

	[Token(Token = "0x400FA84")]
	[FieldOffset(Offset = "0x49")]
	private bool m_ModeDriverCanFire;

	[Token(Token = "0x400FA85")]
	public const uint ItemLevelColorPurple = 4292242683u;

	[Token(Token = "0x400FA86")]
	public const uint ItemLevelColorGold = 4289232679u;

	[Token(Token = "0x400FA87")]
	public const uint ItemLevelColorRed = 4288952123u;

	[Token(Token = "0x400FA88")]
	[FieldOffset(Offset = "0x4C")]
	private StringBuilder m_Sb;

	[Token(Token = "0x400FA89")]
	[FieldOffset(Offset = "0x50")]
	private UIHudWeaponSwitchInfoController m_Primary1WeaponController;

	[Token(Token = "0x400FA8A")]
	[FieldOffset(Offset = "0x54")]
	private UIHudWeaponSwitchInfoController m_Primary2WeaponController;

	[Token(Token = "0x400FA8B")]
	[FieldOffset(Offset = "0x58")]
	private UIHudWeaponSwitchInfoController m_SecondaryWeaponController;

	[Token(Token = "0x400FA8C")]
	[FieldOffset(Offset = "0x5C")]
	private UIHudWeaponSwitchInfoController m_MeleeWeaponController;

	[Token(Token = "0x400FA8D")]
	[FieldOffset(Offset = "0x0")]
	public static Color AmmoColorHigh;

	[Token(Token = "0x400FA8E")]
	[FieldOffset(Offset = "0x10")]
	public static Color AmmoColorMid;

	[Token(Token = "0x400FA8F")]
	[FieldOffset(Offset = "0x20")]
	public static Color AmmoColorLow;

	[Token(Token = "0x400FA90")]
	[FieldOffset(Offset = "0x30")]
	public static Color HeatGunNormal;

	[Token(Token = "0x400FA91")]
	[FieldOffset(Offset = "0x40")]
	public static Color HeatGunCooling;

	[Token(Token = "0x400FA92")]
	[FieldOffset(Offset = "0x60")]
	private bool needReposition;

	[Token(Token = "0x400FA93")]
	[FieldOffset(Offset = "0x64")]
	private List<UIHudBuildingSwitchInfoController> m_BuildingSwitchBtns;

	[Token(Token = "0x400FA94")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_FXLevelUpGold;

	[Token(Token = "0x400FA95")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_CloseCombineSpriteDelayCall;

	[Token(Token = "0x400FA96")]
	[FieldOffset(Offset = "0x70")]
	private bool m_CombineMachineEffectiveTrigger;

	[Token(Token = "0x400FA97")]
	[FieldOffset(Offset = "0x74")]
	private Player m_currentPlayer;

	[Token(Token = "0x601000C")]
	[Address(RVA = "0x1A75E04", Offset = "0x1A75E04", VA = "0x1A75E04")]
	public UIHudWeaponInfoController()
	{
	}

	[Token(Token = "0x601000D")]
	[Address(RVA = "0x1A75EC8", Offset = "0x1A75EC8", VA = "0x1A75EC8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601000E")]
	[Address(RVA = "0x1A75F6C", Offset = "0x1A75F6C", VA = "0x1A75F6C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601000F")]
	[Address(RVA = "0x1A774B4", Offset = "0x1A774B4", VA = "0x1A774B4")]
	private void ShowLevelUpGoldFX(bool show)
	{
	}

	[Token(Token = "0x6010010")]
	[Address(RVA = "0x1A77710", Offset = "0x1A77710", VA = "0x1A77710")]
	private void OnEquipAttachment(object[] data)
	{
	}

	[Token(Token = "0x6010011")]
	[Address(RVA = "0x1A77D38", Offset = "0x1A77D38", VA = "0x1A77D38")]
	protected void OnBuffIconChange(object[] data)
	{
	}

	[Token(Token = "0x6010012")]
	[Address(RVA = "0x1A782B0", Offset = "0x1A782B0", VA = "0x1A782B0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010013")]
	[Address(RVA = "0x1A78BB0", Offset = "0x1A78BB0", VA = "0x1A78BB0")]
	private void OnObserverInfoListVisibleChanged(object[] data)
	{
	}

	[Token(Token = "0x6010014")]
	[Address(RVA = "0x1A78CBC", Offset = "0x1A78CBC", VA = "0x1A78CBC")]
	private void OnGrenadeSwitchClick()
	{
	}

	[Token(Token = "0x6010015")]
	[Address(RVA = "0x1A78EDC", Offset = "0x1A78EDC", VA = "0x1A78EDC")]
	private void OnChange2LastEquipWeapon(object[] param)
	{
	}

	[Token(Token = "0x6010016")]
	[Address(RVA = "0x1A78F44", Offset = "0x1A78F44", VA = "0x1A78F44")]
	private void OnCombineMachineChange(object[] param)
	{
	}

	[Token(Token = "0x6010017")]
	[Address(RVA = "0x1A791A0", Offset = "0x1A791A0", VA = "0x1A791A0")]
	private void CloseCombineSpriteEffect()
	{
	}

	[Token(Token = "0x6010018")]
	[Address(RVA = "0x1A79230", Offset = "0x1A79230", VA = "0x1A79230")]
	private void OnCombineMachineEffective(object[] param)
	{
	}

	[Token(Token = "0x6010019")]
	[Address(RVA = "0x1A7952C", Offset = "0x1A7952C", VA = "0x1A7952C")]
	private void OnCanCombineChanged(object[] param)
	{
	}

	[Token(Token = "0x601001A")]
	[Address(RVA = "0x1A79838", Offset = "0x1A79838", VA = "0x1A79838")]
	private void OnMsgReplacerRes(object[] param)
	{
	}

	[Token(Token = "0x601001B")]
	[Address(RVA = "0x1A7995C", Offset = "0x1A7995C", VA = "0x1A7995C")]
	private void OnSecondWeaponDataEffectiveChanged(object[] param)
	{
	}

	[Token(Token = "0x601001C")]
	[Address(RVA = "0x1A79B7C", Offset = "0x1A79B7C", VA = "0x1A79B7C")]
	private void OnHeavyWeaponDrop()
	{
	}

	[Token(Token = "0x601001D")]
	[Address(RVA = "0x1A79D84", Offset = "0x1A79D84", VA = "0x1A79D84")]
	private void SetLevelEffect()
	{
	}

	[Token(Token = "0x601001E")]
	[Address(RVA = "0x1A7A2D8", Offset = "0x1A7A2D8", VA = "0x1A7A2D8")]
	private void Update()
	{
	}

	[Token(Token = "0x601001F")]
	[Address(RVA = "0x1A77F5C", Offset = "0x1A77F5C", VA = "0x1A77F5C")]
	private void ShowAlwaysBuffIcon()
	{
	}

	[Token(Token = "0x6010020")]
	[Address(RVA = "0x1A7FE30", Offset = "0x1A7FE30", VA = "0x1A7FE30")]
	private void UpdateWeaponShowTxt(int currentweapon, int maxweapon)
	{
	}

	[Token(Token = "0x6010021")]
	[Address(RVA = "0x1A80334", Offset = "0x1A80334", VA = "0x1A80334")]
	private void RefreshBuildingInfo(AAHMJHHPECM item)
	{
	}

	[Token(Token = "0x6010022")]
	[Address(RVA = "0x1A809FC", Offset = "0x1A809FC", VA = "0x1A809FC")]
	private bool IsSideWeapon(AAHMJHHPECM item)
	{
		return default(bool);
	}

	[Token(Token = "0x6010023")]
	[Address(RVA = "0x1A80A98", Offset = "0x1A80A98", VA = "0x1A80A98")]
	private bool IsHeavyWeapon(AAHMJHHPECM item)
	{
		return default(bool);
	}

	[Token(Token = "0x6010024")]
	[Address(RVA = "0x1A7EEC4", Offset = "0x1A7EEC4", VA = "0x1A7EEC4")]
	private bool ShouldUpdateVehicleWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x6010025")]
	[Address(RVA = "0x1A7F028", Offset = "0x1A7F028", VA = "0x1A7F028")]
	private void UpdateVehicleWeapon(bool wasUpdating)
	{
	}

	[Token(Token = "0x6010026")]
	[Address(RVA = "0x1A80B98", Offset = "0x1A80B98", VA = "0x1A80B98")]
	private void OnLastWeaponInit(object[] param)
	{
	}

	[Token(Token = "0x6010027")]
	[Address(RVA = "0x1A80D70", Offset = "0x1A80D70", VA = "0x1A80D70")]
	private void OnInventoryItemChanged(object[] param)
	{
	}

	[Token(Token = "0x6010028")]
	[Address(RVA = "0x1A80EDC", Offset = "0x1A80EDC", VA = "0x1A80EDC")]
	private void OnObserverInventoryItemChanged(object[] data)
	{
	}

	[Token(Token = "0x6010029")]
	[Address(RVA = "0x1A80FE0", Offset = "0x1A80FE0", VA = "0x1A80FE0", Slot = "31")]
	protected virtual void OnPlayerGetOnVehicle(object[] ps)
	{
	}

	[Token(Token = "0x601002A")]
	[Address(RVA = "0x1A8103C", Offset = "0x1A8103C", VA = "0x1A8103C")]
	private void CheckWeaponInvaid()
	{
	}

	[Token(Token = "0x601002B")]
	[Address(RVA = "0x1A7FA5C", Offset = "0x1A7FA5C", VA = "0x1A7FA5C")]
	private void RefreshUIByWeaponOnHand(BMGBKEENCJH WeaponEquipSlot)
	{
	}

	[Token(Token = "0x601002C")]
	[Address(RVA = "0x1A81210", Offset = "0x1A81210", VA = "0x1A81210")]
	private void TweakUIForHyakkiMode()
	{
	}

	[Token(Token = "0x601002D")]
	[Address(RVA = "0x1A81408", Offset = "0x1A81408", VA = "0x1A81408")]
	private void OnEnterGameLanding(object[] data)
	{
	}

	[Token(Token = "0x601002E")]
	[Address(RVA = "0x1A81464", Offset = "0x1A81464", VA = "0x1A81464")]
	private void OnPlayerDead(object[] data)
	{
	}

	[Token(Token = "0x601002F")]
	[Address(RVA = "0x1A815C8", Offset = "0x1A815C8", VA = "0x1A815C8")]
	private void ShowSwitchWeaponTutorial(object[] data)
	{
	}

	[Token(Token = "0x6010030")]
	[Address(RVA = "0x1A81888", Offset = "0x1A81888", VA = "0x1A81888")]
	private void ShowSwitchWeaponTutorialInForceTutorial(object[] data)
	{
	}

	[Token(Token = "0x6010031")]
	[Address(RVA = "0x1A81A38", Offset = "0x1A81A38", VA = "0x1A81A38", Slot = "32")]
	protected virtual bool IsOnlyShowOneWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x6010032")]
	[Address(RVA = "0x1A7F93C", Offset = "0x1A7F93C", VA = "0x1A7F93C")]
	private bool CheckSilderWeapon(AAHMJHHPECM item)
	{
		return default(bool);
	}

	[Token(Token = "0x6010033")]
	[Address(RVA = "0x1A7F9CC", Offset = "0x1A7F9CC", VA = "0x1A7F9CC")]
	private bool CheckHeaveyWeapon(AAHMJHHPECM item)
	{
		return default(bool);
	}

	[Token(Token = "0x6010034")]
	[Address(RVA = "0x1A81B80", Offset = "0x1A81B80", VA = "0x1A81B80", Slot = "33")]
	protected virtual bool IsCheckSilderWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x6010035")]
	[Address(RVA = "0x1A81BD8", Offset = "0x1A81BD8", VA = "0x1A81BD8", Slot = "34")]
	protected virtual bool IsCheckHeaveyWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x6010036")]
	[Address(RVA = "0x1A81C30", Offset = "0x1A81C30", VA = "0x1A81C30")]
	private void OnClickGoldWeaponUpgrade()
	{
	}

	[Token(Token = "0x6010037")]
	[Address(RVA = "0x1A81F2C", Offset = "0x1A81F2C", VA = "0x1A81F2C")]
	private void OnReplacerCountChange(object[] param)
	{
	}

	[Token(Token = "0x6010038")]
	[Address(RVA = "0x1A81F94", Offset = "0x1A81F94", VA = "0x1A81F94")]
	private void OnShowWeaponAddFireSpeed(object[] param)
	{
	}

	[Token(Token = "0x6010039")]
	[Address(RVA = "0x1A77254", Offset = "0x1A77254", VA = "0x1A77254")]
	private void RefreshGoldWeaponUpgradeBtnShow()
	{
	}

	[Token(Token = "0x601003B")]
	[Address(RVA = "0x1A821DC", Offset = "0x1A821DC", VA = "0x1A821DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601003C")]
	[Address(RVA = "0x1A821E4", Offset = "0x1A821E4", VA = "0x1A821E4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
