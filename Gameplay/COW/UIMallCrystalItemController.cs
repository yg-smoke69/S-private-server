using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021D7")]
public class UIMallCrystalItemController : UIMallCDNItemController
{
	[Token(Token = "0x400D3AC")]
	[FieldOffset(Offset = "0x138")]
	private UIMallCrystalItemView m_View;

	[Token(Token = "0x400D3AD")]
	[FieldOffset(Offset = "0x13C")]
	private ExchangeStoreItemDesc m_Info;

	[Token(Token = "0x600B59B")]
	[Address(RVA = "0x23A4E5C", Offset = "0x23A4E5C", VA = "0x23A4E5C")]
	public UIMallCrystalItemController()
	{
	}

	[Token(Token = "0x600B59C")]
	[Address(RVA = "0x23A4E74", Offset = "0x23A4E74", VA = "0x23A4E74", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B59D")]
	[Address(RVA = "0x23A4ED0", Offset = "0x23A4ED0", VA = "0x23A4ED0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B59E")]
	[Address(RVA = "0x23A4F78", Offset = "0x23A4F78", VA = "0x23A4F78", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B59F")]
	[Address(RVA = "0x23A5038", Offset = "0x23A5038", VA = "0x23A5038")]
	private void InitCommonWidget()
	{
	}

	[Token(Token = "0x600B5A0")]
	[Address(RVA = "0x23A512C", Offset = "0x23A512C", VA = "0x23A512C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B5A1")]
	[Address(RVA = "0x23A5294", Offset = "0x23A5294", VA = "0x23A5294", Slot = "42")]
	protected override void RefreshItemView()
	{
	}

	[Token(Token = "0x600B5A2")]
	[Address(RVA = "0x23A5424", Offset = "0x23A5424", VA = "0x23A5424")]
	private void SetExchangeInfo()
	{
	}

	[Token(Token = "0x600B5A3")]
	[Address(RVA = "0x23A56A4", Offset = "0x23A56A4", VA = "0x23A56A4", Slot = "37")]
	protected override void SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B5A4")]
	[Address(RVA = "0x23A58F4", Offset = "0x23A58F4", VA = "0x23A58F4", Slot = "38")]
	protected override void SendClothClickEvent()
	{
	}

	[Token(Token = "0x600B5A5")]
	[Address(RVA = "0x23A5B70", Offset = "0x23A5B70", VA = "0x23A5B70")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B5A6")]
	[Address(RVA = "0x23A5B78", Offset = "0x23A5B78", VA = "0x23A5B78")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B5A7")]
	[Address(RVA = "0x23A5B7C", Offset = "0x23A5B7C", VA = "0x23A5B7C")]
	public new void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	[Token(Token = "0x600B5A8")]
	[Address(RVA = "0x23A5B80", Offset = "0x23A5B80", VA = "0x23A5B80")]
	public new void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	[Token(Token = "0x600B5A9")]
	[Address(RVA = "0x23A5B84", Offset = "0x23A5B84", VA = "0x23A5B84")]
	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B5AA")]
	[Address(RVA = "0x23A5B8C", Offset = "0x23A5B8C", VA = "0x23A5B8C")]
	public void _003C_003EiFixBaseProxy_SendClothClickEvent()
	{
	}
}
