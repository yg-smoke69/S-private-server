using Il2CppDummyDll;

[Token(Token = "0x2000C87")]
public class ItemEditAttributeUIDataSubAndPlus : ItemEditAttributeUIData
{
	[Token(Token = "0x40066E1")]
	[FieldOffset(Offset = "0xC")]
	protected float m_MinValue;

	[Token(Token = "0x40066E2")]
	[FieldOffset(Offset = "0x10")]
	protected float m_MaxValue;

	[Token(Token = "0x40066E3")]
	[FieldOffset(Offset = "0x14")]
	protected float m_StepValue;

	[Token(Token = "0x40066E4")]
	[FieldOffset(Offset = "0x18")]
	protected float m_CurUIValue;

	[Token(Token = "0x170007FE")]
	public float MinValue
	{
		[Token(Token = "0x6005FDB")]
		[Address(RVA = "0x3111A2C", Offset = "0x3111A2C", VA = "0x3111A2C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170007FF")]
	public float MaxValue
	{
		[Token(Token = "0x6005FDC")]
		[Address(RVA = "0x3111A34", Offset = "0x3111A34", VA = "0x3111A34")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000800")]
	public float StepValue
	{
		[Token(Token = "0x6005FDD")]
		[Address(RVA = "0x3111A3C", Offset = "0x3111A3C", VA = "0x3111A3C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000801")]
	public float CurUIValue
	{
		[Token(Token = "0x6005FDE")]
		[Address(RVA = "0x3111A44", Offset = "0x3111A44", VA = "0x3111A44")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6005FDF")]
		[Address(RVA = "0x3111A4C", Offset = "0x3111A4C", VA = "0x3111A4C")]
		private set
		{
		}
	}

	[Token(Token = "0x6005FD9")]
	[Address(RVA = "0x3111A1C", Offset = "0x3111A1C", VA = "0x3111A1C")]
	public ItemEditAttributeUIDataSubAndPlus()
	{
	}

	[Token(Token = "0x6005FDA")]
	[Address(RVA = "0x3111A24", Offset = "0x3111A24", VA = "0x3111A24", Slot = "4")]
	public override SceneEditItemAttributeUIType GetUIType()
	{
		return default(SceneEditItemAttributeUIType);
	}

	[Token(Token = "0x6005FE0")]
	[Address(RVA = "0x3111AFC", Offset = "0x3111AFC", VA = "0x3111AFC", Slot = "5")]
	public override void UIChangeCallBack(object param, int valueOrder = 1)
	{
	}

	[Token(Token = "0x6005FE1")]
	[Address(RVA = "0x3111B70", Offset = "0x3111B70", VA = "0x3111B70", Slot = "6")]
	public override ItemEditAttributeCacheValueBase GetItemEditAttributeCacheValue()
	{
		return null;
	}

	[Token(Token = "0x6005FE2")]
	[Address(RVA = "0x3111BE8", Offset = "0x3111BE8", VA = "0x3111BE8")]
	public void ScriptObjectDataToUIData(string attributeTitleNameKey, float minValue, float maxValue, float defaultValue, float stepValue)
	{
	}
}
