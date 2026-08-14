using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002A92")]
internal class UIProfileCreditScoreHistoryController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x40105AF")]
	[FieldOffset(Offset = "0x48")]
	private UIProfileCreditScoreHistoryView m_View;

	[Token(Token = "0x40105B0")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelCredit m_Model;

	[Token(Token = "0x40105B1")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<CreditScoreChangeInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6011602")]
	[Address(RVA = "0x16D2000", Offset = "0x16D2000", VA = "0x16D2000")]
	public UIProfileCreditScoreHistoryController()
	{
	}

	[Token(Token = "0x6011603")]
	[Address(RVA = "0x16D2008", Offset = "0x16D2008", VA = "0x16D2008")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011604")]
	[Address(RVA = "0x16D20AC", Offset = "0x16D20AC", VA = "0x16D20AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011605")]
	[Address(RVA = "0x16D2280", Offset = "0x16D2280", VA = "0x16D2280", Slot = "31")]
	public override string Rule()
	{
		return null;
	}

	[Token(Token = "0x6011606")]
	[Address(RVA = "0x16D2324", Offset = "0x16D2324", VA = "0x16D2324", Slot = "32")]
	public override bool OverrideRuleBtnClick()
	{
		return default(bool);
	}

	[Token(Token = "0x6011607")]
	[Address(RVA = "0x16D24A0", Offset = "0x16D24A0", VA = "0x16D24A0")]
	private void SetUIData(CSGetCreditScoreChangeInfoRes scoreChangeInfo)
	{
	}

	[Token(Token = "0x6011608")]
	[Address(RVA = "0x16D272C", Offset = "0x16D272C", VA = "0x16D272C", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011609")]
	[Address(RVA = "0x16D28DC", Offset = "0x16D28DC", VA = "0x16D28DC", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601160A")]
	[Address(RVA = "0x16D2970", Offset = "0x16D2970", VA = "0x16D2970", Slot = "48")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x601160B")]
	[Address(RVA = "0x16D2A68", Offset = "0x16D2A68", VA = "0x16D2A68", Slot = "49")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x601160C")]
	[Address(RVA = "0x16D2AE4", Offset = "0x16D2AE4", VA = "0x16D2AE4")]
	private static int _003CSetUIData_003Em__0(CreditScoreChangeInfo a, CreditScoreChangeInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x601160D")]
	[Address(RVA = "0x16D2B68", Offset = "0x16D2B68", VA = "0x16D2B68")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601160E")]
	[Address(RVA = "0x16D2B70", Offset = "0x16D2B70", VA = "0x16D2B70")]
	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}

	[Token(Token = "0x601160F")]
	[Address(RVA = "0x16D2B78", Offset = "0x16D2B78", VA = "0x16D2B78")]
	public bool _003C_003EiFixBaseProxy_OverrideRuleBtnClick()
	{
		return default(bool);
	}
}
