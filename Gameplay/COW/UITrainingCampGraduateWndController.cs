using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002B77")]
internal class UITrainingCampGraduateWndController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x4010A49")]
	[FieldOffset(Offset = "0x48")]
	private UITrainingCampGraduateWndView m_View;

	[Token(Token = "0x4010A4A")]
	[FieldOffset(Offset = "0x50")]
	private ulong m_AccountId;

	[Token(Token = "0x4010A4B")]
	[FieldOffset(Offset = "0x58")]
	private List<BaseItemInfo> m_AwardList;

	[Token(Token = "0x4010A4C")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_HasAward;

	[Token(Token = "0x4010A4D")]
	[FieldOffset(Offset = "0x60")]
	private UIModelChummy m_ModelChummy;

	[Token(Token = "0x4010A4E")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<AwardDesc, BaseItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6011F1D")]
	[Address(RVA = "0x2B07BF8", Offset = "0x2B07BF8", VA = "0x2B07BF8")]
	public UITrainingCampGraduateWndController()
	{
	}

	[Token(Token = "0x6011F1E")]
	[Address(RVA = "0x2B07C00", Offset = "0x2B07C00", VA = "0x2B07C00")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011F1F")]
	[Address(RVA = "0x2B07CA4", Offset = "0x2B07CA4", VA = "0x2B07CA4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011F20")]
	[Address(RVA = "0x2B07EF4", Offset = "0x2B07EF4", VA = "0x2B07EF4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6011F21")]
	[Address(RVA = "0x2B07F7C", Offset = "0x2B07F7C", VA = "0x2B07F7C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6011F22")]
	[Address(RVA = "0x2B080EC", Offset = "0x2B080EC", VA = "0x2B080EC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011F23")]
	[Address(RVA = "0x2B08150", Offset = "0x2B08150", VA = "0x2B08150", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011F24")]
	[Address(RVA = "0x2B08A18", Offset = "0x2B08A18", VA = "0x2B08A18", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011F25")]
	[Address(RVA = "0x2B08AAC", Offset = "0x2B08AAC", VA = "0x2B08AAC")]
	public void SetViewData()
	{
	}

	[Token(Token = "0x6011F26")]
	[Address(RVA = "0x2B054FC", Offset = "0x2B054FC", VA = "0x2B054FC")]
	public void SetAccountId(ulong id)
	{
	}

	[Token(Token = "0x6011F27")]
	[Address(RVA = "0x2B0821C", Offset = "0x2B0821C", VA = "0x2B0821C")]
	private void RefreshAward()
	{
	}

	[Token(Token = "0x6011F28")]
	[Address(RVA = "0x2B08B00", Offset = "0x2B08B00", VA = "0x2B08B00")]
	private void OnMaskClick()
	{
	}

	[Token(Token = "0x6011F29")]
	[Address(RVA = "0x2B08B64", Offset = "0x2B08B64", VA = "0x2B08B64")]
	private void OnConfirmBtnClick()
	{
	}

	[Token(Token = "0x6011F2A")]
	[Address(RVA = "0x2B08BC8", Offset = "0x2B08BC8", VA = "0x2B08BC8")]
	private static BaseItemInfo _003CRefreshAward_003Em__0(AwardDesc item)
	{
		return null;
	}

	[Token(Token = "0x6011F2B")]
	[Address(RVA = "0x2B08C4C", Offset = "0x2B08C4C", VA = "0x2B08C4C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011F2C")]
	[Address(RVA = "0x2B08C54", Offset = "0x2B08C54", VA = "0x2B08C54")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6011F2D")]
	[Address(RVA = "0x2B08C5C", Offset = "0x2B08C5C", VA = "0x2B08C5C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6011F2E")]
	[Address(RVA = "0x2B08C64", Offset = "0x2B08C64", VA = "0x2B08C64")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
