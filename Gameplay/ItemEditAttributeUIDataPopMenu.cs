using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000C89")]
public class ItemEditAttributeUIDataPopMenu : ItemEditAttributeUIData
{
	[Token(Token = "0x40066E8")]
	[FieldOffset(Offset = "0xC")]
	private List<string> m_OptionShowTxtKey;

	[Token(Token = "0x40066E9")]
	[FieldOffset(Offset = "0x10")]
	private List<int> m_OptionValue;

	[Token(Token = "0x40066EA")]
	[FieldOffset(Offset = "0x14")]
	private int m_CurUIValue;

	[Token(Token = "0x17000805")]
	public List<string> OptionShowTxtKey
	{
		[Token(Token = "0x6005FEE")]
		[Address(RVA = "0x3111870", Offset = "0x3111870", VA = "0x3111870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000806")]
	public List<int> OptionValue
	{
		[Token(Token = "0x6005FEF")]
		[Address(RVA = "0x3111878", Offset = "0x3111878", VA = "0x3111878")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000807")]
	public int CurUIValue
	{
		[Token(Token = "0x6005FF0")]
		[Address(RVA = "0x3111880", Offset = "0x3111880", VA = "0x3111880")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005FF1")]
		[Address(RVA = "0x3111888", Offset = "0x3111888", VA = "0x3111888")]
		private set
		{
		}
	}

	[Token(Token = "0x6005FEC")]
	[Address(RVA = "0x3110C80", Offset = "0x3110C80", VA = "0x3110C80")]
	public ItemEditAttributeUIDataPopMenu()
	{
	}

	[Token(Token = "0x6005FED")]
	[Address(RVA = "0x3111868", Offset = "0x3111868", VA = "0x3111868", Slot = "4")]
	public override SceneEditItemAttributeUIType GetUIType()
	{
		return default(SceneEditItemAttributeUIType);
	}

	[Token(Token = "0x6005FF2")]
	[Address(RVA = "0x3110D40", Offset = "0x3110D40", VA = "0x3110D40")]
	public void ScriptObjectDataToUIData(string attributeTitleNameKey, List<string> optionShowTxtKey, List<int> optionValue, int defaultValue)
	{
	}

	[Token(Token = "0x6005FF3")]
	[Address(RVA = "0x3111930", Offset = "0x3111930", VA = "0x3111930", Slot = "5")]
	public override void UIChangeCallBack(object param, int valueOrder = 1)
	{
	}

	[Token(Token = "0x6005FF4")]
	[Address(RVA = "0x31119A4", Offset = "0x31119A4", VA = "0x31119A4", Slot = "6")]
	public override ItemEditAttributeCacheValueBase GetItemEditAttributeCacheValue()
	{
		return null;
	}
}
