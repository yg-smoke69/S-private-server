using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002351")]
internal class UISceneEditReportController : UIPopupWindowController
{
	[Token(Token = "0x2002352")]
	private enum ReportReason
	{
		[Token(Token = "0x400DC0E")]
		Nickname = 1,
		[Token(Token = "0x400DC0F")]
		Violence,
		[Token(Token = "0x400DC10")]
		AD,
		[Token(Token = "0x400DC11")]
		Other
	}

	[Token(Token = "0x400DC09")]
	[FieldOffset(Offset = "0x48")]
	private UISceneEditReportView m_View;

	[Token(Token = "0x400DC0A")]
	[FieldOffset(Offset = "0x4C")]
	private string m_Code;

	[Token(Token = "0x400DC0B")]
	[FieldOffset(Offset = "0x50")]
	private ReportReason m_SelectedReason;

	[Token(Token = "0x400DC0C")]
	[FieldOffset(Offset = "0x54")]
	private EUGCScene m_Src;

	[Token(Token = "0x600C4C2")]
	[Address(RVA = "0x2DA6CFC", Offset = "0x2DA6CFC", VA = "0x2DA6CFC")]
	public UISceneEditReportController()
	{
	}

	[Token(Token = "0x600C4C3")]
	[Address(RVA = "0x2DA6D0C", Offset = "0x2DA6D0C", VA = "0x2DA6D0C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C4C4")]
	[Address(RVA = "0x2DA6DB0", Offset = "0x2DA6DB0", VA = "0x2DA6DB0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C4C5")]
	[Address(RVA = "0x2DA7098", Offset = "0x2DA7098", VA = "0x2DA7098")]
	public void SetUIData(string author, string name, string code, EUGCScene source)
	{
	}

	[Token(Token = "0x600C4C6")]
	[Address(RVA = "0x2DA7194", Offset = "0x2DA7194", VA = "0x2DA7194")]
	private void OnReportReasonSelect(UIToggleButton button)
	{
	}

	[Token(Token = "0x600C4C7")]
	[Address(RVA = "0x2DA73C0", Offset = "0x2DA73C0", VA = "0x2DA73C0")]
	private void OnBtnConfirmClick()
	{
	}

	[Token(Token = "0x600C4C8")]
	[Address(RVA = "0x2DA7510", Offset = "0x2DA7510", VA = "0x2DA7510")]
	private void OnBtnCancelClick()
	{
	}

	[Token(Token = "0x600C4C9")]
	[Address(RVA = "0x2DA7574", Offset = "0x2DA7574", VA = "0x2DA7574")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
