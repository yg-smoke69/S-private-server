using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BBB")]
public class UIUGCWorkshopIconSelectController : UIUGCItemSelectBaseController
{
	[Token(Token = "0x6012166")]
	[Address(RVA = "0xF43EEC", Offset = "0xF43EEC", VA = "0xF43EEC")]
	private UIUGCWorkshopIconSelectController()
	{
	}

	[Token(Token = "0x6012167")]
	[Address(RVA = "0xF43F0C", Offset = "0xF43F0C", VA = "0xF43F0C")]
	public static UIUGCWorkshopIconSelectController OpenSelectUI(string currentResIDName, [Optional] UIModelUGCResourceSelect.OnFinalSelected callback)
	{
		return null;
	}

	[Token(Token = "0x6012168")]
	[Address(RVA = "0xF44050", Offset = "0xF44050", VA = "0xF44050")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}
}
