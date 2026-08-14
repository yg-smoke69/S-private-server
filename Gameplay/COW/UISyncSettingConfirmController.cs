using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B60")]
public class UISyncSettingConfirmController : UIPopupWindowController
{
	[Token(Token = "0x40109CF")]
	[FieldOffset(Offset = "0x48")]
	private UISyncSettingConfirmView m_View;

	[Token(Token = "0x40109D0")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelSetting m_Model;

	[Token(Token = "0x6011DE8")]
	[Address(RVA = "0x2014054", Offset = "0x2014054", VA = "0x2014054")]
	public UISyncSettingConfirmController()
	{
	}

	[Token(Token = "0x6011DE9")]
	[Address(RVA = "0x201405C", Offset = "0x201405C", VA = "0x201405C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011DEA")]
	[Address(RVA = "0x2014560", Offset = "0x2014560", VA = "0x2014560")]
	private void RequestUploadSetting()
	{
	}

	[Token(Token = "0x6011DEB")]
	[Address(RVA = "0x20145E4", Offset = "0x20145E4", VA = "0x20145E4")]
	private void RequestDownloadSetting()
	{
	}

	[Token(Token = "0x6011DEC")]
	[Address(RVA = "0x2014668", Offset = "0x2014668", VA = "0x2014668")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011DED")]
	[Address(RVA = "0x2014400", Offset = "0x2014400", VA = "0x2014400")]
	public void ResetContainer()
	{
	}

	[Token(Token = "0x6011DEE")]
	[Address(RVA = "0x2014710", Offset = "0x2014710", VA = "0x2014710")]
	public void SetStatus(UIModelSetting.SyncStatus status)
	{
	}

	[Token(Token = "0x6011DEF")]
	[Address(RVA = "0x2014820", Offset = "0x2014820", VA = "0x2014820")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
