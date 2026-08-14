using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002BCC")]
public class UIVeteranBundleItemController : UIStandardItemMiniController
{
	[Token(Token = "0x4010BAD")]
	[FieldOffset(Offset = "0x44")]
	private BundleShowData m_BundleData;

	[Token(Token = "0x60121F2")]
	[Address(RVA = "0x2844F48", Offset = "0x2844F48", VA = "0x2844F48")]
	public UIVeteranBundleItemController()
	{
	}

	[Token(Token = "0x60121F3")]
	[Address(RVA = "0x2844F50", Offset = "0x2844F50", VA = "0x2844F50")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60121F4")]
	[Address(RVA = "0x2844FF8", Offset = "0x2844FF8", VA = "0x2844FF8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60121F5")]
	[Address(RVA = "0x284506C", Offset = "0x284506C", VA = "0x284506C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60121F6")]
	[Address(RVA = "0x28453D0", Offset = "0x28453D0", VA = "0x28453D0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60121F7")]
	[Address(RVA = "0x28453D8", Offset = "0x28453D8", VA = "0x28453D8")]
	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
