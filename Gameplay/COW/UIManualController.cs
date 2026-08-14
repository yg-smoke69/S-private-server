using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002975")]
public class UIManualController : UINavigationController, _Attribute
{
	[Token(Token = "0x400FF6A")]
	[FieldOffset(Offset = "0x68")]
	private UIManualView m_View;

	[Token(Token = "0x400FF6B")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelManual m_ModelManual;

	[Token(Token = "0x400FF6C")]
	[FieldOffset(Offset = "0x70")]
	private UIManualContentBaseController m_CurContent;

	[Token(Token = "0x400FF6D")]
	[FieldOffset(Offset = "0x74")]
	private Dictionary<int, UIManualContentBaseController> m_ContentDict;

	[Token(Token = "0x400FF6E")]
	[FieldOffset(Offset = "0x78")]
	private List<UISprite> m_AnimList;

	[Token(Token = "0x400FF6F")]
	[FieldOffset(Offset = "0x7C")]
	private int m_AnimIdx;

	[Token(Token = "0x400FF70")]
	[FieldOffset(Offset = "0x80")]
	private bool m_EnableAnim;

	[Token(Token = "0x400FF71")]
	[FieldOffset(Offset = "0x81")]
	private bool m_ReverseAnim;

	[Token(Token = "0x400FF72")]
	[FieldOffset(Offset = "0x84")]
	private uint m_AnimDelayCall;

	[Token(Token = "0x400FF73")]
	[FieldOffset(Offset = "0x88")]
	public UIManualMainTabController m_ManualTabCtrl;

	[Token(Token = "0x400FF74")]
	[FieldOffset(Offset = "0x8C")]
	private UIStandardDrawerTabController m_DrawerTabCtrl;

	[Token(Token = "0x60109FE")]
	[Address(RVA = "0x2271DDC", Offset = "0x2271DDC", VA = "0x2271DDC")]
	public UIManualController()
	{
	}

	[Token(Token = "0x60109FF")]
	[Address(RVA = "0x2271EC8", Offset = "0x2271EC8", VA = "0x2271EC8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010A00")]
	[Address(RVA = "0x2271F6C", Offset = "0x2271F6C", VA = "0x2271F6C", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010A01")]
	[Address(RVA = "0x2272254", Offset = "0x2272254", VA = "0x2272254", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010A02")]
	[Address(RVA = "0x22722E8", Offset = "0x22722E8", VA = "0x22722E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010A03")]
	[Address(RVA = "0x2272D00", Offset = "0x2272D00", VA = "0x2272D00", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010A04")]
	[Address(RVA = "0x2272ED4", Offset = "0x2272ED4", VA = "0x2272ED4")]
	private void UpdateAnim()
	{
	}

	[Token(Token = "0x6010A05")]
	[Address(RVA = "0x22721B4", Offset = "0x22721B4", VA = "0x22721B4")]
	private void TryRefreshScene()
	{
	}

	[Token(Token = "0x6010A06")]
	[Address(RVA = "0x2273248", Offset = "0x2273248", VA = "0x2273248")]
	public int GetActiveTabIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6010A07")]
	[Address(RVA = "0x22732C0", Offset = "0x22732C0", VA = "0x22732C0")]
	public void CreateContent(UIManualDataBase data)
	{
	}

	[Token(Token = "0x6010A08")]
	[Address(RVA = "0x22734F8", Offset = "0x22734F8", VA = "0x22734F8")]
	public UIManualContentBaseController OpenManualContent(EManual.EventType manualType)
	{
		return null;
	}

	[Token(Token = "0x6010A09")]
	[Address(RVA = "0x2272874", Offset = "0x2272874", VA = "0x2272874")]
	private void InitAnim()
	{
	}

	[Token(Token = "0x6010A0A")]
	[Address(RVA = "0x22737C8", Offset = "0x22737C8", VA = "0x22737C8")]
	public void PlayAnim(object[] parameters)
	{
	}

	[Token(Token = "0x6010A0B")]
	[Address(RVA = "0x2272F34", Offset = "0x2272F34", VA = "0x2272F34")]
	private void DoFlipAnim()
	{
	}

	[Token(Token = "0x6010A0C")]
	[Address(RVA = "0x2273914", Offset = "0x2273914", VA = "0x2273914", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x6010A0D")]
	[Address(RVA = "0x2273A30", Offset = "0x2273A30", VA = "0x2273A30", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x6010A0E")]
	[Address(RVA = "0x2273B4C", Offset = "0x2273B4C", VA = "0x2273B4C", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6010A0F")]
	[Address(RVA = "0x2273BD8", Offset = "0x2273BD8", VA = "0x2273BD8", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x6010A10")]
	[Address(RVA = "0x2272B9C", Offset = "0x2272B9C", VA = "0x2272B9C")]
	private void SetShareUIVisiable(bool v)
	{
	}

	[Token(Token = "0x6010A11")]
	[Address(RVA = "0x2273C3C", Offset = "0x2273C3C", VA = "0x2273C3C")]
	private void OnClickShare()
	{
	}

	[Token(Token = "0x6010A12")]
	[Address(RVA = "0x2273E68", Offset = "0x2273E68", VA = "0x2273E68")]
	private void OnClickMoreInfo()
	{
	}

	[Token(Token = "0x6010A13")]
	[Address(RVA = "0x22740B8", Offset = "0x22740B8", VA = "0x22740B8")]
	public void OnClickHelp()
	{
	}

	[Token(Token = "0x6010A14")]
	[Address(RVA = "0x2274228", Offset = "0x2274228", VA = "0x2274228")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010A15")]
	[Address(RVA = "0x2274230", Offset = "0x2274230", VA = "0x2274230")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6010A16")]
	[Address(RVA = "0x2274238", Offset = "0x2274238", VA = "0x2274238")]
	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x6010A17")]
	[Address(RVA = "0x2274240", Offset = "0x2274240", VA = "0x2274240")]
	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	[Token(Token = "0x6010A18")]
	[Address(RVA = "0x2274248", Offset = "0x2274248", VA = "0x2274248")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6010A19")]
	[Address(RVA = "0x2274250", Offset = "0x2274250", VA = "0x2274250")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
