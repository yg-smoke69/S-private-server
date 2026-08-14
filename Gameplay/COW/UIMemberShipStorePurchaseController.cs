using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20029C7")]
public class UIMemberShipStorePurchaseController : UIMallPurchaseBaseController
{
	[Token(Token = "0x40100FF")]
	[FieldOffset(Offset = "0x70")]
	private VipCardStoreInfo m_Info;

	[Token(Token = "0x6010CD1")]
	[Address(RVA = "0x1305298", Offset = "0x1305298", VA = "0x1305298")]
	public UIMemberShipStorePurchaseController()
	{
	}

	[Token(Token = "0x6010CD2")]
	[Address(RVA = "0x13052A0", Offset = "0x13052A0", VA = "0x13052A0")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010CD3")]
	[Address(RVA = "0x1305344", Offset = "0x1305344", VA = "0x1305344", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010CD4")]
	[Address(RVA = "0x13055E0", Offset = "0x13055E0", VA = "0x13055E0")]
	private void OnGemsPurchaseBtnClick()
	{
	}

	[Token(Token = "0x6010CD5")]
	[Address(RVA = "0x130585C", Offset = "0x130585C", VA = "0x130585C")]
	private void OnGoldPurchaseBtnClick()
	{
	}

	[Token(Token = "0x6010CD6")]
	[Address(RVA = "0x1305640", Offset = "0x1305640", VA = "0x1305640")]
	private void PurchaseMemberShipItem()
	{
	}

	[Token(Token = "0x6010CD7")]
	[Address(RVA = "0x13049F0", Offset = "0x13049F0", VA = "0x13049F0")]
	public void RefreshData(VipCardStoreInfo storeInfo)
	{
	}

	[Token(Token = "0x6010CD8")]
	[Address(RVA = "0x13058BC", Offset = "0x13058BC", VA = "0x13058BC")]
	private void SetPriceData()
	{
	}

	[Token(Token = "0x6010CD9")]
	[Address(RVA = "0x1305AA0", Offset = "0x1305AA0", VA = "0x1305AA0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
