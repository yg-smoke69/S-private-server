using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028B7")]
internal class UIHudWeaponSwitchInfoController : UIBaseController
{
	[Token(Token = "0x400FA9A")]
	[FieldOffset(Offset = "0x28")]
	public UIHudWeaponSwitchInfoView m_View;

	[Token(Token = "0x400FA9B")]
	[FieldOffset(Offset = "0x2C")]
	private BMGBKEENCJH m_EquipSlot;

	[Token(Token = "0x400FA9C")]
	[FieldOffset(Offset = "0x30")]
	private int m_LastAmmoCapacity;

	[Token(Token = "0x400FA9D")]
	[FieldOffset(Offset = "0x34")]
	private int m_LastAmmoLeft;

	[Token(Token = "0x400FA9E")]
	[FieldOffset(Offset = "0x38")]
	private int m_LastAmmoLeftInClip;

	[Token(Token = "0x400FA9F")]
	[FieldOffset(Offset = "0x3C")]
	private int m_LastAmmoLeftInBag;

	[Token(Token = "0x400FAA0")]
	[FieldOffset(Offset = "0x40")]
	private bool m_LastComine;

	[Token(Token = "0x400FAA1")]
	[FieldOffset(Offset = "0x44")]
	private AAHMJHHPECM m_LastWeaponItem;

	[Token(Token = "0x400FAA2")]
	[FieldOffset(Offset = "0x48")]
	private bool m_LastCombined;

	[Token(Token = "0x400FAA3")]
	[FieldOffset(Offset = "0x4C")]
	private UILabel m_MaxAmmo;

	[Token(Token = "0x400FAA4")]
	[FieldOffset(Offset = "0x50")]
	private UISprite m_InfiniteAmmo;

	[Token(Token = "0x400FAA5")]
	[FieldOffset(Offset = "0x54")]
	private UIProgressBar m_AmmonStatusBar;

	[Token(Token = "0x400FAA6")]
	[FieldOffset(Offset = "0x58")]
	private StringBuilder m_Sb;

