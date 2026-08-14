using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004163")]
public class UIPopupWindowController : UIBaseController
{
	[Token(Token = "0x401B6FC")]
	[FieldOffset(Offset = "0x28")]
	protected UIBaseNavigationController m_NavigationController;

	[Token(Token = "0x401B6FD")]
	[FieldOffset(Offset = "0x2C")]
	protected List<UITweener> m_PopupTweener;

	[Token(Token = "0x401B6FE")]
	[FieldOffset(Offset = "0x30")]
	protected UIPanel m_MainPanel;

	[Token(Token = "0x401B6FF")]
	[FieldOffset(Offset = "0x34")]
	protected UIPanel[] m_ChildPanels;

	[Token(Token = "0x401B700")]
	[FieldOffset(Offset = "0x38")]
	public UIPopWindowFrameStyle m_frameStyle;

	[Token(Token = "0x401B701")]
	[FieldOffset(Offset = "0x3C")]
	protected UIPopupGlassBG m_Glass;

	[Token(Token = "0x401B702")]
	[FieldOffset(Offset = "0x40")]
	public UIGlassBGController GlassCtrl;

	[Token(Token = "0x401B703")]
	[FieldOffset(Offset = "0x44")]
	protected bool m_IsCoverPrePopWnd;

	[Token(Token = "0x401B704")]
	[FieldOffset(Offset = "0x45")]
	protected bool m_IsCoverFullscreen;

	[Token(Token = "0x601AB85")]
	[Address(RVA = "0x2BB9BA4", Offset = "0x2BB9BA4", VA = "0x2BB9BA4")]
	public UIPopupWindowController()
	{
	}

	[Token(Token = "0x601AB86")]
	[Address(RVA = "0x2BB9C30", Offset = "0x2BB9C30", VA = "0x2BB9C30", Slot = "31")]
	public virtual string Rule()
	{
		return null;
	}

	[Token(Token = "0x601AB87")]
	[Address(RVA = "0x2BB9CBC", Offset = "0x2BB9CBC", VA = "0x2BB9CBC", Slot = "32")]
	public virtual bool OverrideRuleBtnClick()
	{
		return default(bool);
	}

	[Token(Token = "0x601AB88")]
	[Address(RVA = "0x2BB9CC4", Offset = "0x2BB9CC4", VA = "0x2BB9CC4", Slot = "33")]
	public virtual string CustomTitle()
	{
		return null;
	}

	[Token(Token = "0x601AB89")]
	[Address(RVA = "0x2BB9D50", Offset = "0x2BB9D50", VA = "0x2BB9D50", Slot = "34")]
	public virtual int GlassDelay()
	{
		return default(int);
	}

	[Token(Token = "0x601AB8A")]
	[Address(RVA = "0x2BB9D58", Offset = "0x2BB9D58", VA = "0x2BB9D58", Slot = "35")]
	public virtual int MinGroupDepth()
	{
		return default(int);
	}

	[Token(Token = "0x601AB8B")]
	[Address(RVA = "0x2BB9D60", Offset = "0x2BB9D60", VA = "0x2BB9D60", Slot = "36")]
	protected virtual string AnimationConfogPath()
	{
		return null;
	}

	[Token(Token = "0x601AB8C")]
	[Address(RVA = "0x2BB9DBC", Offset = "0x2BB9DBC", VA = "0x2BB9DBC", Slot = "37")]
	protected virtual void OnTweenAnimationFinish()
	{
	}

	[Token(Token = "0x601AB8D")]
	[Address(RVA = "0x2BB9DC0", Offset = "0x2BB9DC0", VA = "0x2BB9DC0", Slot = "38")]
	protected virtual bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x601AB8E")]
	[Address(RVA = "0x2BB9DC8", Offset = "0x2BB9DC8", VA = "0x2BB9DC8")]
	public UIPopupWindowTopBtnController ShowCloseBtn(Callback action)
	{
		return null;
	}

