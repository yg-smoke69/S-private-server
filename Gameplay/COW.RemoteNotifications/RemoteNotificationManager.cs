using Il2CppDummyDll;

namespace COW.RemoteNotifications;

[Token(Token = "0x2001DCF")]
public class RemoteNotificationManager
{
	[Token(Token = "0x400BCB9")]
	[FieldOffset(Offset = "0x0")]
	private static RemoteNotificationManager _I;

	[Token(Token = "0x17000F06")]
	public static RemoteNotificationManager I
	{
		[Token(Token = "0x6008E38")]
		[Address(RVA = "0x1974B18", Offset = "0x1974B18", VA = "0x1974B18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008E37")]
	[Address(RVA = "0x1974B10", Offset = "0x1974B10", VA = "0x1974B10")]
	protected RemoteNotificationManager()
	{
	}

	[Token(Token = "0x6008E39")]
	[Address(RVA = "0x1976148", Offset = "0x1976148", VA = "0x1976148")]
	protected static void _Log(string log)
	{
	}

	[Token(Token = "0x6008E3A")]
	[Address(RVA = "0x19761CC", Offset = "0x19761CC", VA = "0x19761CC")]
	protected static void _LogError(string log)
	{
	}

	[Token(Token = "0x6008E3B")]
	[Address(RVA = "0x1976250", Offset = "0x1976250", VA = "0x1976250")]
	internal static void Log(string log)
	{
	}

	[Token(Token = "0x6008E3C")]
	[Address(RVA = "0x1976254", Offset = "0x1976254", VA = "0x1976254", Slot = "4")]
	public virtual void BeforeLoginSDK()
	{
	}

	[Token(Token = "0x6008E3D")]
	[Address(RVA = "0x1976258", Offset = "0x1976258", VA = "0x1976258", Slot = "5")]
	public virtual void AfterLoginSDK()
	{
	}

	[Token(Token = "0x6008E3E")]
	[Address(RVA = "0x197625C", Offset = "0x197625C", VA = "0x197625C", Slot = "6")]
	public virtual void BeforeLoginServer()
	{
	}

	[Token(Token = "0x6008E3F")]
	[Address(RVA = "0x1976260", Offset = "0x1976260", VA = "0x1976260", Slot = "7")]
	public virtual void AfterLoginServer()
	{
	}

	[Token(Token = "0x6008E40")]
	[Address(RVA = "0x1976264", Offset = "0x1976264", VA = "0x1976264", Slot = "8")]
	public virtual void BeforeLogoutServer()
	{
	}

	[Token(Token = "0x6008E41")]
	[Address(RVA = "0x1976268", Offset = "0x1976268", VA = "0x1976268", Slot = "9")]
	public virtual void AfterLogoutServer()
	{
	}

	[Token(Token = "0x6008E42")]
	[Address(RVA = "0x197626C", Offset = "0x197626C", VA = "0x197626C", Slot = "10")]
	public virtual void BeforeLogoutSDK()
	{
	}

	[Token(Token = "0x6008E43")]
	[Address(RVA = "0x1976270", Offset = "0x1976270", VA = "0x1976270", Slot = "11")]
	public virtual void AfterLogoutSDK()
	{
	}

	[Token(Token = "0x6008E44")]
	[Address(RVA = "0x1976274", Offset = "0x1976274", VA = "0x1976274", Slot = "12")]
	public virtual void BeforeChangeLanguage()
	{
	}

	[Token(Token = "0x6008E45")]
	[Address(RVA = "0x1976278", Offset = "0x1976278", VA = "0x1976278", Slot = "13")]
	public virtual void AfterChangeLanguage()
	{
	}

	[Token(Token = "0x6008E46")]
	[Address(RVA = "0x197627C", Offset = "0x197627C", VA = "0x197627C", Slot = "14")]
	public virtual void BeforeChangeFirstTimePaid()
	{
	}

	[Token(Token = "0x6008E47")]
	[Address(RVA = "0x1976280", Offset = "0x1976280", VA = "0x1976280", Slot = "15")]
	public virtual void AfterChangeFirstTimePaid()
	{
	}

	[Token(Token = "0x6008E48")]
	[Address(RVA = "0x1976284", Offset = "0x1976284", VA = "0x1976284", Slot = "16")]
	public virtual void BeforeChangeClanID()
	{
	}

	[Token(Token = "0x6008E49")]
	[Address(RVA = "0x1976288", Offset = "0x1976288", VA = "0x1976288", Slot = "17")]
	public virtual void AfterChangeClanID()
	{
	}

	[Token(Token = "0x6008E4A")]
	[Address(RVA = "0x197628C", Offset = "0x197628C", VA = "0x197628C", Slot = "18")]
	public virtual void BeforeChangeElitePassBadgeNumber()
	{
	}

	[Token(Token = "0x6008E4B")]
	[Address(RVA = "0x1976290", Offset = "0x1976290", VA = "0x1976290", Slot = "19")]
	public virtual void AfterChangeElitePassBadgeNumber()
	{
	}

	[Token(Token = "0x6008E4C")]
	[Address(RVA = "0x1976294", Offset = "0x1976294", VA = "0x1976294", Slot = "20")]
	public virtual void BeforeChangePlayerLevel()
	{
	}

	[Token(Token = "0x6008E4D")]
	[Address(RVA = "0x1976298", Offset = "0x1976298", VA = "0x1976298", Slot = "21")]
	public virtual void AfterChangePlayerLevel()
	{
	}

	[Token(Token = "0x6008E4E")]
	[Address(RVA = "0x197629C", Offset = "0x197629C", VA = "0x197629C", Slot = "22")]
	public virtual void BeforeChangeGamesPlayedInRankedMatch()
	{
	}

	[Token(Token = "0x6008E4F")]
	[Address(RVA = "0x19762A0", Offset = "0x19762A0", VA = "0x19762A0", Slot = "23")]
	public virtual void AfterChangeGamesPlayedInRankedMatch()
	{
	}
}
