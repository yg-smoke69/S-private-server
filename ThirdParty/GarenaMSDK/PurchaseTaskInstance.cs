using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x2000068")]
internal class PurchaseTaskInstance : SDKIAPTaskInstance
{
	[Token(Token = "0x2000069")]
	protected enum PendingPhase
	{
		[Token(Token = "0x4000258")]
		Pending
	}

	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0x14")]
	public string ProductIdentifier;

	[Token(Token = "0x4000254")]
	[FieldOffset(Offset = "0x18")]
	public int Quantity;

	[Token(Token = "0x4000255")]
	[FieldOffset(Offset = "0x1C")]
	protected PendingPhase Phase;

	[Token(Token = "0x4000256")]
	[FieldOffset(Offset = "0x20")]
	protected SDKIAP_Android.TransactionInfo TransactionInfo;

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x3456A70", Offset = "0x3456A70", VA = "0x3456A70")]
	public PurchaseTaskInstance(SDKIAPTaskInfo info)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x34589CC", Offset = "0x34589CC", VA = "0x34589CC", Slot = "11")]
	public sealed override bool IsDuplicateOf(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x34589D4", Offset = "0x34589D4", VA = "0x34589D4", Slot = "12")]
	public sealed override bool CanFinishWith(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x3456F4C", Offset = "0x3456F4C", VA = "0x3456F4C", Slot = "13")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x34574D8", Offset = "0x34574D8", VA = "0x34574D8")]
	protected static bool? GetAndroidPaymentResult(SDKIAP_Android.TransactionInfo transactionInfo, out ErrorCode errorCode, out string errorMessage)
	{
		return null;
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x3457904", Offset = "0x3457904", VA = "0x3457904", Slot = "16")]
	protected override void Destroy()
	{
	}
}
