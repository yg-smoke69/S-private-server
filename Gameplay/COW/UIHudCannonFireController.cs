using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002700")]
internal class UIHudCannonFireController : UIHudButtonBaseController
{
	[Token(Token = "0x400F0B2")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudCannonFireView m_View;

	[Token(Token = "0x600ECEA")]
	[Address(RVA = "0x2145A70", Offset = "0x2145A70", VA = "0x2145A70")]
	public UIHudCannonFireController()
	{
	}

	[Token(Token = "0x600ECEB")]
	[Address(RVA = "0x2145A78", Offset = "0x2145A78", VA = "0x2145A78")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ECEC")]
	[Address(RVA = "0x2145B1C", Offset = "0x2145B1C", VA = "0x2145B1C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ECED")]
	[Address(RVA = "0x2145C3C", Offset = "0x2145C3C", VA = "0x2145C3C", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600ECEE")]
	[Address(RVA = "0x2145CE0", Offset = "0x2145CE0", VA = "0x2145CE0")]
	private void SetVisibleState(object[] data)
	{
	}

	[Token(Token = "0x600ECEF")]
	[Address(RVA = "0x2145F90", Offset = "0x2145F90", VA = "0x2145F90")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
