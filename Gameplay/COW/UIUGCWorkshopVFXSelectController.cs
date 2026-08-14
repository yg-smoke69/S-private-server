using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BBD")]
public class UIUGCWorkshopVFXSelectController : UIUGCItemSelectBaseController
{
	[Token(Token = "0x601216C")]
	[Address(RVA = "0xF44504", Offset = "0xF44504", VA = "0xF44504")]
	private UIUGCWorkshopVFXSelectController()
	{
	}

	[Token(Token = "0x601216D")]
	[Address(RVA = "0xF44524", Offset = "0xF44524", VA = "0xF44524")]
	public static UIUGCWorkshopVFXSelectController OpenSelectUI(string currentResIDName, [Optional] UIModelUGCResourceSelect.OnFinalSelected callback)
	{
		return null;
	}

	[Token(Token = "0x601216E")]
	[Address(RVA = "0xF44668", Offset = "0xF44668", VA = "0xF44668")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}
}
