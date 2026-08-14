using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002865")]
internal class UIHudSwitchWeaponController : UIHudButtonBaseController
{
	[Token(Token = "0x400F923")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudSwitchWeaponView m_View;

	[Token(Token = "0x400F924")]
	[FieldOffset(Offset = "0x30")]
	private bool m_PlayEffect;

	[Token(Token = "0x400F925")]
	[FieldOffset(Offset = "0x31")]
	private bool m_CanSwitch;

	[Token(Token = "0x600FCE6")]
	[Address(RVA = "0x1FF2B34", Offset = "0x1FF2B34", VA = "0x1FF2B34")]
	public UIHudSwitchWeaponController()
	{
	}

	[Token(Token = "0x600FCE7")]
	[Address(RVA = "0x1FF2B3C", Offset = "0x1FF2B3C", VA = "0x1FF2B3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FCE8")]
	[Address(RVA = "0x1FF2BE4", Offset = "0x1FF2BE4", VA = "0x1FF2BE4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FCE9")]
	[Address(RVA = "0x1FF2EAC", Offset = "0x1FF2EAC", VA = "0x1FF2EAC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FCEA")]
	[Address(RVA = "0x1FF3048", Offset = "0x1FF3048", VA = "0x1FF3048")]
	private void OnCanSwitchChanged(object[] param)
	{
	}

	[Token(Token = "0x600FCEB")]
	[Address(RVA = "0x1FF33A8", Offset = "0x1FF33A8", VA = "0x1FF33A8")]
	private void OnSightingStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600FCEC")]
	[Address(RVA = "0x1FF34F0", Offset = "0x1FF34F0", VA = "0x1FF34F0")]
	private void OnWeaponSwitched(object[] data)
	{
	}

	[Token(Token = "0x600FCED")]
	[Address(RVA = "0x1FF3558", Offset = "0x1FF3558", VA = "0x1FF3558", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FCEE")]
	[Address(RVA = "0x1FF35FC", Offset = "0x1FF35FC", VA = "0x1FF35FC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FCEF")]
	[Address(RVA = "0x1FF3604", Offset = "0x1FF3604", VA = "0x1FF3604")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
