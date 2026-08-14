using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002593")]
public class UICommonRulesPopupController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400E88D")]
	[FieldOffset(Offset = "0x48")]
	protected UICommonRulesPopupView m_View;

	[Token(Token = "0x400E88E")]
	[FieldOffset(Offset = "0x4C")]
	private RuleType m_Type;

	[Token(Token = "0x400E88F")]
	[FieldOffset(Offset = "0x50")]
	private string m_InitSelectRule;

	[Token(Token = "0x400E890")]
	[FieldOffset(Offset = "0x54")]
	private object m_ExtralData;

	[Token(Token = "0x400E891")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_CurrentScrollViewObj;

	[Token(Token = "0x400E892")]
	[FieldOffset(Offset = "0x5C")]
	private List<RuleMapping> m_RuleDataList;

	[Token(Token = "0x400E893")]
	[FieldOffset(Offset = "0x60")]
	protected Transform m_TabItemParent;

	[Token(Token = "0x17001149")]
	public string InitSelectRule
	{
		[Token(Token = "0x600DBF8")]
		[Address(RVA = "0x1EB1654", Offset = "0x1EB1654", VA = "0x1EB1654")]
		set
		{
		}
	}

	[Token(Token = "0x1700114A")]
	public RuleType Type
	{
		[Token(Token = "0x600DBF9")]
		[Address(RVA = "0x1EB16B4", Offset = "0x1EB16B4", VA = "0x1EB16B4")]
		set
		{
		}
	}

	[Token(Token = "0x600DBF4")]
	[Address(RVA = "0x1EB11E0", Offset = "0x1EB11E0", VA = "0x1EB11E0")]
	public UICommonRulesPopupController()
	{
	}

	[Token(Token = "0x600DBF5")]
	[Address(RVA = "0x1EB1280", Offset = "0x1EB1280", VA = "0x1EB1280")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DBF6")]
	[Address(RVA = "0x1EB1324", Offset = "0x1EB1324", VA = "0x1EB1324", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DBF7")]
	[Address(RVA = "0x1EB1520", Offset = "0x1EB1520", VA = "0x1EB1520", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DBFA")]
	[Address(RVA = "0x1EB1A0C", Offset = "0x1EB1A0C", VA = "0x1EB1A0C")]
	public void SetViewDataBySelfRules(int mappingIndex = 0, int ruleIndex = 0)
	{
	}

	[Token(Token = "0x600DBFB")]
	[Address(RVA = "0x1EB17A0", Offset = "0x1EB17A0", VA = "0x1EB17A0")]
	private void SetViewData()
	{
	}

	[Token(Token = "0x600DBFC")]
	[Address(RVA = "0x1EB1B88", Offset = "0x1EB1B88", VA = "0x1EB1B88", Slot = "48")]
	public virtual List<RuleMapping>[] GetSelfRules()
	{
		return null;
	}

	[Token(Token = "0x600DBFD")]
	[Address(RVA = "0x1EB1BE0", Offset = "0x1EB1BE0", VA = "0x1EB1BE0", Slot = "49")]
	public virtual UICommonRulesTabItemController GetTabItemContrller()
	{
		return null;
	}

	[Token(Token = "0x600DBFE")]
	[Address(RVA = "0x1EB1CD4", Offset = "0x1EB1CD4", VA = "0x1EB1CD4")]
	private void OnSelectRule(object[] param)
	{
	}

	[Token(Token = "0x600DBFF")]
	[Address(RVA = "0x1EB23F0", Offset = "0x1EB23F0", VA = "0x1EB23F0", Slot = "50")]
	protected virtual void RuleSelectedCallback(RuleMapping rule)
	{
	}

	[Token(Token = "0x600DC00")]
	[Address(RVA = "0x1EB244C", Offset = "0x1EB244C", VA = "0x1EB244C")]
	protected UILabel GetContentLabel()
	{
		return null;
	}

	[Token(Token = "0x600DC01")]
	[Address(RVA = "0x1EB2560", Offset = "0x1EB2560", VA = "0x1EB2560", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600DC02")]
	[Address(RVA = "0x1EB25D4", Offset = "0x1EB25D4", VA = "0x1EB25D4", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600DC03")]
	[Address(RVA = "0x1EB2650", Offset = "0x1EB2650", VA = "0x1EB2650")]
	private bool _003CSetViewData_003Em__0(RuleMapping e)
	{
		return default(bool);
	}

	[Token(Token = "0x600DC04")]
	[Address(RVA = "0x1EB26F4", Offset = "0x1EB26F4", VA = "0x1EB26F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DC05")]
	[Address(RVA = "0x1EB26FC", Offset = "0x1EB26FC", VA = "0x1EB26FC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
