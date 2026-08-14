using System;
using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x200006F")]
internal class PurchaseEventProduct : PurchaseTaskInstance
{
	[Token(Token = "0x4000269")]
	[FieldOffset(Offset = "0x28")]
	public long EventId;

	[Token(Token = "0x400026A")]
	[FieldOffset(Offset = "0x30")]
	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, string, int> OnSuccess;

	[Token(Token = "0x400026B")]
	[FieldOffset(Offset = "0x34")]
	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, string> OnFailure;

	[Token(Token = "0x17000069")]
	public override SDKIAPTask Task
	{
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x3456A74", Offset = "0x3456A74", VA = "0x3456A74", Slot = "4")]
		get
		{
			return default(SDKIAPTask);
		}
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x3456A6C", Offset = "0x3456A6C", VA = "0x3456A6C")]
	public PurchaseEventProduct(SDKIAPTaskInfo info)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x3456A7C", Offset = "0x3456A7C", VA = "0x3456A7C", Slot = "9")]
	internal override string IdentifySelf()
	{
		return null;
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x3456CF0", Offset = "0x3456CF0", VA = "0x3456CF0", Slot = "13")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x34571DC", Offset = "0x34571DC", VA = "0x34571DC")]
	private void OnEventPaymentProcessedOrException(SDKIAP_Android.TransactionInfo transactionInfo)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x345772C", Offset = "0x345772C", VA = "0x345772C", Slot = "14")]
	protected override void Succeed()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x34577D4", Offset = "0x34577D4", VA = "0x34577D4", Slot = "15")]
	protected override void Fail()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x3457874", Offset = "0x3457874", VA = "0x3457874", Slot = "16")]
	protected override void Destroy()
	{
	}
}
