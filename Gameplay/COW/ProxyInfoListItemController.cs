using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022AE")]
public class ProxyInfoListItemController : UIEasyListItemController
{
	[Token(Token = "0x400D902")]
	[FieldOffset(Offset = "0x38")]
	private ProxyInfoListItemView m_View;

	[Token(Token = "0x400D903")]
	[FieldOffset(Offset = "0x3C")]
	private HttpRequest m_Request;

	[Token(Token = "0x600BEAE")]
	[Address(RVA = "0x196BAEC", Offset = "0x196BAEC", VA = "0x196BAEC")]
	public ProxyInfoListItemController()
	{
	}

	[Token(Token = "0x600BEAF")]
	[Address(RVA = "0x196BAF4", Offset = "0x196BAF4", VA = "0x196BAF4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BEB0")]
	[Address(RVA = "0x196BB98", Offset = "0x196BB98", VA = "0x196BB98", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BEB1")]
	[Address(RVA = "0x196BD68", Offset = "0x196BD68", VA = "0x196BD68", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600BEB2")]
	[Address(RVA = "0x196C180", Offset = "0x196C180", VA = "0x196C180")]
	public void TimeOutBtnClick()
	{
	}

	[Token(Token = "0x600BEB3")]
	[Address(RVA = "0x196C37C", Offset = "0x196C37C", VA = "0x196C37C")]
	public void BlockBtnClick()
	{
	}

	[Token(Token = "0x600BEB4")]
	[Address(RVA = "0x196C6A0", Offset = "0x196C6A0", VA = "0x196C6A0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
