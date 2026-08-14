using System;
using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x2000065")]
internal class LoadRebateOptions : SDKIAPTaskInstance
{
	[Token(Token = "0x4000246")]
	[FieldOffset(Offset = "0x14")]
	private SDKIAP.RebateOption[] _rebateOptions;

	[Token(Token = "0x4000247")]
	[FieldOffset(Offset = "0x18")]
	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateOption[]> OnDone;

	[Token(Token = "0x17000061")]
	public override SDKIAPTask Task
	{
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x3454CF4", Offset = "0x3454CF4", VA = "0x3454CF4", Slot = "4")]
		get
		{
			return default(SDKIAPTask);
		}
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x3454CF0", Offset = "0x3454CF0", VA = "0x3454CF0")]
	public LoadRebateOptions(SDKIAPTaskInfo info)
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x3454CFC", Offset = "0x3454CFC", VA = "0x3454CFC", Slot = "9")]
	internal override string IdentifySelf()
	{
		return null;
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x3454DB0", Offset = "0x3454DB0", VA = "0x3454DB0", Slot = "11")]
	public override bool IsDuplicateOf(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x3454E74", Offset = "0x3454E74", VA = "0x3454E74", Slot = "12")]
	public override bool CanFinishWith(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x3454F30", Offset = "0x3454F30", VA = "0x3454F30", Slot = "13")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x345501C", Offset = "0x345501C", VA = "0x345501C")]
	private void OnLoadedRebateOptions(SDKIAP.RebateOption[] rebateOptions, ErrorCode errorCode, string errorMessage)
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x3455154", Offset = "0x3455154", VA = "0x3455154", Slot = "14")]
	protected override void Succeed()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x345522C", Offset = "0x345522C", VA = "0x345522C", Slot = "15")]
	protected override void Fail()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x3455304", Offset = "0x3455304", VA = "0x3455304", Slot = "16")]
	protected override void Destroy()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x3455394", Offset = "0x3455394", VA = "0x3455394")]
	private void _003CSucceed_003Em__0(LoadRebateOptions i)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x3455448", Offset = "0x3455448", VA = "0x3455448")]
	private void _003CFail_003Em__1(LoadRebateOptions i)
	{
	}
}
