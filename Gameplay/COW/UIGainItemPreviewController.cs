using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002693")]
internal class UIGainItemPreviewController : UIPreviewNavigationController
{
	[Token(Token = "0x400EE05")]
	[FieldOffset(Offset = "0x7C")]
	private uint m_previewItemId;

	[Token(Token = "0x400EE06")]
	[FieldOffset(Offset = "0x80")]
	private UIGainItemPreviewView m_View;

	[Token(Token = "0x400EE07")]
	[FieldOffset(Offset = "0x84")]
	private CSSharedItemData m_ItemData;

	[Token(Token = "0x400EE08")]
	[FieldOffset(Offset = "0x88")]
	private UIUtils.ScreenshotType m_CurrentScreenshotType;

	[Token(Token = "0x600E7F1")]
	[Address(RVA = "0x245CF7C", Offset = "0x245CF7C", VA = "0x245CF7C")]
	public UIGainItemPreviewController()
	{
	}

	[Token(Token = "0x600E7F2")]
	[Address(RVA = "0x245CF8C", Offset = "0x245CF8C", VA = "0x245CF8C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E7F3")]
	[Address(RVA = "0x245D034", Offset = "0x245D034", VA = "0x245D034", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E7F4")]
	[Address(RVA = "0x245D760", Offset = "0x245D760", VA = "0x245D760", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E7F5")]
	[Address(RVA = "0x245D894", Offset = "0x245D894", VA = "0x245D894", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600E7F6")]
	[Address(RVA = "0x245D8F8", Offset = "0x245D8F8", VA = "0x245D8F8")]
	private void OnShareBtnClick()
	{
	}

	[Token(Token = "0x600E7F7")]
	[Address(RVA = "0x245DA54", Offset = "0x245DA54", VA = "0x245DA54")]
	private void OnClose()
	{
	}

	[Token(Token = "0x600E7F8")]
	[Address(RVA = "0x245D4C8", Offset = "0x245D4C8", VA = "0x245D4C8")]
	private void RefreshUserInfo()
	{
	}

	[Token(Token = "0x600E7F9")]
	[Address(RVA = "0x245DBAC", Offset = "0x245DBAC", VA = "0x245DBAC")]
	private void UpdateHeadshot()
	{
	}

	[Token(Token = "0x600E7FA")]
	[Address(RVA = "0x245DF34", Offset = "0x245DF34", VA = "0x245DF34")]
	private void UpdateHeadshot(uint iid)
	{
	}

	[Token(Token = "0x600E7FB")]
	[Address(RVA = "0x245E0A4", Offset = "0x245E0A4", VA = "0x245E0A4")]
	private void UpdateHeadshot(HeadPicData data)
	{
	}

	[Token(Token = "0x600E7FC")]
	[Address(RVA = "0x245E228", Offset = "0x245E228", VA = "0x245E228", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600E7FD")]
	[Address(RVA = "0x245E33C", Offset = "0x245E33C", VA = "0x245E33C", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600E7FE")]
	[Address(RVA = "0x245E4C4", Offset = "0x245E4C4", VA = "0x245E4C4")]
	private void OnShowPreview(object[] para)
	{
	}

	[Token(Token = "0x600E7FF")]
	[Address(RVA = "0x245E6B4", Offset = "0x245E6B4", VA = "0x245E6B4")]
	private void SetRare()
	{
	}

	[Token(Token = "0x600E800")]
	[Address(RVA = "0x245E8C4", Offset = "0x245E8C4", VA = "0x245E8C4")]
	private void _ShowPreview()
	{
	}

	[Token(Token = "0x600E801")]
	[Address(RVA = "0x245E974", Offset = "0x245E974", VA = "0x245E974", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x600E802")]
	[Address(RVA = "0x245E9E4", Offset = "0x245E9E4", VA = "0x245E9E4", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600E803")]
	[Address(RVA = "0x245EA3C", Offset = "0x245EA3C", VA = "0x245EA3C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E804")]
	[Address(RVA = "0x245EA44", Offset = "0x245EA44", VA = "0x245EA44")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600E805")]
	[Address(RVA = "0x245EA4C", Offset = "0x245EA4C", VA = "0x245EA4C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600E806")]
	[Address(RVA = "0x245EA54", Offset = "0x245EA54", VA = "0x245EA54")]
	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x600E807")]
	[Address(RVA = "0x245EA5C", Offset = "0x245EA5C", VA = "0x245EA5C")]
	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
