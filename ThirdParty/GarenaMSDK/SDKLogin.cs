using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x2000071")]
public class SDKLogin
{
	[Token(Token = "0x2000072")]
	public delegate void LoginSuccessCb(LoginRsp rsp);

	[Token(Token = "0x2000073")]
	public delegate void LoginFailCb(ErrorCode errCode);

	[Token(Token = "0x2000074")]
	public class SAFGuestResult
	{
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x8")]
		public int result;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0xC")]
		public string msg;

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x3465FE8", Offset = "0x3465FE8", VA = "0x3465FE8")]
		public SAFGuestResult()
		{
		}
	}

	[Token(Token = "0x2000075")]
	public delegate void SAFGuestCb(SAFGuestResult result);

	[Token(Token = "0x4000271")]
	[FieldOffset(Offset = "0x8")]
	private LoginSuccessCb loginSuccessCb;

	[Token(Token = "0x4000272")]
	[FieldOffset(Offset = "0xC")]
	private LoginFailCb loginFailCb;

	[Token(Token = "0x4000273")]
	[FieldOffset(Offset = "0x10")]
	private SAFGuestCb migrateGuestCb;

	[Token(Token = "0x4000274")]
	[FieldOffset(Offset = "0x14")]
	private SAFGuestCb backupGuestCb;

	[Token(Token = "0x4000275")]
	[FieldOffset(Offset = "0x18")]
	private SAFGuestCb autosaveGuestCb;

	[Token(Token = "0x4000276")]
	public const int SAF_SUCCESS = 0;

	[Token(Token = "0x4000277")]
	public const int SAF_FAILURE = 1;

	[Token(Token = "0x4000278")]
	public const int SAF_REFUSED = 2;

	[Token(Token = "0x4000279")]
	public const int SAF_EXCEPTION = 3;

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x344CF38", Offset = "0x344CF38", VA = "0x344CF38")]
	public SDKLogin()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x344DF74", Offset = "0x344DF74", VA = "0x344DF74")]
	public AccountPlatform GetLoginRecord()
	{
		return default(AccountPlatform);
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x344E16C", Offset = "0x344E16C", VA = "0x344E16C")]
	public bool NeedGuestMigration()
	{
		return default(bool);
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x344E070", Offset = "0x344E070", VA = "0x344E070")]
	public bool SupportGuestMigration()
	{
		return default(bool);
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x344E270", Offset = "0x344E270", VA = "0x344E270")]
	public void MigrateGuest(SAFGuestCb onMigrate)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x344E464", Offset = "0x344E464", VA = "0x344E464")]
	public bool NeedGuestBackup()
	{
		return default(bool);
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x344E368", Offset = "0x344E368", VA = "0x344E368")]
	public bool SupportGuestBackup()
	{
		return default(bool);
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x344E568", Offset = "0x344E568", VA = "0x344E568")]
	public void BackupGuest(SAFGuestCb onBackup)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x344E668", Offset = "0x344E668", VA = "0x344E668")]
	public void AutosaveGuest(SAFGuestCb onAutosave)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x344F2A0", Offset = "0x344F2A0", VA = "0x344F2A0")]
	public void OnMigrateGuestResult(string result)
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x344F3DC", Offset = "0x344F3DC", VA = "0x344F3DC")]
	public void OnBackupGuestResult(string result)
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x344F518", Offset = "0x344F518", VA = "0x344F518")]
	public void OnAutosaveGuestResult(string result)
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x344E764", Offset = "0x344E764", VA = "0x344E764")]
	public bool PlatformAvailable(AccountPlatform platform)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x344E864", Offset = "0x344E864", VA = "0x344E864")]
	public void Login(AccountPlatform accountPlatform, bool autoLogin, LoginSuccessCb loginSuccess, LoginFailCb loginFail)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x344EA7C", Offset = "0x344EA7C", VA = "0x344EA7C")]
	public void Logout()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x344EB70", Offset = "0x344EB70", VA = "0x344EB70")]
	public void OnLogin(string msg)
	{
	}
}
