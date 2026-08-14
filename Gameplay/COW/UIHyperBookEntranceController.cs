using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002148")]
public class UIHyperBookEntranceController : UIBaseController, _Attribute
{
	[Token(Token = "0x400D0F0")]
	private const string PROGRESS_ICON_NAME = "ProgressIcon";

	[Token(Token = "0x400D0F1")]
	private const string UNLOCK_ANIM_NAME = "VFX_UIHyperBookEntrance_lock01";

	[Token(Token = "0x400D0F2")]
	private const string UNLOCK_ANIM_PLAYER_PREF_FORMAT_KEY = "HYPERBOOK_ENTRANCE_UNLOCK_ANIM_{0}_{1}";

	[Token(Token = "0x400D0F3")]
	[FieldOffset(Offset = "0x28")]
	private uint m_BookID;

	[Token(Token = "0x400D0F4")]
	[FieldOffset(Offset = "0x2C")]
	private int m_Index;

	[Token(Token = "0x400D0F5")]
	[FieldOffset(Offset = "0x30")]
	private uint m_EntranceGuideDelayCall;

	[Token(Token = "0x400D0F6")]
	[FieldOffset(Offset = "0x34")]
	private UIHyperBookEntranceView m_View;

	[Token(Token = "0x400D0F7")]
	[FieldOffset(Offset = "0x38")]
	private UINewDownloadInfoController m_DownloadInfoController;

	[Token(Token = "0x400D0F8")]
	[FieldOffset(Offset = "0x3C")]
	private List<ResourceID> m_NeedDownloadRes;

	[Token(Token = "0x400D0F9")]
	[FieldOffset(Offset = "0x40")]
	private readonly List<Transform> m_ProgressUnlockIconList;

	[Token(Token = "0x600AF69")]
	[Address(RVA = "0x2959EF8", Offset = "0x2959EF8", VA = "0x2959EF8")]
	public UIHyperBookEntranceController()
	{
	}

	[Token(Token = "0x600AF6A")]
	[Address(RVA = "0x2959FE4", Offset = "0x2959FE4", VA = "0x2959FE4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AF6B")]
	[Address(RVA = "0x295A08C", Offset = "0x295A08C", VA = "0x295A08C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AF6C")]
	[Address(RVA = "0x295A3A0", Offset = "0x295A3A0", VA = "0x295A3A0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600AF6D")]
	[Address(RVA = "0x295A4E0", Offset = "0x295A4E0", VA = "0x295A4E0", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600AF6E")]
	[Address(RVA = "0x295A6F4", Offset = "0x295A6F4", VA = "0x295A6F4", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600AF6F")]
	[Address(RVA = "0x295A5AC", Offset = "0x295A5AC", VA = "0x295A5AC")]
	private void OnNotifyAssetRefresh()
	{
	}

	[Token(Token = "0x600AF70")]
	[Address(RVA = "0x295B070", Offset = "0x295B070", VA = "0x295B070")]
	private void OnDownloadBtnClick()
	{
	}

	[Token(Token = "0x600AF71")]
	[Address(RVA = "0x295B704", Offset = "0x295B704", VA = "0x295B704")]
	private void OnEntranceBtnClick()
	{
	}

	[Token(Token = "0x600AF72")]
	[Address(RVA = "0x295A26C", Offset = "0x295A26C", VA = "0x295A26C")]
	private void AddEventDelegate()
	{
	}

	[Token(Token = "0x600AF73")]
	[Address(RVA = "0x295BD8C", Offset = "0x295BD8C", VA = "0x295BD8C")]
	private void SetupDownloadCtrl()
	{
	}

	[Token(Token = "0x600AF74")]
	[Address(RVA = "0x295C284", Offset = "0x295C284", VA = "0x295C284")]
	private void SetupUnlockPageCount(int count)
	{
	}

	[Token(Token = "0x600AF75")]
	[Address(RVA = "0x295C4EC", Offset = "0x295C4EC", VA = "0x295C4EC")]
	private void LoadStaticContent()
	{
	}

	[Token(Token = "0x600AF76")]
	[Address(RVA = "0x295A788", Offset = "0x295A788", VA = "0x295A788")]
	private bool RefreshDynamicContent()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF77")]
	[Address(RVA = "0x295BB70", Offset = "0x295BB70", VA = "0x295BB70")]
	private void HideBook2DContent()
	{
	}

	[Token(Token = "0x600AF78")]
	[Address(RVA = "0x295D4B8", Offset = "0x295D4B8", VA = "0x295D4B8")]
	private bool GetIsUnlockAnimPlayed()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF79")]
	[Address(RVA = "0x295D8C8", Offset = "0x295D8C8", VA = "0x295D8C8")]
	private void SetUnlockAnimPlayed()
	{
	}

	[Token(Token = "0x600AF7A")]
	[Address(RVA = "0x295CDE0", Offset = "0x295CDE0", VA = "0x295CDE0")]
	private void SetLockIconBgAlpha(float scale)
	{
	}

	[Token(Token = "0x600AF7B")]
	[Address(RVA = "0x295D6C8", Offset = "0x295D6C8", VA = "0x295D6C8")]
	private void PlayUnlockAnim()
	{
	}

	[Token(Token = "0x600AF7C")]
	[Address(RVA = "0x295DED0", Offset = "0x295DED0", VA = "0x295DED0")]
	public void SetViewData(int index, uint bookItemID)
	{
	}

	[Token(Token = "0x600AF7D")]
	[Address(RVA = "0x295DF58", Offset = "0x295DF58", VA = "0x295DF58")]
	public bool RefreshContent()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF7E")]
	[Address(RVA = "0x295DFB8", Offset = "0x295DFB8", VA = "0x295DFB8")]
	public float GetUnlockAnimLength()
	{
		return default(float);
	}

	[Token(Token = "0x600AF7F")]
	[Address(RVA = "0x295E18C", Offset = "0x295E18C", VA = "0x295E18C")]
	public UIWidget GetBookEntranceWidget()
	{
		return null;
	}

	[Token(Token = "0x600AF80")]
	[Address(RVA = "0x295CF30", Offset = "0x295CF30", VA = "0x295CF30")]
	private bool IsBookEntranceTipsNeedShow()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF81")]
	[Address(RVA = "0x295DAD0", Offset = "0x295DAD0", VA = "0x295DAD0")]
	private void ShowEntranceGuide()
	{
	}

	[Token(Token = "0x600AF82")]
	[Address(RVA = "0x295E260", Offset = "0x295E260", VA = "0x295E260")]
	private void _003CShowEntranceGuide_003Em__0()
	{
	}

	[Token(Token = "0x600AF83")]
	[Address(RVA = "0x295E824", Offset = "0x295E824", VA = "0x295E824")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AF84")]
	[Address(RVA = "0x295E82C", Offset = "0x295E82C", VA = "0x295E82C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
