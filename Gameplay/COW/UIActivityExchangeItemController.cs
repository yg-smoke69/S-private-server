using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F58")]
public class UIActivityExchangeItemController : UIBaseController
{
	[Token(Token = "0x2001F59")]
	private enum OperateStatus
	{
		[Token(Token = "0x400C4FA")]
		None,
		[Token(Token = "0x400C4FB")]
		Exchange,
		[Token(Token = "0x400C4FC")]
		ExchangeNo,
		[Token(Token = "0x400C4FD")]
		ExchangeFinished
	}

	[Token(Token = "0x400C4F2")]
	[FieldOffset(Offset = "0x28")]
	private List<UIStandardItemMiniController> m_ConsumeItemUIs;

	[Token(Token = "0x400C4F3")]
	[FieldOffset(Offset = "0x2C")]
	private UIActivityExchangeItemView m_View;

	[Token(Token = "0x400C4F4")]
	[FieldOffset(Offset = "0x30")]
	private string UNLIMITED_STRING;

	[Token(Token = "0x400C4F5")]
	[FieldOffset(Offset = "0x34")]
	public int dragThresholdNum;

	[Token(Token = "0x400C4F6")]
	[FieldOffset(Offset = "0x38")]
	private OperateStatus m_OperateStatus;

	[Token(Token = "0x400C4F7")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C4F8")]
	[FieldOffset(Offset = "0x40")]
	private ClientActivityDesc m_Desc;

	[Token(Token = "0x6009B24")]
	[Address(RVA = "0x2FA64EC", Offset = "0x2FA64EC", VA = "0x2FA64EC")]
	public UIActivityExchangeItemController()
	{
	}

	[Token(Token = "0x6009B25")]
	[Address(RVA = "0x2FA65C0", Offset = "0x2FA65C0", VA = "0x2FA65C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009B26")]
	[Address(RVA = "0x2FA6664", Offset = "0x2FA6664", VA = "0x2FA6664")]
	public static ResourceID GetVFXResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009B27")]
	[Address(RVA = "0x2FA670C", Offset = "0x2FA670C", VA = "0x2FA670C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009B28")]
	[Address(RVA = "0x2FA6918", Offset = "0x2FA6918", VA = "0x2FA6918", Slot = "31")]
	protected virtual object CreateView()
	{
		return null;
	}

	[Token(Token = "0x6009B29")]
	[Address(RVA = "0x2FA69C4", Offset = "0x2FA69C4", VA = "0x2FA69C4")]
	public void SetData(ClientActivityDesc desc)
	{
	}

	[Token(Token = "0x6009B2A")]
	[Address(RVA = "0x2FA6B78", Offset = "0x2FA6B78", VA = "0x2FA6B78")]
	private void SetOperateButtonUI()
	{
	}

	[Token(Token = "0x6009B2B")]
	[Address(RVA = "0x2FA80E0", Offset = "0x2FA80E0", VA = "0x2FA80E0")]
	private void OnRedTipsOnOffClicked()
	{
	}

	[Token(Token = "0x6009B2C")]
	[Address(RVA = "0x2FA7790", Offset = "0x2FA7790", VA = "0x2FA7790")]
	private void CreateConsumeItems()
	{
	}

	[Token(Token = "0x6009B2D")]
	[Address(RVA = "0x2FA7CF0", Offset = "0x2FA7CF0", VA = "0x2FA7CF0")]
	private void CreateAwardItems(List<AwardDesc> awards)
	{
	}

	[Token(Token = "0x6009B2E")]
	[Address(RVA = "0x2FA850C", Offset = "0x2FA850C", VA = "0x2FA850C")]
	private void PlayBtnAnimation()
	{
	}

	[Token(Token = "0x6009B2F")]
	[Address(RVA = "0x2FA8684", Offset = "0x2FA8684", VA = "0x2FA8684")]
	private void OnOperate()
	{
	}

	[Token(Token = "0x6009B30")]
	[Address(RVA = "0x2FA8D38", Offset = "0x2FA8D38", VA = "0x2FA8D38")]
	public void Reload()
	{
	}

	[Token(Token = "0x6009B31")]
	[Address(RVA = "0x2FA82F8", Offset = "0x2FA82F8", VA = "0x2FA82F8")]
	public string CalcCount(BaseItemInfo data)
	{
		return null;
	}

	[Token(Token = "0x6009B32")]
	[Address(RVA = "0x2FA8F60", Offset = "0x2FA8F60", VA = "0x2FA8F60")]
	private void _003COnOperate_003Em__0()
	{
	}

	[Token(Token = "0x6009B33")]
	[Address(RVA = "0x2FA90DC", Offset = "0x2FA90DC", VA = "0x2FA90DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