	[Token(Token = "0x400FAA7")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_IsHyakkiMode;

	[Token(Token = "0x400FAA8")]
	[FieldOffset(Offset = "0x60")]
	private GameObject m_FXLevelUpGold;

	[Token(Token = "0x400FAA9")]
	[FieldOffset(Offset = "0x64")]
	private float m_FXLevelUpOrDownLastTime;

	[Token(Token = "0x400FAAA")]
	[FieldOffset(Offset = "0x68")]
	private float m_FXLevelUpEndTime;

	[Token(Token = "0x400FAAB")]
	[FieldOffset(Offset = "0x6C")]
	private float m_FXLevelDownEndTime;

	[Token(Token = "0x400FAAC")]
	[FieldOffset(Offset = "0x70")]
	private CommonParticleEffect m_FXLevelUp;

	[Token(Token = "0x400FAAD")]
	[FieldOffset(Offset = "0x74")]
	private CommonParticleEffect m_FXLevelDown;

	[Token(Token = "0x400FAAE")]
	[FieldOffset(Offset = "0x78")]
	private Quaternion NormalPrimaryIconRot;

	[Token(Token = "0x400FAAF")]
	[FieldOffset(Offset = "0x88")]
	private Quaternion CombinedPrimaryIconRot;

	[Token(Token = "0x400FAB0")]
	[FieldOffset(Offset = "0x98")]
	private uint m_CloseCombineSpriteDelayCall;

	[Token(Token = "0x400FAB1")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_CanCombine;

	[Token(Token = "0x400FAB2")]
	[FieldOffset(Offset = "0x9D")]
	private bool m_CanThisWeaponCombine;

	[Token(Token = "0x400FAB3")]
	[FieldOffset(Offset = "0x9E")]
	private bool m_CombineMachineEffectiveTrigger;

	[Token(Token = "0x17001207")]
	public BMGBKEENCJH EquipSlot
	{
		[Token(Token = "0x6010041")]
		[Address(RVA = "0x255F568", Offset = "0x255F568", VA = "0x255F568")]
		get
		{
			return default(BMGBKEENCJH);
		}
		[Token(Token = "0x6010042")]
		[Address(RVA = "0x255F5C0", Offset = "0x255F5C0", VA = "0x255F5C0")]
		set
		{
		}
	}

	[Token(Token = "0x601003F")]
	[Address(RVA = "0x255F364", Offset = "0x255F364", VA = "0x255F364")]
	public UIHudWeaponSwitchInfoController()
	{
	}

	[Token(Token = "0x6010040")]
	[Address(RVA = "0x255F4C4", Offset = "0x255F4C4", VA = "0x255F4C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010043")]
	[Address(RVA = "0x255F620", Offset = "0x255F620", VA = "0x255F620")]
	private void Start()
	{
	}

	[Token(Token = "0x6010044")]
	[Address(RVA = "0x255F970", Offset = "0x255F970", VA = "0x255F970", Slot = "9")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6010045")]
	[Address(RVA = "0x255F9D4", Offset = "0x255F9D4", VA = "0x255F9D4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010046")]
	[Address(RVA = "0x255FFF8", Offset = "0x255FFF8", VA = "0x255FFF8")]
	private void ShowLevelUpGoldFX(bool show)
	{
	}

	[Token(Token = "0x6010047")]
	[Address(RVA = "0x2560254", Offset = "0x2560254", VA = "0x2560254", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6010048")]
	[Address(RVA = "0x256078C", Offset = "0x256078C", VA = "0x256078C")]
	public GPBDEDFKJNA GetCurrentWeapon()
	{
		return null;
	}

	[Token(Token = "0x6010049")]
	[Address(RVA = "0x2560930", Offset = "0x2560930", VA = "0x2560930")]
	private void OnMsgReplacerRes(object[] param)
	{
	}

	[Token(Token = "0x601004A")]
	[Address(RVA = "0x256098C", Offset = "0x256098C", VA = "0x256098C")]
	public void ResetUI()
	{
	}

	[Token(Token = "0x601004B")]
	[Address(RVA = "0x2560A30", Offset = "0x2560A30", VA = "0x2560A30")]
	private void SetLevelEffect(GPBDEDFKJNA weapon)
	{
	}

	[Token(Token = "0x601004C")]
	[Address(RVA = "0x2560FA0", Offset = "0x2560FA0", VA = "0x2560FA0")]
	private void Update()
	{
	}

	[Token(Token = "0x601004D")]
	[Address(RVA = "0x25631A8", Offset = "0x25631A8", VA = "0x25631A8")]
	public UIButton GetTutorialBtn()
	{
		return null;
	}

	[Token(Token = "0x601004E")]
	[Address(RVA = "0x2563278", Offset = "0x2563278", VA = "0x2563278")]
	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	[Token(Token = "0x601004F")]
	[Address(RVA = "0x2563348", Offset = "0x2563348", VA = "0x2563348")]
	public void ShowGoldLevelup()
	{
	}

	[Token(Token = "0x6010050")]
	[Address(RVA = "0x25633CC", Offset = "0x25633CC", VA = "0x25633CC")]
	public void ShowLevelUp()
	{
	}

	[Token(Token = "0x6010051")]
	[Address(RVA = "0x2563450", Offset = "0x2563450", VA = "0x2563450")]
	public void ShowLevelDown()
	{
	}

	[Token(Token = "0x6010052")]
	[Address(RVA = "0x25602F4", Offset = "0x25602F4", VA = "0x25602F4")]
	private void ShowLevelUpOrDownEffect(bool isUp, bool show)
	{
	}

	[Token(Token = "0x6010053")]
	[Address(RVA = "0x2563028", Offset = "0x2563028", VA = "0x2563028")]
	private void UpdateLevelUpOrDownEffectHiding()
	{
	}

	[Token(Token = "0x6010054")]
	[Address(RVA = "0x255F69C", Offset = "0x255F69C", VA = "0x255F69C")]
	private void SetDefaultIcon()
	{
	}

	[Token(Token = "0x6010055")]
	[Address(RVA = "0x25634D4", Offset = "0x25634D4", VA = "0x25634D4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010056")]
	[Address(RVA = "0x25637A8", Offset = "0x25637A8", VA = "0x25637A8")]
	private void OnCombineMachineChange(object[] param)
	{
	}

	[Token(Token = "0x6010057")]
	[Address(RVA = "0x2563A2C", Offset = "0x2563A2C", VA = "0x2563A2C")]
	private void CloseCombineSpriteEffect()
	{
	}

	[Token(Token = "0x6010058")]
	[Address(RVA = "0x2563ABC", Offset = "0x2563ABC", VA = "0x2563ABC")]
	private void OnCanCombineChanged(object[] param)
	{
	}

	[Token(Token = "0x6010059")]
	[Address(RVA = "0x2563DF4", Offset = "0x2563DF4", VA = "0x2563DF4")]
	private void OnCombineMachineEffective(object[] param)
	{
	}

	[Token(Token = "0x601005A")]
	[Address(RVA = "0x2563E74", Offset = "0x2563E74", VA = "0x2563E74")]
	private void OnSwitchWeaponClick()
	{
	}

	[Token(Token = "0x601005B")]
	[Address(RVA = "0x2564048", Offset = "0x2564048", VA = "0x2564048")]
	public void SwitchWeapon()
	{
	}

	[Token(Token = "0x601005C")]
	[Address(RVA = "0x256409C", Offset = "0x256409C", VA = "0x256409C")]
	public void TweakUIForHyakki(int width)
	{
	}

	[Token(Token = "0x601005D")]
	[Address(RVA = "0x25641B8", Offset = "0x25641B8", VA = "0x25641B8")]
	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	[Token(Token = "0x601005E")]
	[Address(RVA = "0x25641C0", Offset = "0x25641C0", VA = "0x25641C0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601005F")]
	[Address(RVA = "0x25641C8", Offset = "0x25641C8", VA = "0x25641C8")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6010060")]
	[Address(RVA = "0x25641D0", Offset = "0x25641D0", VA = "0x25641D0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
