using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002974")]
public class UIManualContentBaseController : UIBaseController
{
	[Token(Token = "0x400FF63")]
	[FieldOffset(Offset = "0x28")]
	protected int[] m_LocationIds;

	[Token(Token = "0x400FF64")]
	[FieldOffset(Offset = "0x2C")]
	protected int m_CurPage;

	[Token(Token = "0x400FF65")]
	[FieldOffset(Offset = "0x30")]
	protected int m_MaxPage;

	[Token(Token = "0x400FF66")]
	protected const int MAX_CONFIG_PAGE = 100;

	[Token(Token = "0x400FF67")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<uint, string> m_UrlTypeDict;

	[Token(Token = "0x400FF68")]
	private const string WEB_URL_FORMAT = "{0}manual/{1}?eventId={2}&lang={3}";

	[Token(Token = "0x400FF69")]
	[FieldOffset(Offset = "0x38")]
	private UIManualDataBase m_BaseData;

	[Token(Token = "0x60109F1")]
	[Address(RVA = "0x2270C08", Offset = "0x2270C08", VA = "0x2270C08")]
	public UIManualContentBaseController()
	{
	}

	[Token(Token = "0x60109F2")]
	[Address(RVA = "0x2270E44", Offset = "0x2270E44", VA = "0x2270E44", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60109F3")]
	[Address(RVA = "0x2271074", Offset = "0x2271074", VA = "0x2271074", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60109F4")]
	[Address(RVA = "0x2270F08", Offset = "0x2270F08", VA = "0x2270F08")]
	protected void AdjustWidgtDimFullScreen(UIWidget widget)
	{
	}

	[Token(Token = "0x60109F5")]
	[Address(RVA = "0x22710EC", Offset = "0x22710EC", VA = "0x22710EC", Slot = "31")]
	public virtual void SetData(UIManualDataBase data)
	{
	}

	[Token(Token = "0x60109F6")]
	[Address(RVA = "0x2271164", Offset = "0x2271164", VA = "0x2271164", Slot = "32")]
	public virtual void ClearData()
	{
	}

	[Token(Token = "0x60109F7")]
	[Address(RVA = "0x22711CC", Offset = "0x22711CC", VA = "0x22711CC", Slot = "33")]
	public virtual void RefreshView()
	{
	}

	[Token(Token = "0x60109F8")]
	[Address(RVA = "0x22712A8", Offset = "0x22712A8", VA = "0x22712A8")]
	public void GotoWebView(uint eventId, int eventType)
	{
	}

	[Token(Token = "0x60109F9")]
	[Address(RVA = "0x2271870", Offset = "0x2271870", VA = "0x2271870")]
	protected void OnClickPrevPage()
	{
	}

	[Token(Token = "0x60109FA")]
	[Address(RVA = "0x2271AF0", Offset = "0x2271AF0", VA = "0x2271AF0")]
	protected void OnClickNextPage()
	{
	}

	[Token(Token = "0x60109FB")]
	[Address(RVA = "0x2271D74", Offset = "0x2271D74", VA = "0x2271D74", Slot = "34")]
	protected virtual int GetMaxPage()
	{
		return default(int);
	}

	[Token(Token = "0x60109FC")]
	[Address(RVA = "0x2271DCC", Offset = "0x2271DCC", VA = "0x2271DCC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60109FD")]
	[Address(RVA = "0x2271DD4", Offset = "0x2271DD4", VA = "0x2271DD4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
