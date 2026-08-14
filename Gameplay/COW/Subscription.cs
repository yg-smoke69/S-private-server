using GarenaMSDK;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D79")]
public class Subscription
{
	[Token(Token = "0x4011728")]
	[FieldOffset(Offset = "0x8")]
	private int _LastPaymentTime;

	[Token(Token = "0x4011729")]
	[FieldOffset(Offset = "0xC")]
	private int _NextPaymentTime;

	[Token(Token = "0x401172A")]
	[FieldOffset(Offset = "0x10")]
	private SubscriptionPeriod _Period;

	[Token(Token = "0x401172B")]
	[FieldOffset(Offset = "0x18")]
	private long _GracePeriodExpiryTime;

	[Token(Token = "0x401172C")]
	[FieldOffset(Offset = "0x20")]
	private long _OnHoldSince;

	[Token(Token = "0x401172D")]
	[FieldOffset(Offset = "0x28")]
	public SubscriptionStatus Status;

	[Token(Token = "0x401172E")]
	public const string PAYMENT_TIME_FORMAT_TO_MINS = "yyyy-MM-dd H:mm";

	[Token(Token = "0x401172F")]
	public const string PAYMENT_TIME_FORMAT_TO_DATE = "yyyy-MM-dd";

	[Token(Token = "0x4011730")]
	public const int TEST_RENEWAL_INTERVAL_SECS = 300;

	[Token(Token = "0x1700137C")]
	public int LastPaymentTime
	{
		[Token(Token = "0x6013091")]
		[Address(RVA = "0x2890474", Offset = "0x2890474", VA = "0x2890474")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6013092")]
		[Address(RVA = "0x28904CC", Offset = "0x28904CC", VA = "0x28904CC")]
		set
		{
		}
	}

	[Token(Token = "0x1700137D")]
	public SubscriptionPeriod Period
	{
		[Token(Token = "0x6013093")]
		[Address(RVA = "0x289041C", Offset = "0x289041C", VA = "0x289041C")]
		get
		{
			return default(SubscriptionPeriod);
		}
		[Token(Token = "0x6013094")]
		[Address(RVA = "0x2890538", Offset = "0x2890538", VA = "0x2890538")]
		set
		{
		}
	}

	[Token(Token = "0x1700137E")]
	public int NextPaymentTime
	{
		[Token(Token = "0x6013098")]
		[Address(RVA = "0x28907A8", Offset = "0x28907A8", VA = "0x28907A8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700137F")]
	public long GracePeriodExpiryTime
	{
		[Token(Token = "0x601309E")]
		[Address(RVA = "0x2890C9C", Offset = "0x2890C9C", VA = "0x2890C9C")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001380")]
	public bool IsInGracePeriod
	{
		[Token(Token = "0x601309F")]
		[Address(RVA = "0x2890CF4", Offset = "0x2890CF4", VA = "0x2890CF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001381")]
	public long OnHoldSince
	{
		[Token(Token = "0x60130A0")]
		[Address(RVA = "0x2890DE0", Offset = "0x2890DE0", VA = "0x2890DE0")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001382")]
	public bool IsOnHold
	{
		[Token(Token = "0x60130A1")]
		[Address(RVA = "0x2890E38", Offset = "0x2890E38", VA = "0x2890E38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x601308F")]
	[Address(RVA = "0x289002C", Offset = "0x289002C", VA = "0x289002C")]
	public Subscription()
	{
	}

	[Token(Token = "0x6013090")]
	[Address(RVA = "0x2890034", Offset = "0x2890034", VA = "0x2890034")]
	private void _UpdateNextPaymentTime()
	{
	}

	[Token(Token = "0x6013095")]
	[Address(RVA = "0x28905A4", Offset = "0x28905A4", VA = "0x28905A4")]
	public static Subscription _(SDKIAP.Subscription subscription)
	{
		return null;
	}

	[Token(Token = "0x6013096")]
	[Address(RVA = "0x28903AC", Offset = "0x28903AC", VA = "0x28903AC")]
	public bool HasLastPaymentTime()
	{
		return default(bool);
	}

	[Token(Token = "0x6013097")]
	[Address(RVA = "0x2890738", Offset = "0x2890738", VA = "0x2890738")]
	public bool HasNextPaymentTime()
	{
		return default(bool);
	}

	[Token(Token = "0x6013099")]
	[Address(RVA = "0x2890800", Offset = "0x2890800", VA = "0x2890800")]
	private bool? PaymentOverdue()
	{
		return null;
	}

	[Token(Token = "0x601309A")]
	[Address(RVA = "0x2890928", Offset = "0x2890928", VA = "0x2890928")]
	public bool WillBegin()
	{
		return default(bool);
	}

	[Token(Token = "0x601309B")]
	[Address(RVA = "0x2890994", Offset = "0x2890994", VA = "0x2890994")]
	public bool WithinPeriod()
	{
		return default(bool);
	}

	[Token(Token = "0x601309C")]
	[Address(RVA = "0x2890AAC", Offset = "0x2890AAC", VA = "0x2890AAC")]
	public bool HasEnded()
	{
		return default(bool);
	}

	[Token(Token = "0x601309D")]
	[Address(RVA = "0x2890C20", Offset = "0x2890C20", VA = "0x2890C20")]
	public bool CanSubscribe()
	{
		return default(bool);
	}

	[Token(Token = "0x60130A2")]
	[Address(RVA = "0x2890EA8", Offset = "0x2890EA8", VA = "0x2890EA8")]
	public static string Brief(Subscription subscription)
	{
		return null;
	}

	[Token(Token = "0x60130A3")]
	[Address(RVA = "0x289125C", Offset = "0x289125C", VA = "0x289125C")]
	public static string Detail(Subscription subscription)
	{
		return null;
	}
}
