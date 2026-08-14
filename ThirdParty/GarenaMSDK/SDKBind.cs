using System;
using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x200002B")]
public class SDKBind
{
	[Token(Token = "0x200002C")]
	public delegate void GetBindSessionSuccessCb(BindSessionRsp rsp);

	[Token(Token = "0x200002D")]
	public delegate void GetBindSessionFaildCb(ErrorCode errorCode);

	[Token(Token = "0x200002E")]
	public delegate void ClearThirdPartySessionCb();

	[Serializable]
	[Token(Token = "0x200002F")]
	public class PlatformBindingInfo
	{
		[Serializable]
		[Token(Token = "0x2000030")]
		public class PlatformAccount
		{
			[Token(Token = "0x4000133")]
			[FieldOffset(Offset = "0x8")]
			public AccountPlatform Platform;

			[Token(Token = "0x4000134")]
			[FieldOffset(Offset = "0x10")]
			public ulong UID;

			[Token(Token = "0x4000135")]
			[FieldOffset(Offset = "0x18")]
			public uint CreateTime;

			[Token(Token = "0x4000136")]
			[FieldOffset(Offset = "0x1C")]
			public string Nickname;

			[Token(Token = "0x4000137")]
			[FieldOffset(Offset = "0x20")]
			public int Gender;

			[Token(Token = "0x4000138")]
			public const int GENDER_UNKNOWN = 0;

			[Token(Token = "0x4000139")]
			public const int GENDER_MALE = 1;

			[Token(Token = "0x400013A")]
			public const int GENDER_FEMAILE = 2;

			[Token(Token = "0x400013B")]
			[FieldOffset(Offset = "0x24")]
			public string IconUrl;

			[Token(Token = "0x600018F")]
			[Address(RVA = "0x3459C9C", Offset = "0x3459C9C", VA = "0x3459C9C")]
			public PlatformAccount()
			{
			}
		}

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x8")]
		public int[] AvailablePlatforms;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0xC")]
		public PlatformAccount[] PlatformAccounts;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<PlatformBindingInfo_Android.BoundAccountInfo, PlatformAccount> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x34597D4", Offset = "0x34597D4", VA = "0x34597D4")]
		public PlatformBindingInfo(PlatformBindingInfo_Android android)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x3459A64", Offset = "0x3459A64", VA = "0x3459A64")]
		private static AccountPlatform _(int p)
		{
			return default(AccountPlatform);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x3459AB4", Offset = "0x3459AB4", VA = "0x3459AB4")]
		private static PlatformAccount _003CPlatformBindingInfo_003Em__0(PlatformBindingInfo_Android.BoundAccountInfo account)
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000031")]
	public class PlatformBindingInfo_Android
	{
		[Serializable]
		[Token(Token = "0x2000032")]
		public class BoundAccountInfo
		{
			[Serializable]
			[Token(Token = "0x2000033")]
			public class UserInfo
			{
				[Token(Token = "0x4000142")]
				[FieldOffset(Offset = "0x8")]
				public string nickname;

				[Token(Token = "0x4000143")]
				[FieldOffset(Offset = "0xC")]
				public int gender;

				[Token(Token = "0x4000144")]
				[FieldOffset(Offset = "0x10")]
				public string icon;

				[Token(Token = "0x6000192")]
				[Address(RVA = "0x3459CB4", Offset = "0x3459CB4", VA = "0x3459CB4")]
				public UserInfo()
				{
				}
			}

			[Token(Token = "0x400013E")]
			[FieldOffset(Offset = "0x8")]
			public int platform;

			[Token(Token = "0x400013F")]
			[FieldOffset(Offset = "0x10")]
			public ulong uid;

			[Token(Token = "0x4000140")]
			[FieldOffset(Offset = "0x18")]
			public uint create_time;

			[Token(Token = "0x4000141")]
			[FieldOffset(Offset = "0x1C")]
			public UserInfo user_info;

			[Token(Token = "0x6000191")]
			[Address(RVA = "0x3459CAC", Offset = "0x3459CAC", VA = "0x3459CAC")]
			public BoundAccountInfo()
			{
			}
		}

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x8")]
		public int[] available_platforms;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0xC")]
		public BoundAccountInfo[] bounded_accounts;

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x3459CA4", Offset = "0x3459CA4", VA = "0x3459CA4")]
		public PlatformBindingInfo_Android()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000034")]
	public class PerformPlatformBindingResult
	{
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x8")]
		public int result;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0xC")]
		public string error;

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x3459A5C", Offset = "0x3459A5C", VA = "0x3459A5C")]
		public PerformPlatformBindingResult()
		{
		}
	}

	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x8")]
	protected GetBindSessionSuccessCb getBindSessionSuccessCb;

	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0xC")]
	protected GetBindSessionFaildCb getBindSessionFaildCb;

	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x10")]
	protected ClearThirdPartySessionCb clearThirdPartySessionCb;

	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x14")]
	public string bindOpenId;

	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x18")]
	public string bindAccessToken;

	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x1C")]
	public AccountPlatform bindPlatform;

	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x20")]
	private Action<PlatformBindingInfo> _OnGetPlatformBindingInfo;

	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x24")]
	private Action<BindSessionRsp> _OnGetPlatformBindingSessionResult;

	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x28")]
	private Action<PerformPlatformBindingResult> _OnPerformPlatformBindingComplete;

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x344CF40", Offset = "0x344CF40", VA = "0x344CF40")]
	public SDKBind()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x344ED98", Offset = "0x344ED98", VA = "0x344ED98")]
	public void GetBindSession(AccountPlatform accountType, GetBindSessionSuccessCb getBindSessionSuccessCb, GetBindSessionFaildCb getBindSessionFaildCb)
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x344F1AC", Offset = "0x344F1AC", VA = "0x344F1AC")]
	public void ResetGuest()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x344EF70", Offset = "0x344EF70", VA = "0x344EF70")]
	public void OnGetBindSession(string msg)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x34594EC", Offset = "0x34594EC", VA = "0x34594EC")]
	public bool CanClearThirdPartySession()
	{
		return default(bool);
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x34594F4", Offset = "0x34594F4", VA = "0x34594F4")]
	public void ClearThirdPartySession(ClearThirdPartySessionCb cb)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x344F100", Offset = "0x344F100", VA = "0x344F100")]
	public void OnClearThirdPartySession()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x344F778", Offset = "0x344F778", VA = "0x344F778")]
	public void GetPlatformBindingInfo(Action<PlatformBindingInfo> callback)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x344F9FC", Offset = "0x344F9FC", VA = "0x344F9FC")]
	public void GetPlatformBindingSession(AccountPlatform platform, Action<BindSessionRsp> callback)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x34527E0", Offset = "0x34527E0", VA = "0x34527E0")]
	public void OnGetPlatformBindingSession(string result)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x3452614", Offset = "0x3452614", VA = "0x3452614")]
	public void OnGetPlatformBindingInfoComplete_Android(string result)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x344FD04", Offset = "0x344FD04", VA = "0x344FD04")]
	public void PerformPlatformBinding(Action<PerformPlatformBindingResult> callback)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x3452988", Offset = "0x3452988", VA = "0x3452988")]
	public void OnPerformPlatformBindingComplete_Android(string result)
	{
	}
}
