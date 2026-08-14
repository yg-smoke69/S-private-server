using System;
using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x200006A")]
internal class PurchaseNormalProduct : PurchaseTaskInstance
{
	[Token(Token = "0x4000259")]
	[FieldOffset(Offset = "0x24")]
	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, string, int> OnSuccess;

	[Token(Token = "0x400025A")]
	[FieldOffset(Offset = "0x28")]
	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, string> OnFailure;

	[Token(Token = "0x17000064")]
	public override SDKIAPTask Task
	{
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x345790C", Offset = "0x345790C", VA = "0x345790C", Slot = "4")]
		get
		{
			return default(SDKIAPTask);
		}
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x3457908", Offset = "0x3457908", VA = "0x3457908")]
	public PurchaseNormalProduct(SDKIAPTaskInfo info)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x3457914", Offset = "0x3457914", VA = "0x3457914", Slot = "9")]
	internal override string IdentifySelf()
	{
		return null;
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x3457A04", Offset = "0x3457A04", VA = "0x3457A04", Slot = "13")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x3457DA0", Offset = "0x3457DA0", VA = "0x3457DA0")]
	private void OnPaymentProcessedOrException(SDKIAP_Android.TransactionInfo transactionInfo)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x3457FAC", Offset = "0x3457FAC", VA = "0x3457FAC", Slot = "14")]
	protected override void Succeed()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x3458054", Offset = "0x3458054", VA = "0x3458054", Slot = "15")]
	protected override void Fail()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x34580F4", Offset = "0x34580F4", VA = "0x34580F4", Slot = "16")]
	protected override void Destroy()
	{
	}
}
