using System;
using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x2000064")]
internal class LoadIAPItems : SDKIAPTaskInstance
{
	[Token(Token = "0x4000241")]
	[FieldOffset(Offset = "0x14")]
	public bool Localized;

	[Token(Token = "0x4000242")]
	[FieldOffset(Offset = "0x15")]
	public bool AllItems;

	[Token(Token = "0x4000243")]
	[FieldOffset(Offset = "0x18")]
	public long RebateId;

	[Token(Token = "0x4000244")]
	[FieldOffset(Offset = "0x20")]
	private SDKIAP.IAPItem[] _items;

	[Token(Token = "0x4000245")]
	[FieldOffset(Offset = "0x24")]
	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.IAPItem[]> OnDone;

	[Token(Token = "0x17000060")]
	public override SDKIAPTask Task
	{
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x3454140", Offset = "0x3454140", VA = "0x3454140", Slot = "4")]
		get
		{
			return default(SDKIAPTask);
		}
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x345413C", Offset = "0x345413C", VA = "0x345413C")]
	public LoadIAPItems(SDKIAPTaskInfo info)
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x3454148", Offset = "0x3454148", VA = "0x3454148", Slot = "9")]
	internal override string IdentifySelf()
	{
		return null;
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x34543DC", Offset = "0x34543DC", VA = "0x34543DC", Slot = "11")]
	public override bool IsDuplicateOf(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x3454514", Offset = "0x3454514", VA = "0x3454514", Slot = "12")]
	public override bool CanFinishWith(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x3454620", Offset = "0x3454620", VA = "0x3454620", Slot = "13")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x3454810", Offset = "0x3454810", VA = "0x3454810")]
	private void OnLoadedIAPItems(SDKIAP.IAPItem[] items, ErrorCode errorCode, string errorMessage)
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x3454948", Offset = "0x3454948", VA = "0x3454948", Slot = "14")]
	protected override void Succeed()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x3454A20", Offset = "0x3454A20", VA = "0x3454A20", Slot = "15")]
	protected override void Fail()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x3454AF8", Offset = "0x3454AF8", VA = "0x3454AF8", Slot = "16")]
	protected override void Destroy()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x3454B88", Offset = "0x3454B88", VA = "0x3454B88")]
	private void _003CSucceed_003Em__0(LoadIAPItems i)
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x3454C3C", Offset = "0x3454C3C", VA = "0x3454C3C")]
	private void _003CFail_003Em__1(LoadIAPItems i)
	{
	}
}
