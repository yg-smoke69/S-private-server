using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002945")]
public class UILobbyOptionalDownloaderController : UIBaseController, _Attribute
{
	[Token(Token = "0x400FE65")]
	private const float CIRCLE_SPEED = 0.2f;

	[Token(Token = "0x400FE66")]
	[FieldOffset(Offset = "0x28")]
	private UIModelOptionalDownload m_Model;

	[Token(Token = "0x400FE67")]
	[FieldOffset(Offset = "0x2C")]
	private UILobbyOptionalDownloaderView m_View;

	[Token(Token = "0x400FE68")]
	[FieldOffset(Offset = "0x30")]
	private Queue<DownLoadTipsInfo> m_TipsQueue;

	[Token(Token = "0x400FE69")]
	[FieldOffset(Offset = "0x34")]
	private bool m_isShowTips;

	[Token(Token = "0x400FE6A")]
	[FieldOffset(Offset = "0x35")]
	private bool m_ContentShow;

	[Token(Token = "0x400FE6B")]
	[FieldOffset(Offset = "0x36")]
	private bool m_NeedCheckTips;

	[Token(Token = "0x400FE6C")]
	[FieldOffset(Offset = "0x38")]
	private UILobbyOptionalTipsWndController m_TipsWndCtrl;

	[Token(Token = "0x400FE6D")]
	[FieldOffset(Offset = "0x3C")]
	private EDownloadContextState lastMode;

	[Token(Token = "0x60107A6")]
	[Address(RVA = "0x1CAE524", Offset = "0x1CAE524", VA = "0x1CAE524")]
	public UILobbyOptionalDownloaderController()
	{
	}

	[Token(Token = "0x60107A7")]
	[Address(RVA = "0x1CAE5E4", Offset = "0x1CAE5E4", VA = "0x1CAE5E4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60107A8")]
	[Address(RVA = "0x1CAE68C", Offset = "0x1CAE68C", VA = "0x1CAE68C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60107A9")]
	[Address(RVA = "0x1CAEC9C", Offset = "0x1CAEC9C", VA = "0x1CAEC9C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60107AA")]
	[Address(RVA = "0x1CAEB50", Offset = "0x1CAEB50", VA = "0x1CAEB50")]
	public void UpdateContentVisible(bool is_visible)
	{
	}

	[Token(Token = "0x60107AB")]
	[Address(RVA = "0x1CAEE5C", Offset = "0x1CAEE5C", VA = "0x1CAEE5C")]
	private void Update()
	{
	}

	[Token(Token = "0x60107AC")]
	[Address(RVA = "0x1CAEFA0", Offset = "0x1CAEFA0", VA = "0x1CAEFA0")]
	private void OnControlBtnClick()
	{
	}

	[Token(Token = "0x60107AD")]
	[Address(RVA = "0x1CAF1AC", Offset = "0x1CAF1AC", VA = "0x1CAF1AC")]
	private void OnTipsClose(object[] data)
	{
	}

	[Token(Token = "0x60107AE")]
	[Address(RVA = "0x1CAF210", Offset = "0x1CAF210", VA = "0x1CAF210")]
	private void OnFlyInNotify(object[] data)
	{
	}

	[Token(Token = "0x60107AF")]
	[Address(RVA = "0x1CAFA94", Offset = "0x1CAFA94", VA = "0x1CAFA94")]
	private void OnCentreVisibleChange(object[] data)
	{
	}

	[Token(Token = "0x60107B0")]
	[Address(RVA = "0x1CAFB20", Offset = "0x1CAFB20", VA = "0x1CAFB20", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60107B1")]
	[Address(RVA = "0x1CB0060", Offset = "0x1CB0060", VA = "0x1CB0060")]
	private void ShowCheckAutoDownloadTips(bool auto_download)
	{
	}

	[Token(Token = "0x60107B2")]
	[Address(RVA = "0x1CAFF50", Offset = "0x1CAFF50", VA = "0x1CAFF50")]
	private void DownloadFinished(uint OptionalReDefId)
	{
	}

	[Token(Token = "0x60107B3")]
	[Address(RVA = "0x1CAFFD8", Offset = "0x1CAFFD8", VA = "0x1CAFFD8")]
	private void ErrorOccur(ResErrorCode errorCode)
	{
	}

	[Token(Token = "0x60107B4")]
	[Address(RVA = "0x1CB00E8", Offset = "0x1CB00E8", VA = "0x1CB00E8")]
	private UILobbyOptionalTipsWndController GetTipsWnd()
	{
		return null;
	}

	[Token(Token = "0x60107B5")]
	[Address(RVA = "0x1CB0CE4", Offset = "0x1CB0CE4", VA = "0x1CB0CE4", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60107B6")]
	[Address(RVA = "0x1CB0D78", Offset = "0x1CB0D78", VA = "0x1CB0D78")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60107B7")]
	[Address(RVA = "0x1CB0D80", Offset = "0x1CB0D80", VA = "0x1CB0D80")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
