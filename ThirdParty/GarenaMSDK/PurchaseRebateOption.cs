using System;
using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x200006B")]
internal class PurchaseRebateOption : PurchaseTaskInstance
{
	[Token(Token = "0x400025B")]
	[FieldOffset(Offset = "0x28")]
	public long RebateID;

	[Token(Token = "0x400025C")]
	[FieldOffset(Offset = "0x30")]
	private long _rebateID;

	[Token(Token = "0x400025D")]
	[FieldOffset(Offset = "0x38")]
	private int _remainingDays;

	[Token(Token = "0x400025E")]
	[FieldOffset(Offset = "0x3C")]
	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAPManager.RebateOptionPurchaseResult> OnSuccess;

	[Token(Token = "0x400025F")]
	[FieldOffset(Offset = "0x40")]
	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAPManager.RebateOptionPurchaseResult> OnFailure;

	[Token(Token = "0x17000065")]
	public override SDKIAPTask Task
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x3458188", Offset = "0x3458188", VA = "0x3458188", Slot = "4")]
		get
		{
			return default(SDKIAPTask);
		}
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x3458184", Offset = "0x3458184", VA = "0x3458184")]
	public PurchaseRebateOption(SDKIAPTaskInfo info)
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x3458190", Offset = "0x3458190", VA = "0x3458190", Slot = "9")]
	internal override string IdentifySelf()
	{
		return null;
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x3458258", Offset = "0x3458258", VA = "0x3458258", Slot = "13")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x3458480", Offset = "0x3458480", VA = "0x3458480")]
	private void OnPaymentProcessedOrException(SDKIAP_Android.TransactionInfo transactionInfo)
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x34586A4", Offset = "0x34586A4", VA = "0x34586A4", Slot = "14")]
	protected override void Succeed()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x34587F4", Offset = "0x34587F4", VA = "0x34587F4", Slot = "15")]
	protected override void Fail()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x345893C", Offset = "0x345893C", VA = "0x345893C", Slot = "16")]
	protected override void Destroy()
	{
	}
}
