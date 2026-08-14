using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200204D")]
internal class UIHudCSShopEntryController : UIBaseController
{
	[Token(Token = "0x400CA74")]
	[FieldOffset(Offset = "0x28")]
	private UIHudCSShopEntryView m_View;

	[Token(Token = "0x400CA75")]
	[FieldOffset(Offset = "0x2C")]
	private EBDJJIHBALF m_ShopFlow;

	[Token(Token = "0x400CA76")]
	[FieldOffset(Offset = "0x30")]
	private KODPEAGCIAL m_MatchPhase;

	[Token(Token = "0x400CA77")]
	[FieldOffset(Offset = "0x34")]
	private int m_CurRound;

	[Token(Token = "0x400CA78")]
	[FieldOffset(Offset = "0x38")]
	private int m_MaxRound;

	[Token(Token = "0x400CA79")]
	[FieldOffset(Offset = "0x3C")]
	private NLGKDGCHAIB m_TakeTurnsShopState;

	[Token(Token = "0x600A490")]
	[Address(RVA = "0x213F95C", Offset = "0x213F95C", VA = "0x213F95C")]
	public UIHudCSShopEntryController()
	{
	}

	[Token(Token = "0x600A491")]
	[Address(RVA = "0x213F9E0", Offset = "0x213F9E0", VA = "0x213F9E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A492")]
	[Address(RVA = "0x213FA88", Offset = "0x213FA88", VA = "0x213FA88", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A493")]
	[Address(RVA = "0x213FDD0", Offset = "0x213FDD0", VA = "0x213FDD0")]
	private void OnShowCSGuideStoreBtn(object[] data)
	{
	}

	[Token(Token = "0x600A494")]
	[Address(RVA = "0x213FF5C", Offset = "0x213FF5C", VA = "0x213FF5C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600A495")]
	[Address(RVA = "0x2140104", Offset = "0x2140104", VA = "0x2140104", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600A496")]
	[Address(RVA = "0x21402C4", Offset = "0x21402C4", VA = "0x21402C4")]
	private void OnShopBtnClick()
	{
	}

	[Token(Token = "0x600A497")]
	[Address(RVA = "0x2140BD4", Offset = "0x2140BD4", VA = "0x2140BD4")]
	public UIButton GetTutorialBtn()
	{
		return null;
	}

	[Token(Token = "0x600A498")]
	[Address(RVA = "0x2140CA4", Offset = "0x2140CA4", VA = "0x2140CA4")]
	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	[Token(Token = "0x600A499")]
	[Address(RVA = "0x2140D74", Offset = "0x2140D74", VA = "0x2140D74")]
	private void UpdateShopState(object[] data)
	{
	}

	[Token(Token = "0x600A49A")]
	[Address(RVA = "0x2140FAC", Offset = "0x2140FAC", VA = "0x2140FAC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A49B")]
	[Address(RVA = "0x2140FB4", Offset = "0x2140FB4", VA = "0x2140FB4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600A49C")]
	[Address(RVA = "0x2140FBC", Offset = "0x2140FBC", VA = "0x2140FBC")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
