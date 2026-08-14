using System;
using Il2CppDummyDll;

namespace GCommon.Ads;

[Token(Token = "0x2003F11")]
public class AdsManager
{
	[Token(Token = "0x2003F12")]
	private sealed class _003CLog_003Ec__AnonStorey0
	{
		[Token(Token = "0x401A9D3")]
		[FieldOffset(Offset = "0x8")]
		internal string content;

		[Token(Token = "0x401A9D4")]
		[FieldOffset(Offset = "0xC")]
		internal AdsManager _0024this;

		[Token(Token = "0x6019AF5")]
		[Address(RVA = "0x26B23B8", Offset = "0x26B23B8", VA = "0x26B23B8")]
		public _003CLog_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6019AF6")]
		[Address(RVA = "0x26B24E0", Offset = "0x26B24E0", VA = "0x26B24E0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2003F13")]
	private sealed class _003CLogError_003Ec__AnonStorey1
	{
		[Token(Token = "0x401A9D5")]
		[FieldOffset(Offset = "0x8")]
		internal string content;

		[Token(Token = "0x401A9D6")]
		[FieldOffset(Offset = "0xC")]
		internal AdsManager _0024this;

		[Token(Token = "0x6019AF7")]
		[Address(RVA = "0x26B24D8", Offset = "0x26B24D8", VA = "0x26B24D8")]
		public _003CLogError_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6019AF8")]
		[Address(RVA = "0x26B2574", Offset = "0x26B2574", VA = "0x26B2574")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x401A9D0")]
	[FieldOffset(Offset = "0x0")]
	private static AdsManager _I;

	[Token(Token = "0x401A9D1")]
	[FieldOffset(Offset = "0x8")]
	private Action<string> _Log;

	[Token(Token = "0x401A9D2")]
	[FieldOffset(Offset = "0xC")]
	private Action<string> _LogError;

	[Token(Token = "0x17001C17")]
	public static AdsManager I
	{
		[Token(Token = "0x6019AF0")]
		[Address(RVA = "0x26B2150", Offset = "0x26B2150", VA = "0x26B2150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019AEF")]
	[Address(RVA = "0x26B2148", Offset = "0x26B2148", VA = "0x26B2148")]
	private AdsManager()
	{
	}

	[Token(Token = "0x6019AF1")]
	[Address(RVA = "0x26B21F0", Offset = "0x26B21F0", VA = "0x26B21F0")]
	public BaseRewardedVideoAds GetRewardedVideoAds()
	{
		return null;
	}

	[Token(Token = "0x6019AF2")]
	[Address(RVA = "0x26B2294", Offset = "0x26B2294", VA = "0x26B2294")]
	public void SetLogCallbacks(Action<string> log, Action<string> logError)
	{
	}

	[Token(Token = "0x6019AF3")]
	[Address(RVA = "0x26B22A0", Offset = "0x26B22A0", VA = "0x26B22A0")]
	internal void Log(string content)
	{
	}

	[Token(Token = "0x6019AF4")]
	[Address(RVA = "0x26B23C0", Offset = "0x26B23C0", VA = "0x26B23C0")]
	internal void LogError(string content)
	{
	}
}