	[Token(Token = "0x601AB8F")]
	[Address(RVA = "0x2BB9FB0", Offset = "0x2BB9FB0", VA = "0x2BB9FB0", Slot = "9")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x601AB90")]
	[Address(RVA = "0x2BBB204", Offset = "0x2BBB204", VA = "0x2BBB204")]
	public void InitDepth(int startDepth)
	{
	}

	[Token(Token = "0x601AB91")]
	[Address(RVA = "0x2BBB44C", Offset = "0x2BBB44C", VA = "0x2BBB44C", Slot = "39")]
	protected virtual void OnInitDepth()
	{
	}

	[Token(Token = "0x601AB92")]
	[Address(RVA = "0x2BBB450", Offset = "0x2BBB450", VA = "0x2BBB450")]
	public void SetTitleKey(string key)
	{
	}

	[Token(Token = "0x601AB93")]
	[Address(RVA = "0x2BBB50C", Offset = "0x2BBB50C", VA = "0x2BBB50C")]
	public void SetNavigationController(UIBaseNavigationController navigationController)
	{
	}

	[Token(Token = "0x601AB94")]
	[Address(RVA = "0x2BBA700", Offset = "0x2BBA700", VA = "0x2BBA700")]
	public void AddTweenByConfig(UIPanel mainPanel)
	{
	}

	[Token(Token = "0x601AB95")]
	[Address(RVA = "0x2BBB514", Offset = "0x2BBB514", VA = "0x2BBB514")]
	public void DisableTween()
	{
	}

	[Token(Token = "0x601AB96")]
	[Address(RVA = "0x2BBB6A0", Offset = "0x2BBB6A0", VA = "0x2BBB6A0")]
	public int GetMainPanelDepth()
	{
		return default(int);
	}

	[Token(Token = "0x601AB97")]
	[Address(RVA = "0x2BBB6CC", Offset = "0x2BBB6CC", VA = "0x2BBB6CC")]
	public int GetMaxPanelDepth()
	{
		return default(int);
	}

	[Token(Token = "0x601AB98")]
	[Address(RVA = "0x2BBB9F0", Offset = "0x2BBB9F0", VA = "0x2BBB9F0")]
	public void IncreasePanelDepth(uint incrementDepth)
	{
	}

	[Token(Token = "0x601AB99")]
	[Address(RVA = "0x2BBBB08", Offset = "0x2BBBB08", VA = "0x2BBBB08", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x601AB9A")]
	protected override T OpenChildController<T>(Transform parent, [Optional] Vector3 localPosition, EUIAnchor anchor = EUIAnchor.None, bool noCache = false)
	{
		return null;
	}

	[Token(Token = "0x601AB9B")]
	[Address(RVA = "0x2BBBDC8", Offset = "0x2BBBDC8", VA = "0x2BBBDC8", Slot = "12")]
	protected override void OnChildControllerOpenChildController()
	{
	}

	[Token(Token = "0x601AB9C")]
	[Address(RVA = "0x2BBBFA0", Offset = "0x2BBBFA0", VA = "0x2BBBFA0", Slot = "40")]
	public virtual bool ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x601AB9D")]
	[Address(RVA = "0x2BBBFA8", Offset = "0x2BBBFA8", VA = "0x2BBBFA8", Slot = "41")]
	public virtual bool IgnoreEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x601AB9E")]
	[Address(RVA = "0x2BBBFB0", Offset = "0x2BBBFB0", VA = "0x2BBBFB0", Slot = "42")]
	public virtual void EnterByReturn()
	{
	}

	[Token(Token = "0x601AB9F")]
	[Address(RVA = "0x2BBBFB4", Offset = "0x2BBBFB4", VA = "0x2BBBFB4")]
	public void SetColliderMaskAlpha(UISprite mask, float alpha = 0f)
	{
	}

	[Token(Token = "0x601ABA0")]
	[Address(RVA = "0x2BBC08C", Offset = "0x2BBC08C", VA = "0x2BBC08C")]
	public bool HasGlassEnabledInPopupWindowList()
	{
		return default(bool);
	}

	[Token(Token = "0x601ABA1")]
	[Address(RVA = "0x2BBC148", Offset = "0x2BBC148", VA = "0x2BBC148", Slot = "43")]
	public virtual void OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x601ABA2")]
	[Address(RVA = "0x2BBC14C", Offset = "0x2BBC14C", VA = "0x2BBC14C")]
	public bool IsCoverPrePopupWnd()
	{
		return default(bool);
	}

	[Token(Token = "0x601ABA3")]
	[Address(RVA = "0x2BBC16C", Offset = "0x2BBC16C", VA = "0x2BBC16C")]
	public bool IsCoveredByPopupWnd()
	{
		return default(bool);
	}

	[Token(Token = "0x601ABA4")]
	[Address(RVA = "0x2BBC3E0", Offset = "0x2BBC3E0", VA = "0x2BBC3E0")]
	public bool IsCoverFullscreen()
	{
		return default(bool);
	}

	[Token(Token = "0x601ABA5")]
	[Address(RVA = "0x2BBC400", Offset = "0x2BBC400", VA = "0x2BBC400", Slot = "44")]
	public virtual void OnNavigationBack()
	{
	}

	[Token(Token = "0x601ABA6")]
	[Address(RVA = "0x2BBC404", Offset = "0x2BBC404", VA = "0x2BBC404", Slot = "45")]
	public virtual void OnNavigationClosed()
	{
	}
}
