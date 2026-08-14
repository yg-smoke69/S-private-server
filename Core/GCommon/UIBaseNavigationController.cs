using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004122")]
public class UIBaseNavigationController : UIBaseController
{
	[Token(Token = "0x401B5B4")]
	[FieldOffset(Offset = "0x28")]
	protected UINavigationData m_NavigationData;

	[Token(Token = "0x401B5B5")]
	[FieldOffset(Offset = "0x2C")]
	protected bool m_IsRoot;

	[Token(Token = "0x401B5B6")]
	[FieldOffset(Offset = "0x2D")]
	protected bool m_IsNavigationShowed;

	[Token(Token = "0x401B5B7")]
	[FieldOffset(Offset = "0x30")]
	protected List<UIPopupWindowController> m_PopupWindows;

	[Token(Token = "0x17001D50")]
	public bool IsRoot
	{
		[Token(Token = "0x601A9BD")]
		[Address(RVA = "0x2C95B34", Offset = "0x2C95B34", VA = "0x2C95B34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001D51")]
	public UINavigationData NavigationData
	{
		[Token(Token = "0x601A9BE")]
		[Address(RVA = "0x2C95B3C", Offset = "0x2C95B3C", VA = "0x2C95B3C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A9B9")]
	[Address(RVA = "0x2C955B8", Offset = "0x2C955B8", VA = "0x2C955B8")]
	public UIBaseNavigationController()
	{
	}

	[Token(Token = "0x601A9BA")]
	[Address(RVA = "0x2C95670", Offset = "0x2C95670", VA = "0x2C95670", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601A9BB")]
	[Address(RVA = "0x2C957A8", Offset = "0x2C957A8", VA = "0x2C957A8")]
	public void OnForceBlurBg()
	{
	}

	[Token(Token = "0x601A9BC")]
	[Address(RVA = "0x2C95B30", Offset = "0x2C95B30", VA = "0x2C95B30", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x601A9BF")]
	[Address(RVA = "0x2C95B44", Offset = "0x2C95B44", VA = "0x2C95B44", Slot = "31")]
	public virtual void OnNavigationShowed(UINavigationData navigationData, bool isRoot)
	{
	}

	[Token(Token = "0x601A9C0")]
	[Address(RVA = "0x2C95D5C", Offset = "0x2C95D5C", VA = "0x2C95D5C", Slot = "32")]
	public virtual void OnNavigationClosed()
	{
	}

	[Token(Token = "0x601A9C1")]
	[Address(RVA = "0x2C95F68", Offset = "0x2C95F68", VA = "0x2C95F68")]
	public void ShowPopupWindow(UIPopupWindowController popupWindow)
	{
	}

	[Token(Token = "0x601A9C2")]
	[Address(RVA = "0x2C96238", Offset = "0x2C96238", VA = "0x2C96238")]
	public List<UIPopupWindowController> GetPopupWindows()
	{
		return null;
	}

	[Token(Token = "0x601A9C3")]
	[Address(RVA = "0x2C96240", Offset = "0x2C96240", VA = "0x2C96240")]
	public void OnPopupWindowDepthIncrease(UIPopupWindowController popupWindow, uint increaseDepth)
	{
	}

	[Token(Token = "0x601A9C4")]
	[Address(RVA = "0x2C963C4", Offset = "0x2C963C4", VA = "0x2C963C4")]
	public void OnPopupWindowClose(UIPopupWindowController popupWindow)
	{
	}

	[Token(Token = "0x601A9C5")]
	[Address(RVA = "0x2C96458", Offset = "0x2C96458", VA = "0x2C96458", Slot = "33")]
	protected virtual void OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x601A9C6")]
	[Address(RVA = "0x2C96540", Offset = "0x2C96540", VA = "0x2C96540")]
	public void CloseAllPopupWindows()
	{
	}

	[Token(Token = "0x601A9C7")]
	[Address(RVA = "0x2C966F0", Offset = "0x2C966F0", VA = "0x2C966F0")]
	public void ClosePopupWindowsByType(Type popupType)
	{
	}

	[Token(Token = "0x601A9C8")]
	[Address(RVA = "0x2C9682C", Offset = "0x2C9682C", VA = "0x2C9682C")]
	public UIPopupWindowController TopPopupWindows()
	{
		return null;
	}

	[Token(Token = "0x601A9C9")]
	[Address(RVA = "0x2C96924", Offset = "0x2C96924", VA = "0x2C96924")]
	public bool HasGlassEnabledInPopupWindowList(UIPopupWindowController popupWnd)
	{
		return default(bool);
	}

	[Token(Token = "0x601A9CA")]
	[Address(RVA = "0x2C96B7C", Offset = "0x2C96B7C", VA = "0x2C96B7C", Slot = "34")]
	protected virtual bool IsCoveredByPopupWnd()
	{
		return default(bool);
	}

	[Token(Token = "0x601A9CB")]
	[Address(RVA = "0x2C96C5C", Offset = "0x2C96C5C", VA = "0x2C96C5C", Slot = "15")]
	protected override void OnUIClose()
	{
	}
}
