using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200258A")]
public class UICommonRewardSecondConfirmWndController : UIPopupWindowController
{
	[Token(Token = "0x400E83A")]
	[FieldOffset(Offset = "0x48")]
	private UICommonRewardSecondConfirmWndView m_View;

	[Token(Token = "0x400E83B")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_ConfirmAction;

	[Token(Token = "0x400E83C")]
	[FieldOffset(Offset = "0x50")]
	private Action m_CancelAction;

	[Token(Token = "0x600DB8A")]
	[Address(RVA = "0x2CE93F8", Offset = "0x2CE93F8", VA = "0x2CE93F8")]
	public UICommonRewardSecondConfirmWndController()
	{
	}

	[Token(Token = "0x600DB8B")]
	[Address(RVA = "0x2CE9400", Offset = "0x2CE9400", VA = "0x2CE9400")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DB8C")]
	[Address(RVA = "0x2CE94A4", Offset = "0x2CE94A4", VA = "0x2CE94A4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DB8D")]
	[Address(RVA = "0x2CE9674", Offset = "0x2CE9674", VA = "0x2CE9674")]
	protected void OnCancelClick()
	{
	}

	[Token(Token = "0x600DB8E")]
	[Address(RVA = "0x2CE96EC", Offset = "0x2CE96EC", VA = "0x2CE96EC")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x600DB8F")]
	[Address(RVA = "0x2CE9764", Offset = "0x2CE9764", VA = "0x2CE9764")]
	public void SetData(Dictionary<uint, long> returnIdNumDic, long returnCoinNum, long returnDiamondNum)
	{
	}

	[Token(Token = "0x600DB90")]
	[Address(RVA = "0x2CEA8B4", Offset = "0x2CEA8B4", VA = "0x2CEA8B4")]
	public void SetConfirmCallback(Action action)
	{
	}

	[Token(Token = "0x600DB91")]
	[Address(RVA = "0x2CEA914", Offset = "0x2CEA914", VA = "0x2CEA914")]
	public void SetCancelCallback(Action action)
	{
	}

	[Token(Token = "0x600DB92")]
	[Address(RVA = "0x2CEA974", Offset = "0x2CEA974", VA = "0x2CEA974")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
