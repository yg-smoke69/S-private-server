using System;
using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x2000067")]
internal class LoadSomeRebateOptions : SDKIAPTaskInstance
{
	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0x14")]
	public long[] RebateIds;

	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0x18")]
	private SDKIAP.RebateOption[] _RebateOptions;

	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x1C")]
	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateOption[]> OnDone;

	[Token(Token = "0x4000252")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<long, string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17000063")]
	public override SDKIAPTask Task
	{
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x3456194", Offset = "0x3456194", VA = "0x3456194", Slot = "4")]
		get
		{
			return default(SDKIAPTask);
		}
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x3456190", Offset = "0x3456190", VA = "0x3456190")]
	public LoadSomeRebateOptions(SDKIAPTaskInfo info)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x345619C", Offset = "0x345619C", VA = "0x345619C", Slot = "9")]
	internal override string IdentifySelf()
	{
		return null;
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x345636C", Offset = "0x345636C", VA = "0x345636C", Slot = "11")]
	public override bool IsDuplicateOf(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x3456470", Offset = "0x3456470", VA = "0x3456470", Slot = "12")]
	public override bool CanFinishWith(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x3456478", Offset = "0x3456478", VA = "0x3456478", Slot = "13")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x345656C", Offset = "0x345656C", VA = "0x345656C")]
	private void OnLoadedRebateOptions(SDKIAP.RebateOption[] rebateOptions, ErrorCode errorCode, string errorMessage)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x34566A4", Offset = "0x34566A4", VA = "0x34566A4", Slot = "14")]
	protected override void Succeed()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x345677C", Offset = "0x345677C", VA = "0x345677C", Slot = "15")]
	protected override void Fail()
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x3456854", Offset = "0x3456854", VA = "0x3456854", Slot = "16")]
	protected override void Destroy()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x34568E4", Offset = "0x34568E4", VA = "0x34568E4")]
	private static string _003CIdentifySelf_003Em__0(long id)
	{
		return null;
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x3456904", Offset = "0x3456904", VA = "0x3456904")]
	private void _003CSucceed_003Em__1(LoadSomeRebateOptions i)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x34569B8", Offset = "0x34569B8", VA = "0x34569B8")]
	private void _003CFail_003Em__2(LoadSomeRebateOptions i)
	{
	}
}
