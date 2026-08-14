using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20000C0")]
public class BanReasonDataManager : SingletonModule<BanReasonDataManager>
{
	[Token(Token = "0x20000C1")]
	private sealed class _003CGetBanReasonDesc_003Ec__AnonStorey0
	{
		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0x8")]
		internal EAccount.BanReason reasonId;

		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0xC")]
		internal bool timeLimited;

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x2E4FD1C", Offset = "0x2E4FD1C", VA = "0x2E4FD1C")]
		public _003CGetBanReasonDesc_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x2E504AC", Offset = "0x2E504AC", VA = "0x2E504AC")]
		internal bool _003C_003Em__0(BanReasonData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000C2")]
	private sealed class _003CGetBanReasonUrl_003Ec__AnonStorey1
	{
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x8")]
		internal EAccount.BanReason reasonId;

		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0xC")]
		internal string Country;

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x2E500D0", Offset = "0x2E500D0", VA = "0x2E500D0")]
		public _003CGetBanReasonUrl_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x2E50504", Offset = "0x2E50504", VA = "0x2E50504")]
		internal bool _003C_003Em__0(BanInfoUrlData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000C3")]
	private sealed class _003CGetDefaultUrl_003Ec__AnonStorey2
	{
		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x8")]
		internal EAccount.BanReason reasonId;

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x2E50474", Offset = "0x2E50474", VA = "0x2E50474")]
		public _003CGetDefaultUrl_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x2E50564", Offset = "0x2E50564", VA = "0x2E50564")]
		internal bool _003C_003Em__0(BanInfoUrlData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40004A2")]
	[FieldOffset(Offset = "0xC")]
	public List<BanReasonData> m_BanReasonDataList;

	[Token(Token = "0x40004A3")]
	[FieldOffset(Offset = "0x10")]
	public List<BanInfoUrlData> m_BanInfoUrlDataList;

	[Token(Token = "0x40004A4")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<BanInfoUrlData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600055D")]
	[Address(RVA = "0x2E4F778", Offset = "0x2E4F778", VA = "0x2E4F778")]
	public BanReasonDataManager()
	{
	}

	[Token(Token = "0x600055E")]
	[Address(RVA = "0x2E4F808", Offset = "0x2E4F808", VA = "0x2E4F808", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x2E4F990", Offset = "0x2E4F990", VA = "0x2E4F990", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x2E4FA70", Offset = "0x2E4FA70", VA = "0x2E4FA70")]
	public string GetBanReasonDesc(EAccount.BanReason reasonId, uint timeStamp)
	{
		return null;
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x2E4FD9C", Offset = "0x2E4FD9C", VA = "0x2E4FD9C")]
	public string GetBanReasonUrl(EAccount.BanReason reasonId)
	{
		return null;
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x2E500D8", Offset = "0x2E500D8", VA = "0x2E500D8")]
	public string GetDefaultUrl(EAccount.BanReason reasonId)
	{
		return null;
	}

	[Token(Token = "0x6000563")]
	[Address(RVA = "0x2E4FD24", Offset = "0x2E4FD24", VA = "0x2E4FD24")]
	private EAccount.BanReason ModifyBanReason(EAccount.BanReason banReason)
	{
		return default(EAccount.BanReason);
	}

	[Token(Token = "0x6000564")]
	[Address(RVA = "0x2E5047C", Offset = "0x2E5047C", VA = "0x2E5047C")]
	private static bool _003CGetDefaultUrl_003Em__0(BanInfoUrlData x)
	{
		return default(bool);
	}
}
