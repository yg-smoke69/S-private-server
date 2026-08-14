using System;
using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x200006D")]
internal class LoadEventConfigs : SDKIAPTaskInstance
{
	[Token(Token = "0x4000263")]
	[FieldOffset(Offset = "0x14")]
	public bool ActiveOnly;

	[Token(Token = "0x4000264")]
	[FieldOffset(Offset = "0x18")]
	private SDKIAP.LoadEventConfigsResult _Result;

	[Token(Token = "0x4000265")]
	[FieldOffset(Offset = "0x1C")]
	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.LoadEventConfigsResult> OnDone;

	[Token(Token = "0x17000067")]
	public override SDKIAPTask Task
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x3452B84", Offset = "0x3452B84", VA = "0x3452B84", Slot = "4")]
		get
		{
			return default(SDKIAPTask);
		}
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x3452AE8", Offset = "0x3452AE8", VA = "0x3452AE8")]
	public LoadEventConfigs(SDKIAPTaskInfo info)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x3452B8C", Offset = "0x3452B8C", VA = "0x3452B8C", Slot = "9")]
	internal override string IdentifySelf()
	{
		return null;
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x3452D18", Offset = "0x3452D18", VA = "0x3452D18", Slot = "11")]
	public override bool IsDuplicateOf(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x3452EF0", Offset = "0x3452EF0", VA = "0x3452EF0", Slot = "12")]
	public override bool CanFinishWith(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x345308C", Offset = "0x345308C", VA = "0x345308C", Slot = "13")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x3453244", Offset = "0x3453244", VA = "0x3453244")]
	private void OnLoadedEventConfigs(SDKIAP.LoadEventConfigsResult result)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x34533B8", Offset = "0x34533B8", VA = "0x34533B8", Slot = "14")]
	protected override void Succeed()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x3453494", Offset = "0x3453494", VA = "0x3453494", Slot = "15")]
	protected override void Fail()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x3453570", Offset = "0x3453570", VA = "0x3453570", Slot = "16")]
	protected override void Destroy()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x3453604", Offset = "0x3453604", VA = "0x3453604")]
	private void _003CSucceed_003Em__0(LoadEventConfigs i)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x34536B8", Offset = "0x34536B8", VA = "0x34536B8")]
	private void _003CFail_003Em__1(LoadEventConfigs i)
	{
	}
}
