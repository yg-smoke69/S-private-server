using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002946")]
public class UILobbyOptionalTipsWndController : UIBaseController
{
	[Token(Token = "0x2002947")]
	private sealed class _003CNavigationGoposInit_003Ec__AnonStorey0
	{
		[Token(Token = "0x400FE72")]
		[FieldOffset(Offset = "0x8")]
		internal uint gopos;

		[Token(Token = "0x400FE73")]
		[FieldOffset(Offset = "0xC")]
		internal string subGopos;

		[Token(Token = "0x60107CD")]
		[Address(RVA = "0x1CB2384", Offset = "0x1CB2384", VA = "0x1CB2384")]
		public _003CNavigationGoposInit_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60107CE")]
		[Address(RVA = "0x1CB2528", Offset = "0x1CB2528", VA = "0x1CB2528")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400FE6E")]
	[FieldOffset(Offset = "0x28")]
	private UILobbyOptionalTipsWndView m_View;

	[Token(Token = "0x400FE6F")]
	[FieldOffset(Offset = "0x2C")]
	private Action m_ComfirmCallBack;

	[Token(Token = "0x400FE70")]
	private const float TIME_DELAY = 5f;

	[Token(Token = "0x400FE71")]
	[FieldOffset(Offset = "0x30")]
	private Action m_GoposCallBack;

	[Token(Token = "0x60107B8")]
	[Address(RVA = "0x1CB10D4", Offset = "0x1CB10D4", VA = "0x1CB10D4")]
	public UILobbyOptionalTipsWndController()
	{
	}

	[Token(Token = "0x60107B9")]
	[Address(RVA = "0x1CB1158", Offset = "0x1CB1158", VA = "0x1CB1158")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60107BA")]
	[Address(RVA = "0x1CB1200", Offset = "0x1CB1200", VA = "0x1CB1200", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60107BB")]
	[Address(RVA = "0x1CB1648", Offset = "0x1CB1648", VA = "0x1CB1648", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60107BC")]
	[Address(RVA = "0x1CB16AC", Offset = "0x1CB16AC", VA = "0x1CB16AC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60107BD")]
	[Address(RVA = "0x1CB0244", Offset = "0x1CB0244", VA = "0x1CB0244")]
	public void ShowCheckAutoDownloadTips(bool auto_download = false)
	{
	}

	[Token(Token = "0x60107BE")]
	[Address(RVA = "0x1CB1D34", Offset = "0x1CB1D34", VA = "0x1CB1D34")]
	private void OnControlBtnClick()
	{
	}

	[Token(Token = "0x60107BF")]
	[Address(RVA = "0x1CB1F40", Offset = "0x1CB1F40", VA = "0x1CB1F40")]
	private void TipsConfirmed()
	{
	}

	[Token(Token = "0x60107C0")]
	[Address(RVA = "0x1CB1FC0", Offset = "0x1CB1FC0", VA = "0x1CB1FC0")]
	private void GoposClick()
	{
	}

	[Token(Token = "0x60107C1")]
	[Address(RVA = "0x1CB150C", Offset = "0x1CB150C", VA = "0x1CB150C")]
	private void InitDownloadTips()
	{
	}

	[Token(Token = "0x60107C2")]
	[Address(RVA = "0x1CB058C", Offset = "0x1CB058C", VA = "0x1CB058C")]
	public void DownloadFinished(uint OptionalReDefId)
	{
	}

	[Token(Token = "0x60107C3")]
	[Address(RVA = "0x1CB1968", Offset = "0x1CB1968", VA = "0x1CB1968")]
	public void SetStyleBoxSize(DownloadTipsShowStyle showStyle)
	{
	}

	[Token(Token = "0x60107C4")]
	[Address(RVA = "0x1CB2178", Offset = "0x1CB2178", VA = "0x1CB2178")]
	private void ContentTipsShow(object[] data)
	{
	}

	[Token(Token = "0x60107C5")]
	[Address(RVA = "0x1CB203C", Offset = "0x1CB203C", VA = "0x1CB203C")]
	private void NavigationGoposInit(uint gopos, string subGopos)
	{
	}

	[Token(Token = "0x60107C6")]
	[Address(RVA = "0x1CB1B70", Offset = "0x1CB1B70", VA = "0x1CB1B70")]
	private void ShowNewTipsContentStyle()
	{
	}

	[Token(Token = "0x60107C7")]
	[Address(RVA = "0x1CB17C4", Offset = "0x1CB17C4", VA = "0x1CB17C4")]
	private void ShowNewTipsGoposContentStyle()
	{
	}

	[Token(Token = "0x60107C8")]
	[Address(RVA = "0x1CB0B68", Offset = "0x1CB0B68", VA = "0x1CB0B68")]
	public void ErrorOccur(ResErrorCode errorCode)
	{
	}

	[Token(Token = "0x60107C9")]
	[Address(RVA = "0x1CB238C", Offset = "0x1CB238C", VA = "0x1CB238C")]
	private string GetErrorLocKeyWithErrorCode(ResErrorCode error)
	{
		return null;
	}

	[Token(Token = "0x60107CA")]
	[Address(RVA = "0x1CB2510", Offset = "0x1CB2510", VA = "0x1CB2510")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60107CB")]
	[Address(RVA = "0x1CB2518", Offset = "0x1CB2518", VA = "0x1CB2518")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60107CC")]
	[Address(RVA = "0x1CB2520", Offset = "0x1CB2520", VA = "0x1CB2520")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
