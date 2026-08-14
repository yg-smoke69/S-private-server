using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20031F8")]
public class RebateCardInfo
{
	[Token(Token = "0x20031F9")]
	public enum ELocalizedPriceStatus
	{
		[Token(Token = "0x401305D")]
		Unloaded,
		[Token(Token = "0x401305E")]
		Loading,
		[Token(Token = "0x401305F")]
		Loaded
	}

	[Token(Token = "0x4013051")]
	[FieldOffset(Offset = "0x8")]
	public ELocalizedPriceStatus PriceStatus;

	[Token(Token = "0x4013052")]
	[FieldOffset(Offset = "0xC")]
	public ELocalizedPriceStatus SubscriptionPriceStatus;

	[Token(Token = "0x4013053")]
	[FieldOffset(Offset = "0x10")]
	public RebateCardData CardInfo;

	[Token(Token = "0x4013054")]
	[FieldOffset(Offset = "0x14")]
	public bool Owned;

	[Token(Token = "0x4013055")]
	[FieldOffset(Offset = "0x15")]
	public bool Valid_To_Redeem;

	[Token(Token = "0x4013056")]
	[FieldOffset(Offset = "0x16")]
	public bool Valid_To_Purchase;

	[Token(Token = "0x4013057")]
	[FieldOffset(Offset = "0x18")]
	public int Remaining_Days;

	[Token(Token = "0x4013058")]
	[FieldOffset(Offset = "0x20")]
	public ulong TimeSpan_To_NextRedeem;

	[Token(Token = "0x4013059")]
	[FieldOffset(Offset = "0x28")]
	public RebateCardType Type;

	[Token(Token = "0x401305A")]
	[FieldOffset(Offset = "0x2C")]
	public string CDN_URL;

	[Token(Token = "0x401305B")]
	[FieldOffset(Offset = "0x30")]
	private PayItemData _SubscriptionProductFromCSV;

	[Token(Token = "0x17001632")]
	public PayItemData SubscriptionProductFromCSV
	{
		[Token(Token = "0x601513B")]
		[Address(RVA = "0x196FD88", Offset = "0x196FD88", VA = "0x196FD88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601513A")]
	[Address(RVA = "0x196F944", Offset = "0x196F944", VA = "0x196F944")]
	public RebateCardInfo(RebateCardType type)
	{
	}

	[Token(Token = "0x601513C")]
	[Address(RVA = "0x196FDE0", Offset = "0x196FDE0", VA = "0x196FDE0")]
	public void UpdateDynamicData(RebateItemData rebateItemData)
	{
	}
}
