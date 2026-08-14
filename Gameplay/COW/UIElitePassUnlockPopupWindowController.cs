using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025FB")]
internal class UIElitePassUnlockPopupWindowController : UIPopupWindowController
{
	[Token(Token = "0x400EAA7")]
	[FieldOffset(Offset = "0x48")]
	private UIElitePassUnlockEPPopupView m_View;

	[Token(Token = "0x400EAA8")]
	public const uint EP_PRIVILEGE_CNT = 4u;

	[Token(Token = "0x400EAA9")]
	public const uint EPBUNDLE_PRIVILEGE_CNT = 5u;

	[Token(Token = "0x600E067")]
	[Address(RVA = "0x3069EF8", Offset = "0x3069EF8", VA = "0x3069EF8")]
	public UIElitePassUnlockPopupWindowController()
	{
	}

	[Token(Token = "0x600E068")]
	[Address(RVA = "0x3069F00", Offset = "0x3069F00", VA = "0x3069F00")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E069")]
	[Address(RVA = "0x3069FA8", Offset = "0x3069FA8", VA = "0x3069FA8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E06A")]
	[Address(RVA = "0x306A174", Offset = "0x306A174", VA = "0x306A174")]
	public void UpdateBundleUnlockUI()
	{
	}

	[Token(Token = "0x600E06B")]
	[Address(RVA = "0x306A344", Offset = "0x306A344", VA = "0x306A344")]
	public void RefreshTitle(uint cnt)
	{
	}

	[Token(Token = "0x600E06C")]
	[Address(RVA = "0x306A52C", Offset = "0x306A52C", VA = "0x306A52C")]
	private void OnOKButtonClick()
	{
	}

	[Token(Token = "0x600E06D")]
	[Address(RVA = "0x306A590", Offset = "0x306A590", VA = "0x306A590", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E06E")]
	[Address(RVA = "0x306A6AC", Offset = "0x306A6AC", VA = "0x306A6AC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E06F")]
	[Address(RVA = "0x306A6B4", Offset = "0x306A6B4", VA = "0x306A6B4")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
