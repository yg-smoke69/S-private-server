using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002308")]
public class UIRulePopMenuSettingController : UIBaseController, _Attribute
{
	[Token(Token = "0x400DA8C")]
	[FieldOffset(Offset = "0x28")]
	private UIRulePopMenuSettingView m_View;

	[Token(Token = "0x400DA8D")]
	[FieldOffset(Offset = "0x2C")]
	public PopMenuRuleSetting Data;

	[Token(Token = "0x400DA8E")]
	[FieldOffset(Offset = "0x30")]
	public Action<object> SelectItemCallback;

	[Token(Token = "0x400DA8F")]
	[FieldOffset(Offset = "0x34")]
	private UIPopMenuSmallControler m_PopMenu;

	[Token(Token = "0x400DA90")]
	[FieldOffset(Offset = "0x38")]
	private List<PopMenuData> m_PopMenuList;

	[Token(Token = "0x400DA91")]
	[FieldOffset(Offset = "0x3C")]
	private string m_CurrentSelection;

	[Token(Token = "0x400DA92")]
	[FieldOffset(Offset = "0x40")]
	public Action OnDataChanged;

	[Token(Token = "0x600C180")]
	[Address(RVA = "0x2BF79CC", Offset = "0x2BF79CC", VA = "0x2BF79CC")]
	public UIRulePopMenuSettingController()
	{
	}

	[Token(Token = "0x600C181")]
	[Address(RVA = "0x2BF7A84", Offset = "0x2BF7A84", VA = "0x2BF7A84")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C182")]
	[Address(RVA = "0x2BF7B2C", Offset = "0x2BF7B2C", VA = "0x2BF7B2C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C183")]
	[Address(RVA = "0x2BF7D14", Offset = "0x2BF7D14", VA = "0x2BF7D14", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C184")]
	[Address(RVA = "0x2BF7E48", Offset = "0x2BF7E48", VA = "0x2BF7E48")]
	public void Init(PopMenuRuleSetting data)
	{
	}

	[Token(Token = "0x600C185")]
	[Address(RVA = "0x2BF83E4", Offset = "0x2BF83E4", VA = "0x2BF83E4", Slot = "31")]
	public void Reset()
	{
	}

	[Token(Token = "0x600C186")]
	[Address(RVA = "0x2BF87D4", Offset = "0x2BF87D4", VA = "0x2BF87D4")]
	private void GeneratePopList()
	{
	}

	[Token(Token = "0x600C187")]
	[Address(RVA = "0x2BF8B24", Offset = "0x2BF8B24", VA = "0x2BF8B24")]
	private void OnPopMenuSelected(object[] data)
	{
	}

	[Token(Token = "0x600C188")]
	[Address(RVA = "0x2BF8710", Offset = "0x2BF8710", VA = "0x2BF8710")]
	private void SetValue(int newValue)
	{
	}

	[Token(Token = "0x600C189")]
	[Address(RVA = "0x2BF8CD0", Offset = "0x2BF8CD0", VA = "0x2BF8CD0")]
	private bool _003CInit_003Em__0(PopMenuRuleSetting.Item item)
	{
		return default(bool);
	}

	[Token(Token = "0x600C18A")]
	[Address(RVA = "0x2BF8D1C", Offset = "0x2BF8D1C", VA = "0x2BF8D1C")]
	private bool _003CReset_003Em__1(PopMenuRuleSetting.Item item)
	{
		return default(bool);
	}

	[Token(Token = "0x600C18B")]
	[Address(RVA = "0x2BF8D68", Offset = "0x2BF8D68", VA = "0x2BF8D68")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C18C")]
	[Address(RVA = "0x2BF8D70", Offset = "0x2BF8D70", VA = "0x2BF8D70")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
