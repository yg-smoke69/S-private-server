using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002307")]
public class UIRuleNumericSettingController : UIBaseController, _Attribute
{
	[Token(Token = "0x400DA89")]
	[FieldOffset(Offset = "0x28")]
	private UIRuleNumericSettingView m_View;

	[Token(Token = "0x400DA8A")]
	[FieldOffset(Offset = "0x2C")]
	public NumericRuleSetting Data;

	[Token(Token = "0x400DA8B")]
	[FieldOffset(Offset = "0x30")]
	public Action OnDataChanged;

	[Token(Token = "0x600C173")]
	[Address(RVA = "0x2BF66E0", Offset = "0x2BF66E0", VA = "0x2BF66E0")]
	public UIRuleNumericSettingController()
	{
	}

	[Token(Token = "0x600C174")]
	[Address(RVA = "0x2BF6764", Offset = "0x2BF6764", VA = "0x2BF6764")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C175")]
	[Address(RVA = "0x2BF680C", Offset = "0x2BF680C", VA = "0x2BF680C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C176")]
	[Address(RVA = "0x2BF33BC", Offset = "0x2BF33BC", VA = "0x2BF33BC")]
	public void Init(NumericRuleSetting data)
	{
	}

	[Token(Token = "0x600C177")]
	[Address(RVA = "0x2BF38FC", Offset = "0x2BF38FC", VA = "0x2BF38FC", Slot = "31")]
	public void Reset()
	{
	}

	[Token(Token = "0x600C178")]
	[Address(RVA = "0x2BF6E80", Offset = "0x2BF6E80", VA = "0x2BF6E80")]
	protected void OnClickPlusBtn()
	{
	}

	[Token(Token = "0x600C179")]
	[Address(RVA = "0x2BF7008", Offset = "0x2BF7008", VA = "0x2BF7008")]
	protected void OnClickSubBtn()
	{
	}

	[Token(Token = "0x600C17A")]
	[Address(RVA = "0x2BF7190", Offset = "0x2BF7190", VA = "0x2BF7190")]
	protected void OnClickMinBtn()
	{
	}

	[Token(Token = "0x600C17B")]
	[Address(RVA = "0x2BF7210", Offset = "0x2BF7210", VA = "0x2BF7210")]
	protected void OnClickMaxBtn()
	{
	}

	[Token(Token = "0x600C17C")]
	[Address(RVA = "0x2BF7290", Offset = "0x2BF7290", VA = "0x2BF7290")]
	protected void SetData()
	{
	}

	[Token(Token = "0x600C17D")]
	[Address(RVA = "0x2BF6B9C", Offset = "0x2BF6B9C", VA = "0x2BF6B9C")]
	protected void UpdateNumUI()
	{
	}

	[Token(Token = "0x600C17E")]
	[Address(RVA = "0x2BF6D30", Offset = "0x2BF6D30", VA = "0x2BF6D30")]
	private void SetValue(float newValue)
	{
	}

	[Token(Token = "0x600C17F")]
	[Address(RVA = "0x2BF74AC", Offset = "0x2BF74AC", VA = "0x2BF74AC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
