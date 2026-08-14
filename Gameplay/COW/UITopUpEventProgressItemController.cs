using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002B73")]
public class UITopUpEventProgressItemController : UIBaseController
{
	[Token(Token = "0x4010A2A")]
	[FieldOffset(Offset = "0x28")]
	private UIModelActivity m_Model;

	[Token(Token = "0x4010A2B")]
	[FieldOffset(Offset = "0x2C")]
	private UITopUpEventProgressItemView m_View;

	[Token(Token = "0x4010A2C")]
	[FieldOffset(Offset = "0x30")]
	private ClientActivityDesc m_Desc;

	[Token(Token = "0x4010A2D")]
	[FieldOffset(Offset = "0x34")]
	private ActivityClientInfo m_Info;

	[Token(Token = "0x6011EBF")]
	[Address(RVA = "0x2AF83F4", Offset = "0x2AF83F4", VA = "0x2AF83F4")]
	public UITopUpEventProgressItemController()
	{
	}

	[Token(Token = "0x6011EC0")]
	[Address(RVA = "0x2AF8478", Offset = "0x2AF8478", VA = "0x2AF8478")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011EC1")]
	[Address(RVA = "0x2AF8520", Offset = "0x2AF8520", VA = "0x2AF8520", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011EC2")]
	[Address(RVA = "0x2AF5E24", Offset = "0x2AF5E24", VA = "0x2AF5E24")]
	public void SetViewData(ClientActivityDesc desc, bool isLast = false)
	{
	}

	[Token(Token = "0x6011EC3")]
	[Address(RVA = "0x2AF64E4", Offset = "0x2AF64E4", VA = "0x2AF64E4")]
	public void SetWidth(int width)
	{
	}

	[Token(Token = "0x6011EC4")]
	[Address(RVA = "0x2AF61E0", Offset = "0x2AF61E0", VA = "0x2AF61E0")]
	public uint GetCdtValue()
	{
		return default(uint);
	}

	[Token(Token = "0x6011EC5")]
	[Address(RVA = "0x2AF6258", Offset = "0x2AF6258", VA = "0x2AF6258")]
	public void CalculateProgressValue(uint lastcdtValue)
	{
	}

	[Token(Token = "0x6011EC6")]
	[Address(RVA = "0x2AF864C", Offset = "0x2AF864C", VA = "0x2AF864C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
