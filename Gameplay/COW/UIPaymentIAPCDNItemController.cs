using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A2F")]
public class UIPaymentIAPCDNItemController : UIBaseController
{
	[Token(Token = "0x401036D")]
	[FieldOffset(Offset = "0x28")]
	private AdvertDesc m_Desc;

	[Token(Token = "0x401036E")]
	[FieldOffset(Offset = "0x2C")]
	private UIPaymentIAPCDNItemView m_View;

	[Token(Token = "0x401036F")]
	[FieldOffset(Offset = "0x30")]
	public int AdIndex;

	[Token(Token = "0x6011118")]
	[Address(RVA = "0x29D2990", Offset = "0x29D2990", VA = "0x29D2990")]
	public UIPaymentIAPCDNItemController()
	{
	}

	[Token(Token = "0x6011119")]
	[Address(RVA = "0x29D2A14", Offset = "0x29D2A14", VA = "0x29D2A14")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601111A")]
	[Address(RVA = "0x29D2ABC", Offset = "0x29D2ABC", VA = "0x29D2ABC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601111B")]
	[Address(RVA = "0x29D2C18", Offset = "0x29D2C18", VA = "0x29D2C18")]
	public void SetData(AdvertDesc info)
	{
	}

	[Token(Token = "0x601111C")]
	[Address(RVA = "0x29D2E20", Offset = "0x29D2E20", VA = "0x29D2E20")]
	public void SetDefaultTexture(ResourceID resourceId)
	{
	}

	[Token(Token = "0x601111D")]
	[Address(RVA = "0x29D2D74", Offset = "0x29D2D74", VA = "0x29D2D74")]
	private void ApplyCdnUrlToNetworkTexture(UINetworkTextureExt networkTexture, string url)
	{
	}

	[Token(Token = "0x601111E")]
	[Address(RVA = "0x29D2E7C", Offset = "0x29D2E7C", VA = "0x29D2E7C")]
	private void OnCDNBtnClick()
	{
	}

	[Token(Token = "0x601111F")]
	[Address(RVA = "0x29D3004", Offset = "0x29D3004", VA = "0x29D3004")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
