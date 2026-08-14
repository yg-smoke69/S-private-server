using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002312")]
public class UIRuleToggleButtonController : UIBaseController
{
	[Token(Token = "0x400DABE")]
	[FieldOffset(Offset = "0x28")]
	private UIRuleToggleButtonView m_View;

	[Token(Token = "0x400DABF")]
	[FieldOffset(Offset = "0x2C")]
	public int Index;

	[Token(Token = "0x400DAC0")]
	[FieldOffset(Offset = "0x30")]
	public int Value;

	[Token(Token = "0x600C205")]
	[Address(RVA = "0x1424F2C", Offset = "0x1424F2C", VA = "0x1424F2C")]
	public UIRuleToggleButtonController()
	{
	}

	[Token(Token = "0x600C206")]
	[Address(RVA = "0x1424FB0", Offset = "0x1424FB0", VA = "0x1424FB0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C207")]
	[Address(RVA = "0x1425058", Offset = "0x1425058", VA = "0x1425058", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C208")]
	[Address(RVA = "0x1420778", Offset = "0x1420778", VA = "0x1420778")]
	public void Init(int index, int value, string labelId)
	{
	}

	[Token(Token = "0x600C209")]
	[Address(RVA = "0x1425114", Offset = "0x1425114", VA = "0x1425114")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
