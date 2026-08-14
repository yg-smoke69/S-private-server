using Il2CppDummyDll;

[Token(Token = "0x2000C86")]
public class ItemEditAttributeUIData
{
	[Token(Token = "0x40066E0")]
	[FieldOffset(Offset = "0x8")]
	protected string m_AttributeTitleNameKey;

	[Token(Token = "0x170007FD")]
	public string AttributeTitleNameKey
	{
		[Token(Token = "0x6005FD5")]
		[Address(RVA = "0x3111634", Offset = "0x3111634", VA = "0x3111634")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005FD4")]
	[Address(RVA = "0x311162C", Offset = "0x311162C", VA = "0x311162C")]
	public ItemEditAttributeUIData()
	{
	}

	[Token(Token = "0x6005FD6")]
	[Address(RVA = "0x311163C", Offset = "0x311163C", VA = "0x311163C", Slot = "4")]
	public virtual SceneEditItemAttributeUIType GetUIType()
	{
		return default(SceneEditItemAttributeUIType);
	}

	[Token(Token = "0x6005FD7")]
	[Address(RVA = "0x3111644", Offset = "0x3111644", VA = "0x3111644", Slot = "5")]
	public virtual void UIChangeCallBack(object param, int valueOrder = 1)
	{
	}

	[Token(Token = "0x6005FD8")]
	[Address(RVA = "0x3111648", Offset = "0x3111648", VA = "0x3111648", Slot = "6")]
	public virtual ItemEditAttributeCacheValueBase GetItemEditAttributeCacheValue()
	{
		return null;
	}
}
