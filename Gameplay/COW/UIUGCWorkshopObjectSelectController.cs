using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BBC")]
public class UIUGCWorkshopObjectSelectController : UIUGCItemSelectBaseController
{
	[Token(Token = "0x6012169")]
	[Address(RVA = "0xF442FC", Offset = "0xF442FC", VA = "0xF442FC")]
	private UIUGCWorkshopObjectSelectController()
	{
	}

	[Token(Token = "0x601216A")]
	[Address(RVA = "0xF4431C", Offset = "0xF4431C", VA = "0xF4431C")]
	public static UIUGCWorkshopObjectSelectController OpenSelectUI(string currentResIDName, [Optional] UIModelUGCResourceSelect.OnFinalSelected callback)
	{
		return null;
	}

	[Token(Token = "0x601216B")]
	[Address(RVA = "0xF44460", Offset = "0xF44460", VA = "0xF44460")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}
}
