using System;
using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x2000066")]
internal class LoadSomeIAPItems : SDKIAPTaskInstance
{
	[Token(Token = "0x4000248")]
	[FieldOffset(Offset = "0x14")]
	public bool Localized;

	[Token(Token = "0x4000249")]
	[FieldOffset(Offset = "0x18")]
	public int[] ItemIds;

	[Token(Token = "0x400024A")]
	[FieldOffset(Offset = "0x1C")]
	public long[] RebateIds;

	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0x20")]
	public SDKIAP.IAPItem[] _Products;

	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0x24")]
	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.IAPItem[]> OnDone;

	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<int, string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400024E")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<long, string> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x17000062")]
	public override SDKIAPTask Task
	{
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x3455500", Offset = "0x3455500", VA = "0x3455500", Slot = "4")]
		get
		{
			return default(SDKIAPTask);
		}
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x34554FC", Offset = "0x34554FC", VA = "0x34554FC")]
	public LoadSomeIAPItems(SDKIAPTaskInfo info)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x3455508", Offset = "0x3455508", VA = "0x3455508", Slot = "9")]
	internal override string IdentifySelf()
	{
		return null;
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x345597C", Offset = "0x345597C", VA = "0x345597C", Slot = "11")]
	public override bool IsDuplicateOf(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x3455A80", Offset = "0x3455A80", VA = "0x3455A80", Slot = "12")]
	public override bool CanFinishWith(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x3455A88", Offset = "0x3455A88", VA = "0x3455A88", Slot = "13")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x3455C6C", Offset = "0x3455C6C", VA = "0x3455C6C")]
	private void OnLoadedIAPItems(SDKIAP.IAPItem[] items, ErrorCode errorCode, string errorMessage)
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x3455DA4", Offset = "0x3455DA4", VA = "0x3455DA4", Slot = "14")]
	protected override void Succeed()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x3455E7C", Offset = "0x3455E7C", VA = "0x3455E7C", Slot = "15")]
	protected override void Fail()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x3455F54", Offset = "0x3455F54", VA = "0x3455F54", Slot = "16")]
	protected override void Destroy()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x3455FE4", Offset = "0x3455FE4", VA = "0x3455FE4")]
	private static string _003CIdentifySelf_003Em__0(int id)
	{
		return null;
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x3456008", Offset = "0x3456008", VA = "0x3456008")]
	private static string _003CIdentifySelf_003Em__1(long id)
	{
		return null;
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x3456028", Offset = "0x3456028", VA = "0x3456028")]
	private void _003CSucceed_003Em__2(LoadSomeIAPItems i)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x34560DC", Offset = "0x34560DC", VA = "0x34560DC")]
	private void _003CFail_003Em__3(LoadSomeIAPItems i)
	{
	}
}
