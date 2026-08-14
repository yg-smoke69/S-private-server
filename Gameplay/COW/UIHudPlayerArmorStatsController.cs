using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027FF")]
public class UIHudPlayerArmorStatsController : UIBaseController
{
	[Token(Token = "0x400F6CF")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPlayerArmorStatsView m_View;

	[Token(Token = "0x400F6D0")]
	[FieldOffset(Offset = "0x2C")]
	private Player m_Player;

	[Token(Token = "0x400F6D1")]
	[FieldOffset(Offset = "0x30")]
	private Player.ODHBJJAOEBA m_FoldingWingStatus;

	[Token(Token = "0x400F6D2")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsSkateboarding;

	[Token(Token = "0x400F6D3")]
	[FieldOffset(Offset = "0x38")]
	private int curHelmetLevel;

	[Token(Token = "0x400F6D4")]
	[FieldOffset(Offset = "0x3C")]
	private int curArmorLevel;

	[Token(Token = "0x400F6D5")]
	[FieldOffset(Offset = "0x40")]
	private string FilledArmorIcon;

	[Token(Token = "0x400F6D6")]
	[FieldOffset(Offset = "0x44")]
	private string FilledArmorIconBG;

	[Token(Token = "0x400F6D7")]
	[FieldOffset(Offset = "0x48")]
	private string FilledArmorIconExplode;

	[Token(Token = "0x400F6D8")]
	[FieldOffset(Offset = "0x4C")]
	private string FilledArmorIconExplodeBG;

	[Token(Token = "0x400F6D9")]
	[FieldOffset(Offset = "0x50")]
	private string FilledHeadIcon;

	[Token(Token = "0x400F6DA")]
	[FieldOffset(Offset = "0x54")]
	private string FilledHeadIconBG;

	[Token(Token = "0x400F6DB")]
	[FieldOffset(Offset = "0x58")]
	private string FilledHeadIconProtect;

	[Token(Token = "0x400F6DC")]
	[FieldOffset(Offset = "0x5C")]
	private string FilledHeadIconProtectBG;

	[Token(Token = "0x400F6DD")]
	[FieldOffset(Offset = "0x60")]
	private Color NormalColor;

	[Token(Token = "0x400F6DE")]
	[FieldOffset(Offset = "0x70")]
	private Color InRecoverColor;

	[Token(Token = "0x400F6DF")]
	[FieldOffset(Offset = "0x80")]
	private uint m_HelmetVFXDelayCall;

	[Token(Token = "0x400F6E0")]
	[FieldOffset(Offset = "0x84")]
	private uint m_VestVFXDelayCall;

	[Token(Token = "0x170011ED")]
	private bool CanDriverUse
	{
		[Token(Token = "0x600F897")]
		[Address(RVA = "0x1862B20", Offset = "0x1862B20", VA = "0x1862B20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600F892")]
	[Address(RVA = "0x1861A54", Offset = "0x1861A54", VA = "0x1861A54")]
	public UIHudPlayerArmorStatsController()
	{
	}

	[Token(Token = "0x600F893")]
	[Address(RVA = "0x1861C08", Offset = "0x1861C08", VA = "0x1861C08")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F894")]
	[Address(RVA = "0x1861CB0", Offset = "0x1861CB0", VA = "0x1861CB0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F895")]
	[Address(RVA = "0x1862034", Offset = "0x1862034", VA = "0x1862034", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F896")]
	[Address(RVA = "0x18625CC", Offset = "0x18625CC", VA = "0x18625CC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F898")]
	[Address(RVA = "0x1862C18", Offset = "0x1862C18", VA = "0x1862C18")]
	private void OnBtnQuickUse()
	{
	}

	[Token(Token = "0x600F899")]
	[Address(RVA = "0x1863004", Offset = "0x1863004", VA = "0x1863004")]
	private void OnInventoryRepairArmorChanged(object[] param)
	{
	}

	[Token(Token = "0x600F89A")]
	[Address(RVA = "0x18633F8", Offset = "0x18633F8", VA = "0x18633F8")]
	private void OnPlayerDead(object[] data)
	{
	}

	[Token(Token = "0x600F89B")]
	[Address(RVA = "0x18630F0", Offset = "0x18630F0", VA = "0x18630F0")]
	private void UpdatetVisibility()
	{
	}

	[Token(Token = "0x600F89C")]
	[Address(RVA = "0x1863628", Offset = "0x1863628", VA = "0x1863628")]
	private void OnReadyToGlide(object[] data)
	{
	}

	[Token(Token = "0x600F89D")]
	[Address(RVA = "0x1863718", Offset = "0x1863718", VA = "0x1863718")]
	private void OnGetOnOffSkateboard(object[] data)
	{
	}

	[Token(Token = "0x600F89E")]
	[Address(RVA = "0x1863934", Offset = "0x1863934", VA = "0x1863934")]
	private void UpdateUseBtnStatust(object[] InParams)
	{
	}

	[Token(Token = "0x600F89F")]
	[Address(RVA = "0x1863BB0", Offset = "0x1863BB0", VA = "0x1863BB0")]
	private void OnAttachmentChanged(object[] data)
	{
	}

	[Token(Token = "0x600F8A0")]
	[Address(RVA = "0x1865028", Offset = "0x1865028", VA = "0x1865028")]
	private void OnMaxDurabilityChanged(object[] data)
	{
	}

	[Token(Token = "0x600F8A1")]
	[Address(RVA = "0x186509C", Offset = "0x186509C", VA = "0x186509C")]
	private void BindPlayer(Player p)
	{
	}

	[Token(Token = "0x600F8A2")]
	[Address(RVA = "0x18650FC", Offset = "0x18650FC", VA = "0x18650FC")]
	private void OnAddPlayer(object[] data)
	{
	}

	[Token(Token = "0x600F8A3")]
	[Address(RVA = "0x1865220", Offset = "0x1865220", VA = "0x1865220")]
	private void OnObservePlayer(object[] data)
	{
	}

	[Token(Token = "0x600F8A4")]
	[Address(RVA = "0x18653DC", Offset = "0x18653DC", VA = "0x18653DC")]
	private void OnPlayerPostInit(object[] data)
	{
	}

	[Token(Token = "0x600F8A5")]
	[Address(RVA = "0x1863F84", Offset = "0x1863F84", VA = "0x1863F84")]
	private void RefreshEquipmentStats(BMGBKEENCJH InSlot = BMGBKEENCJH.Unknown)
	{
	}

	[Token(Token = "0x600F8A6")]
	[Address(RVA = "0x1865448", Offset = "0x1865448", VA = "0x1865448")]
	private void OnRecoverArmorDurability(object[] parms)
	{
	}

	[Token(Token = "0x600F8A7")]
	[Address(RVA = "0x18655B0", Offset = "0x18655B0", VA = "0x18655B0")]
	private void RecoverArmorDurability()
	{
	}

	[Token(Token = "0x600F8A8")]
	[Address(RVA = "0x18658A0", Offset = "0x18658A0", VA = "0x18658A0")]
	private void OnEnquipmentEquipStateChanged(object[] InParams)
	{
	}

	[Token(Token = "0x600F8A9")]
	[Address(RVA = "0x1865AC4", Offset = "0x1865AC4", VA = "0x1865AC4")]
	public void RefreshStrengthenArmorUI()
	{
	}

	[Token(Token = "0x600F8AA")]
	[Address(RVA = "0x1865F4C", Offset = "0x1865F4C", VA = "0x1865F4C")]
	private void _003COnAttachmentChanged_003Em__0()
	{
	}

	[Token(Token = "0x600F8AB")]
	[Address(RVA = "0x1865FB0", Offset = "0x1865FB0", VA = "0x1865FB0")]
	private void _003COnAttachmentChanged_003Em__1()
	{
	}

	[Token(Token = "0x600F8AC")]
	[Address(RVA = "0x1866014", Offset = "0x1866014", VA = "0x1866014")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F8AD")]
	[Address(RVA = "0x186601C", Offset = "0x186601C", VA = "0x186601C")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600F8AE")]
	[Address(RVA = "0x1866024", Offset = "0x1866024", VA = "0x1866024")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
