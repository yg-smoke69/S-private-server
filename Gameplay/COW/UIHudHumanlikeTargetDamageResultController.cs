using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023E0")]
public class UIHudHumanlikeTargetDamageResultController : UIBaseController
{
	[Token(Token = "0x400DEF2")]
	[FieldOffset(Offset = "0x28")]
	private UIHudHumanlikeTargetDamageResultView m_View;

	[Token(Token = "0x400DEF3")]
	[FieldOffset(Offset = "0x2C")]
	private float m_BeginDamageTime;

	[Token(Token = "0x400DEF4")]
	[FieldOffset(Offset = "0x30")]
	private float m_LastDamageTime;

	[Token(Token = "0x400DEF5")]
	[FieldOffset(Offset = "0x34")]
	private float m_DamageResetTime;

	[Token(Token = "0x400DEF6")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsFirstHit;

	[Token(Token = "0x400DEF7")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_TotalEffectDamage;

	[Token(Token = "0x400DEF8")]
	[FieldOffset(Offset = "0x40")]
	private uint m_RealDamageVal;

	[Token(Token = "0x400DEF9")]
	[FieldOffset(Offset = "0x44")]
	private uint m_ShieldVal;

	[Token(Token = "0x400DEFA")]
	[FieldOffset(Offset = "0x48")]
	private uint m_HeadShotVal;

	[Token(Token = "0x400DEFB")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_BodyShotVal;

	[Token(Token = "0x400DEFC")]
	[FieldOffset(Offset = "0x50")]
	private uint m_LimbShotVal;

	[Token(Token = "0x400DEFD")]
	[FieldOffset(Offset = "0x54")]
	private bool m_IsShowConfig;

	[Token(Token = "0x600CA7D")]
	[Address(RVA = "0x133FA48", Offset = "0x133FA48", VA = "0x133FA48")]
	public UIHudHumanlikeTargetDamageResultController()
	{
	}

	[Token(Token = "0x600CA7E")]
	[Address(RVA = "0x133FAE0", Offset = "0x133FAE0", VA = "0x133FAE0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CA7F")]
	[Address(RVA = "0x133FB84", Offset = "0x133FB84", VA = "0x133FB84", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CA80")]
	[Address(RVA = "0x13400CC", Offset = "0x13400CC", VA = "0x13400CC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CA81")]
	[Address(RVA = "0x1340268", Offset = "0x1340268", VA = "0x1340268")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600CA82")]
	[Address(RVA = "0x13402D4", Offset = "0x13402D4", VA = "0x13402D4")]
	private void OnHumanTargetHumanBecameInVisible(object[] data)
	{
	}

	[Token(Token = "0x600CA83")]
	[Address(RVA = "0x1340348", Offset = "0x1340348", VA = "0x1340348")]
	private void OnLocalPlayerZoneChanged(object[] data)
	{
	}

	[Token(Token = "0x600CA84")]
	[Address(RVA = "0x13403BC", Offset = "0x13403BC", VA = "0x13403BC")]
	private void OnBtnSwitchClick()
	{
	}

	[Token(Token = "0x600CA85")]
	[Address(RVA = "0x13404A8", Offset = "0x13404A8", VA = "0x13404A8")]
	private void OnCleanDataBtnClick()
	{
	}

	[Token(Token = "0x600CA86")]
	[Address(RVA = "0x134075C", Offset = "0x134075C", VA = "0x134075C")]
	public void UpdateData(DBNMCJLEFJI t, uint realDamage, uint shieldDamage)
	{
	}

	[Token(Token = "0x600CA87")]
	[Address(RVA = "0x1340914", Offset = "0x1340914", VA = "0x1340914")]
	private void UpdateVal(float dura)
	{
	}

	[Token(Token = "0x600CA88")]
	[Address(RVA = "0x1340508", Offset = "0x1340508", VA = "0x1340508")]
	private void ClearAllData()
	{
	}

	[Token(Token = "0x600CA89")]
	[Address(RVA = "0x1340BB4", Offset = "0x1340BB4", VA = "0x1340BB4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CA8A")]
	[Address(RVA = "0x1340BBC", Offset = "0x1340BBC", VA = "0x1340BBC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
