using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002750")]
internal class UIHudFlightRoamDownController : UIHudButtonBaseController
{
	[Token(Token = "0x400F2C1")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudFlightRoamDownView m_View;

	[Token(Token = "0x600F022")]
	[Address(RVA = "0x1BB1F68", Offset = "0x1BB1F68", VA = "0x1BB1F68")]
	public UIHudFlightRoamDownController()
	{
	}

	[Token(Token = "0x600F023")]
	[Address(RVA = "0x1BB1F70", Offset = "0x1BB1F70", VA = "0x1BB1F70")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F024")]
	[Address(RVA = "0x1BB2018", Offset = "0x1BB2018", VA = "0x1BB2018", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F025")]
	[Address(RVA = "0x1BB20F8", Offset = "0x1BB20F8", VA = "0x1BB20F8", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600F026")]
	[Address(RVA = "0x1BB219C", Offset = "0x1BB219C", VA = "0x1BB219C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
