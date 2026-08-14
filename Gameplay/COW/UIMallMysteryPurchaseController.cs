using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021F1")]
public class UIMallMysteryPurchaseController : UIMallPurchaseBaseController
{
	[Token(Token = "0x400D48D")]
	[FieldOffset(Offset = "0x70")]
	private MysteryPoolStoreItem m_MysteryStoreDesc;

	[Token(Token = "0x17001035")]
	protected override int ItemCount
	{
		[Token(Token = "0x600B6B4")]
		[Address(RVA = "0x2263CB4", Offset = "0x2263CB4", VA = "0x2263CB4", Slot = "49")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B6B5")]
		[Address(RVA = "0x2263D0C", Offset = "0x2263D0C", VA = "0x2263D0C", Slot = "50")]
		set
		{
		}
	}

	[Token(Token = "0x600B6B2")]
	[Address(RVA = "0x2263C00", Offset = "0x2263C00", VA = "0x2263C00")]
	public UIMallMysteryPurchaseController()
	{
	}

	[Token(Token = "0x600B6B3")]
	[Address(RVA = "0x2263C10", Offset = "0x2263C10", VA = "0x2263C10")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B6B6")]
	[Address(RVA = "0x2263E48", Offset = "0x2263E48", VA = "0x2263E48", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B6B7")]
	[Address(RVA = "0x2263F84", Offset = "0x2263F84", VA = "0x2263F84")]
	private void PurchaseItem()
	{
	}

	[Token(Token = "0x600B6B8")]
	[Address(RVA = "0x22640D4", Offset = "0x22640D4", VA = "0x22640D4")]
	public void RefreshData(MysteryPoolStoreItem poolStoreItem)
	{
	}

	[Token(Token = "0x600B6B9")]
	[Address(RVA = "0x2264434", Offset = "0x2264434", VA = "0x2264434")]
	private void SetPriceData()
	{
	}

	[Token(Token = "0x600B6BA")]
	[Address(RVA = "0x2264540", Offset = "0x2264540", VA = "0x2264540")]
	public int _003C_003EiFixBaseProxy_get_ItemCount()
	{
		return default(int);
	}

	[Token(Token = "0x600B6BB")]
	[Address(RVA = "0x226459C", Offset = "0x226459C", VA = "0x226459C")]
	public void _003C_003EiFixBaseProxy_set_ItemCount(int P0)
	{
	}

	[Token(Token = "0x600B6BC")]
	[Address(RVA = "0x22647A8", Offset = "0x22647A8", VA = "0x22647A8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
