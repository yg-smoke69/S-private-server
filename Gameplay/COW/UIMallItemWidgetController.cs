using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20021F0")]
public class UIMallItemWidgetController : UIMallItemBaseController
{
	[Token(Token = "0x400D48C")]
	[FieldOffset(Offset = "0x12C")]
	public UIStandardItemMAXBView m_View;

	[Token(Token = "0x600B6AB")]
	[Address(RVA = "0x2262CC0", Offset = "0x2262CC0", VA = "0x2262CC0")]
	public UIMallItemWidgetController()
	{
	}

	[Token(Token = "0x600B6AC")]
	[Address(RVA = "0x2262CDC", Offset = "0x2262CDC", VA = "0x2262CDC", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B6AD")]
	[Address(RVA = "0x2262D38", Offset = "0x2262D38", VA = "0x2262D38")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B6AE")]
	[Address(RVA = "0x2262DDC", Offset = "0x2262DDC", VA = "0x2262DDC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B6AF")]
	[Address(RVA = "0x2262F7C", Offset = "0x2262F7C", VA = "0x2262F7C")]
	private void SetParentWidget()
	{
	}

	[Token(Token = "0x600B6B0")]
	[Address(RVA = "0x22636D4", Offset = "0x22636D4", VA = "0x22636D4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B6B1")]
	[Address(RVA = "0x22636D8", Offset = "0x22636D8", VA = "0x22636D8")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}
}
