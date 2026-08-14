using System;
using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x2000063")]
internal class ScanIAPInventory : SDKIAPTaskInstance
{
	[Token(Token = "0x400023F")]
	[FieldOffset(Offset = "0x14")]
	private SDKIAP.ScanIAPInventoryResult[] _results;

	[Token(Token = "0x4000240")]
	[FieldOffset(Offset = "0x18")]
	public Action<SDKIAPTaskInfo, SDKIAP.ScanIAPInventoryResult[]> OnScanned;

	[Token(Token = "0x1700005F")]
	public override SDKIAPTask Task
	{
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x3467CE4", Offset = "0x3467CE4", VA = "0x3467CE4", Slot = "4")]
		get
		{
			return default(SDKIAPTask);
		}
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x346318C", Offset = "0x346318C", VA = "0x346318C")]
	public ScanIAPInventory(SDKIAPTaskInfo info)
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x3467CEC", Offset = "0x3467CEC", VA = "0x3467CEC", Slot = "10")]
	public override bool IsGoodToGo()
	{
		return default(bool);
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x3467D64", Offset = "0x3467D64", VA = "0x3467D64", Slot = "13")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x3467EA4", Offset = "0x3467EA4", VA = "0x3467EA4")]
	private void OnScanIAPInventoryResult(SDKIAP.ScanIAPInventoryResult[] results)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x3467EBC", Offset = "0x3467EBC", VA = "0x3467EBC", Slot = "14")]
	protected override void Succeed()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x3467F94", Offset = "0x3467F94", VA = "0x3467F94", Slot = "16")]
	protected override void Destroy()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x3468024", Offset = "0x3468024", VA = "0x3468024", Slot = "9")]
	internal override string IdentifySelf()
	{
		return null;
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x34680D8", Offset = "0x34680D8", VA = "0x34680D8")]
	private void _003CSucceed_003Em__0(ScanIAPInventory i)
	{
	}
}
