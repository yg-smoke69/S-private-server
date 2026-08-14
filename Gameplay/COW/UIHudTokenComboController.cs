using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023D2")]
public class UIHudTokenComboController : UIBaseController
{
	[Token(Token = "0x400DEB5")]
	[FieldOffset(Offset = "0x28")]
	private UIHudTokenComboView m_View;

	[Token(Token = "0x600CA01")]
	[Address(RVA = "0x157EBF0", Offset = "0x157EBF0", VA = "0x157EBF0")]
	public UIHudTokenComboController()
	{
	}

	[Token(Token = "0x600CA02")]
	[Address(RVA = "0x157EC74", Offset = "0x157EC74", VA = "0x157EC74")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CA03")]
	[Address(RVA = "0x157ED1C", Offset = "0x157ED1C", VA = "0x157ED1C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CA04")]
	[Address(RVA = "0x157EDD8", Offset = "0x157EDD8", VA = "0x157EDD8")]
	public void SetSpUI(string combo, string comboKey = "")
	{
	}

	[Token(Token = "0x600CA05")]
	[Address(RVA = "0x157F2BC", Offset = "0x157F2BC", VA = "0x157F2BC")]
	public void SetUI(string combo, string comboKey = "")
	{
	}

	[Token(Token = "0x600CA06")]
	[Address(RVA = "0x157F6D8", Offset = "0x157F6D8", VA = "0x157F6D8")]
	public void HideUI()
	{
	}

	[Token(Token = "0x600CA07")]
	[Address(RVA = "0x157F768", Offset = "0x157F768", VA = "0x157F768")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
