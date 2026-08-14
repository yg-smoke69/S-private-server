using System;
using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x200006C")]
internal class RedeemRebateOption : SDKIAPTaskInstance
{
	[Token(Token = "0x4000260")]
	[FieldOffset(Offset = "0x14")]
	public int RebateID;

	[Token(Token = "0x4000261")]
	[FieldOffset(Offset = "0x18")]
	private SDKIAP.RebateRedeemResult[] _results;

	[Token(Token = "0x4000262")]
	[FieldOffset(Offset = "0x1C")]
	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateRedeemResult[]> OnRedeemed;

	[Token(Token = "0x17000066")]
	public override SDKIAPTask Task
	{
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x34589E0", Offset = "0x34589E0", VA = "0x34589E0", Slot = "4")]
		get
		{
			return default(SDKIAPTask);
		}
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x34589DC", Offset = "0x34589DC", VA = "0x34589DC")]
	public RedeemRebateOption(SDKIAPTaskInfo info)
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x34589E8", Offset = "0x34589E8", VA = "0x34589E8", Slot = "9")]
	internal override string IdentifySelf()
	{
		return null;
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x3458AA8", Offset = "0x3458AA8", VA = "0x3458AA8", Slot = "11")]
	public sealed override bool IsDuplicateOf(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x3458AB0", Offset = "0x3458AB0", VA = "0x3458AB0", Slot = "12")]
	public sealed override bool CanFinishWith(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x3458AB8", Offset = "0x3458AB8", VA = "0x3458AB8", Slot = "13")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x3458C04", Offset = "0x3458C04", VA = "0x3458C04")]
	private void OnRedeemedRebateOptions(SDKIAP.RebateRedeemResult[] results, ErrorCode errorCode, string errorMessage)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x3458D3C", Offset = "0x3458D3C", VA = "0x3458D3C", Slot = "14")]
	protected override void Succeed()
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x3458DDC", Offset = "0x3458DDC", VA = "0x3458DDC", Slot = "15")]
	protected override void Fail()
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x3458E7C", Offset = "0x3458E7C", VA = "0x3458E7C", Slot = "16")]
	protected override void Destroy()
	{
	}
}
