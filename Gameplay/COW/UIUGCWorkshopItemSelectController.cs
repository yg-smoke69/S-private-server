using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BBE")]
public class UIUGCWorkshopItemSelectController : UIUGCItemSelectBaseController
{
	[Token(Token = "0x601216F")]
	[Address(RVA = "0xF440F4", Offset = "0xF440F4", VA = "0xF440F4")]
	private UIUGCWorkshopItemSelectController()
	{
	}

	[Token(Token = "0x6012170")]
	[Address(RVA = "0xF44114", Offset = "0xF44114", VA = "0xF44114")]
	public static UIUGCWorkshopItemSelectController OpenSelectUI(string currentResIDName, [Optional] UIModelUGCResourceSelect.OnFinalSelected callback)
	{
		return null;
	}

	[Token(Token = "0x6012171")]
	[Address(RVA = "0xF44258", Offset = "0xF44258", VA = "0xF44258")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}
}
