using System;
using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x200006E")]
internal class LoadEventIAPItems : SDKIAPTaskInstance
{
	[Token(Token = "0x4000266")]
	[FieldOffset(Offset = "0x14")]
	public bool Localized;

	[Token(Token = "0x4000267")]
	[FieldOffset(Offset = "0x18")]
	private SDKIAP.LoadEventIAPResult _Result;

	[Token(Token = "0x4000268")]
	[FieldOffset(Offset = "0x1C")]
	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.LoadEventIAPResult> OnDone;

	[Token(Token = "0x17000068")]
	public override SDKIAPTask Task
	{
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x3453770", Offset = "0x3453770", VA = "0x3453770", Slot = "4")]
		get
		{
			return default(SDKIAPTask);
		}
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x345376C", Offset = "0x345376C", VA = "0x345376C")]
	public LoadEventIAPItems(SDKIAPTaskInfo info)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x3453778", Offset = "0x3453778", VA = "0x3453778", Slot = "9")]
	internal override string IdentifySelf()
	{
		return null;
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x345385C", Offset = "0x345385C", VA = "0x345385C", Slot = "11")]
	public override bool IsDuplicateOf(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x345394C", Offset = "0x345394C", VA = "0x345394C", Slot = "12")]
	public override bool CanFinishWith(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x3453A24", Offset = "0x3453A24", VA = "0x3453A24", Slot = "13")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x3453C44", Offset = "0x3453C44", VA = "0x3453C44")]
	private void OnLoadedEventIAPItems(SDKIAP.LoadEventIAPResult result)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x3453D94", Offset = "0x3453D94", VA = "0x3453D94", Slot = "14")]
	protected override void Succeed()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x3453E6C", Offset = "0x3453E6C", VA = "0x3453E6C", Slot = "15")]
	protected override void Fail()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x3453F44", Offset = "0x3453F44", VA = "0x3453F44", Slot = "16")]
	protected override void Destroy()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x3453FD4", Offset = "0x3453FD4", VA = "0x3453FD4")]
	private void _003CSucceed_003Em__0(LoadEventIAPItems i)
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x3454088", Offset = "0x3454088", VA = "0x3454088")]
	private void _003CFail_003Em__1(LoadEventIAPItems i)
	{
	}
}
