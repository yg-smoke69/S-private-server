using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002B7A")]
public class UITrainingCampMsgCheckWndController : UIPopupWindowController
{
	[Token(Token = "0x4010A58")]
	[FieldOffset(Offset = "0x48")]
	private UITrainingCampMsgCheckWndView m_View;

	[Token(Token = "0x4010A59")]
	[FieldOffset(Offset = "0x4C")]
	private ChummyRequest m_RequestInfo;

	[Token(Token = "0x4010A5A")]
	[FieldOffset(Offset = "0x50")]
	private UIModelChummy m_ModelChummy;

	[Token(Token = "0x4010A5B")]
	[FieldOffset(Offset = "0x58")]
	private ulong m_AccountId;

	[Token(Token = "0x4010A5C")]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsSameRegion;

	[Token(Token = "0x6011F45")]
	[Address(RVA = "0x1C1AB04", Offset = "0x1C1AB04", VA = "0x1C1AB04")]
	public UITrainingCampMsgCheckWndController()
	{
	}

	[Token(Token = "0x6011F46")]
	[Address(RVA = "0x1C1AB0C", Offset = "0x1C1AB0C", VA = "0x1C1AB0C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011F47")]
	[Address(RVA = "0x1C1ABB0", Offset = "0x1C1ABB0", VA = "0x1C1ABB0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011F48")]
	[Address(RVA = "0x1C1AF4C", Offset = "0x1C1AF4C", VA = "0x1C1AF4C")]
	public void SetUIData(ChummyRequest reInfo, string CDNUrl)
	{
	}

	[Token(Token = "0x6011F49")]
	[Address(RVA = "0x1C1B584", Offset = "0x1C1B584", VA = "0x1C1B584")]
	public void SetUIData(ulong id, string nickname, bool sameRegion, string CDNUrl)
	{
	}

	[Token(Token = "0x6011F4A")]
	[Address(RVA = "0x1C1BB58", Offset = "0x1C1BB58", VA = "0x1C1BB58")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x6011F4B")]
	[Address(RVA = "0x1C1BBBC", Offset = "0x1C1BBBC", VA = "0x1C1BBBC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6011F4C")]
	[Address(RVA = "0x1C1BC20", Offset = "0x1C1BC20", VA = "0x1C1BC20")]
	private void OnClickAccept()
	{
	}

	[Token(Token = "0x6011F4D")]
	[Address(RVA = "0x1C1BCDC", Offset = "0x1C1BCDC", VA = "0x1C1BCDC")]
	private void OnClickReject()
	{
	}

	[Token(Token = "0x6011F4E")]
	[Address(RVA = "0x1C1BD98", Offset = "0x1C1BD98", VA = "0x1C1BD98")]
	private void OnClickConfirm()
	{
	}

	[Token(Token = "0x6011F4F")]
	[Address(RVA = "0x1C1C040", Offset = "0x1C1C040", VA = "0x1C1C040")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011F50")]
	[Address(RVA = "0x1C1C048", Offset = "0x1C1C048", VA = "0x1C1C048")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
