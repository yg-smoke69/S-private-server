using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002B80")]
public class UITrainingCampSideListController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x4010A74")]
	[FieldOffset(Offset = "0x48")]
	private UITrainingCampSideListView m_View;

	[Token(Token = "0x4010A75")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelChummy m_ModelChummy;

	[Token(Token = "0x4010A76")]
	[FieldOffset(Offset = "0x50")]
	private Tab m_Tab;

	[Token(Token = "0x4010A77")]
	[FieldOffset(Offset = "0x54")]
	private bool m_HasSearch;

	[Token(Token = "0x4010A78")]
	[FieldOffset(Offset = "0x58")]
	private ulong m_LastRefreshTime;

	[Token(Token = "0x6011F7B")]
	[Address(RVA = "0x1C20F50", Offset = "0x1C20F50", VA = "0x1C20F50")]
	public UITrainingCampSideListController()
	{
	}

	[Token(Token = "0x6011F7C")]
	[Address(RVA = "0x1C20F58", Offset = "0x1C20F58", VA = "0x1C20F58")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011F7D")]
	[Address(RVA = "0x1C20FFC", Offset = "0x1C20FFC", VA = "0x1C20FFC", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6011F7E")]
	[Address(RVA = "0x1C21054", Offset = "0x1C21054", VA = "0x1C21054", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011F7F")]
	[Address(RVA = "0x1C226E8", Offset = "0x1C226E8", VA = "0x1C226E8", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011F80")]
	[Address(RVA = "0x1C22C6C", Offset = "0x1C22C6C", VA = "0x1C22C6C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011F81")]
	[Address(RVA = "0x1C22D24", Offset = "0x1C22D24", VA = "0x1C22D24", Slot = "48")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6011F82")]
	[Address(RVA = "0x1C22E1C", Offset = "0x1C22E1C", VA = "0x1C22E1C", Slot = "49")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6011F83")]
	[Address(RVA = "0x1C21960", Offset = "0x1C21960", VA = "0x1C21960")]
	private void RefreshList(Tab tab)
	{
	}

	[Token(Token = "0x6011F84")]
	[Address(RVA = "0x1C227FC", Offset = "0x1C227FC", VA = "0x1C227FC")]
	private void RefreshRecommendList()
	{
	}

	[Token(Token = "0x6011F85")]
	[Address(RVA = "0x1C22E98", Offset = "0x1C22E98", VA = "0x1C22E98")]
	private void OnRecruitBtnClick()
	{
	}

	[Token(Token = "0x6011F86")]
	[Address(RVA = "0x1C21734", Offset = "0x1C21734", VA = "0x1C21734")]
	private void OnSelectRecommendTab()
	{
	}

	[Token(Token = "0x6011F87")]
	[Address(RVA = "0x1C2307C", Offset = "0x1C2307C", VA = "0x1C2307C")]
	private void OnSelectFriendTab()
	{
	}

	[Token(Token = "0x6011F88")]
	[Address(RVA = "0x1C21850", Offset = "0x1C21850", VA = "0x1C21850")]
	private void UpdateRefreshState(bool inCD = false)
	{
	}

	[Token(Token = "0x6011F89")]
	[Address(RVA = "0x1C230F4", Offset = "0x1C230F4", VA = "0x1C230F4")]
	private void OnClickRefreshBtn()
	{
	}

	[Token(Token = "0x6011F8A")]
	[Address(RVA = "0x1C235D4", Offset = "0x1C235D4", VA = "0x1C235D4")]
	private void OnSearchBtnClick()
	{
	}

	[Token(Token = "0x6011F8B")]
	[Address(RVA = "0x1C236E8", Offset = "0x1C236E8", VA = "0x1C236E8")]
	private void OnInputSubmit()
	{
	}

	[Token(Token = "0x6011F8C")]
	[Address(RVA = "0x1C23AF0", Offset = "0x1C23AF0", VA = "0x1C23AF0")]
	private void OnSearchInputChange()
	{
	}

	[Token(Token = "0x6011F8D")]
	[Address(RVA = "0x1C23C00", Offset = "0x1C23C00", VA = "0x1C23C00")]
	private void OnSearchInputGetFocus()
	{
	}

	[Token(Token = "0x6011F8E")]
	[Address(RVA = "0x1C23C68", Offset = "0x1C23C68", VA = "0x1C23C68")]
	public void CheckTrainingCampGuide(object[] data)
	{
	}

	[Token(Token = "0x6011F8F")]
	[Address(RVA = "0x1C23FC8", Offset = "0x1C23FC8", VA = "0x1C23FC8")]
	private void _003COnClickRefreshBtn_003Em__0()
	{
	}

	[Token(Token = "0x6011F90")]
	[Address(RVA = "0x1C23FD0", Offset = "0x1C23FD0", VA = "0x1C23FD0")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6011F91")]
	[Address(RVA = "0x1C23FD8", Offset = "0x1C23FD8", VA = "0x1C23FD8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
