using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002862")]
internal class UIHudSwapWeaponQuickController : UIHudButtonBaseController
{
	[Token(Token = "0x400F91C")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudSwapWeaponQuickView m_View;

	[Token(Token = "0x400F91D")]
	[FieldOffset(Offset = "0x30")]
	private EChangeWeaponSetting m_Setting;

	[Token(Token = "0x600FCC5")]
	[Address(RVA = "0x1FF05D0", Offset = "0x1FF05D0", VA = "0x1FF05D0")]
	public UIHudSwapWeaponQuickController()
	{
	}

	[Token(Token = "0x600FCC6")]
	[Address(RVA = "0x1FF05D8", Offset = "0x1FF05D8", VA = "0x1FF05D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FCC7")]
	[Address(RVA = "0x1FF067C", Offset = "0x1FF067C", VA = "0x1FF067C", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FCC8")]
	[Address(RVA = "0x1FF0720", Offset = "0x1FF0720", VA = "0x1FF0720", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FCC9")]
	[Address(RVA = "0x1FF0894", Offset = "0x1FF0894", VA = "0x1FF0894", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FCCA")]
	[Address(RVA = "0x1FF09C8", Offset = "0x1FF09C8", VA = "0x1FF09C8", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600FCCB")]
	[Address(RVA = "0x1FF0BA4", Offset = "0x1FF0BA4", VA = "0x1FF0BA4")]
	private void OnHudSettingChange(object[] param)
	{
	}

	[Token(Token = "0x600FCCC")]
	[Address(RVA = "0x1FF0A3C", Offset = "0x1FF0A3C", VA = "0x1FF0A3C")]
	private void UpdateShowTiming()
	{
	}

	[Token(Token = "0x600FCCD")]
	[Address(RVA = "0x1FF0B08", Offset = "0x1FF0B08", VA = "0x1FF0B08")]
	private void UpdateShowHide()
	{
	}

	[Token(Token = "0x600FCCE")]
	[Address(RVA = "0x1FF0C14", Offset = "0x1FF0C14", VA = "0x1FF0C14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FCCF")]
	[Address(RVA = "0x1FF0C1C", Offset = "0x1FF0C1C", VA = "0x1FF0C1C")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600FCD0")]
	[Address(RVA = "0x1FF0C24", Offset = "0x1FF0C24", VA = "0x1FF0C24")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
