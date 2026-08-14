using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021EC")]
public class UIMallGiftSendController : UIMallPurchaseBaseController
{
	[Token(Token = "0x400D43F")]
	[FieldOffset(Offset = "0x70")]
	private GiftItem m_GiftItemData;

	[Token(Token = "0x400D440")]
	[FieldOffset(Offset = "0x74")]
	private string m_ReceiversName;

	[Token(Token = "0x400D441")]
	[FieldOffset(Offset = "0x78")]
	private ulong[] m_ReceiversIdList;

	[Token(Token = "0x400D442")]
	[FieldOffset(Offset = "0x7C")]
	private EGiftStore_BuddyType m_BuddyType;

	[Token(Token = "0x400D443")]
	[FieldOffset(Offset = "0x80")]
	private string m_Message;

	[Token(Token = "0x600B677")]
	[Address(RVA = "0x225CD44", Offset = "0x225CD44", VA = "0x225CD44")]
	public UIMallGiftSendController()
	{
	}

	[Token(Token = "0x600B678")]
	[Address(RVA = "0x225CD54", Offset = "0x225CD54", VA = "0x225CD54")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B679")]
	[Address(RVA = "0x225CDF8", Offset = "0x225CDF8", VA = "0x225CDF8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B67A")]
	[Address(RVA = "0x225D090", Offset = "0x225D090", VA = "0x225D090")]
	private void OnGemsPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600B67B")]
	[Address(RVA = "0x225D2C0", Offset = "0x225D2C0", VA = "0x225D2C0")]
	private void OnGoldPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600B67C")]
	[Address(RVA = "0x225D0F4", Offset = "0x225D0F4", VA = "0x225D0F4")]
	private void SendItem(EInventory.CurrencyType currency)
	{
	}

	[Token(Token = "0x600B67D")]
	[Address(RVA = "0x2258224", Offset = "0x2258224", VA = "0x2258224")]
	public void RefreshData(GiftItem giftItem, ulong[] receiversIdList, EGiftStore_BuddyType buddyType, string message, string receiversName)
	{
	}

	[Token(Token = "0x600B67E")]
	[Address(RVA = "0x225D434", Offset = "0x225D434", VA = "0x225D434")]
	private void SetPriceData()
	{
	}

	[Token(Token = "0x600B67F")]
	[Address(RVA = "0x225D660", Offset = "0x225D660", VA = "0x225D660")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
