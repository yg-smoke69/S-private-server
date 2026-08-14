using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000C88")]
public class ItemEditAttributeUIDataHorizontalSelect : ItemEditAttributeUIData
{
	[Token(Token = "0x40066E5")]
	[FieldOffset(Offset = "0xC")]
	private List<string> m_OptionShowTxtKey;

	[Token(Token = "0x40066E6")]
	[FieldOffset(Offset = "0x10")]
	private List<int> m_OptionValue;

	[Token(Token = "0x40066E7")]
	[FieldOffset(Offset = "0x14")]
	private int m_CurUIValue;

	[Token(Token = "0x17000802")]
	public List<string> OptionShowTxtKey
	{
		[Token(Token = "0x6005FE5")]
		[Address(RVA = "0x31116BC", Offset = "0x31116BC", VA = "0x31116BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000803")]
	public List<int> OptionValue
	{
		[Token(Token = "0x6005FE6")]
		[Address(RVA = "0x31116C4", Offset = "0x31116C4", VA = "0x31116C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000804")]
	public int CurUIValue
	{
		[Token(Token = "0x6005FE7")]
		[Address(RVA = "0x31116CC", Offset = "0x31116CC", VA = "0x31116CC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005FE8")]
		[Address(RVA = "0x31116D4", Offset = "0x31116D4", VA = "0x31116D4")]
		private set
		{
		}
	}

	[Token(Token = "0x6005FE3")]
	[Address(RVA = "0x31114FC", Offset = "0x31114FC", VA = "0x31114FC")]
	public ItemEditAttributeUIDataHorizontalSelect()
	{
	}

	[Token(Token = "0x6005FE4")]
	[Address(RVA = "0x31116B4", Offset = "0x31116B4", VA = "0x31116B4", Slot = "4")]
	public override SceneEditItemAttributeUIType GetUIType()
	{
		return default(SceneEditItemAttributeUIType);
	}

	[Token(Token = "0x6005FE9")]
	[Address(RVA = "0x31115BC", Offset = "0x31115BC", VA = "0x31115BC")]
	public void ScriptObjectDataToUIData(string attributeTitleNameKey, List<string> optionShowTxtKey, List<int> optionValue, int defaultValue)
	{
	}

	[Token(Token = "0x6005FEA")]
	[Address(RVA = "0x311177C", Offset = "0x311177C", VA = "0x311177C", Slot = "5")]
	public override void UIChangeCallBack(object param, int valueOrder = 1)
	{
	}

	[Token(Token = "0x6005FEB")]
	[Address(RVA = "0x31117F0", Offset = "0x31117F0", VA = "0x31117F0", Slot = "6")]
	public override ItemEditAttributeCacheValueBase GetItemEditAttributeCacheValue()
	{
		return null;
	}
}
