using Il2CppDummyDll;

[Token(Token = "0x2003DD4")]
public class AkLogger
{
	[Token(Token = "0x2003DD5")]
	public delegate void ErrorLoggerInteropDelegate(string message);

	[Token(Token = "0x401A429")]
	[FieldOffset(Offset = "0x0")]
	private static AkLogger ms_Instance;

	[Token(Token = "0x401A42A")]
	[FieldOffset(Offset = "0x8")]
	private ErrorLoggerInteropDelegate errorLoggerDelegate;

	[Token(Token = "0x401A42B")]
	[FieldOffset(Offset = "0x4")]
	private static ErrorLoggerInteropDelegate _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x17001B2B")]
	public static AkLogger Instance
	{
		[Token(Token = "0x601929E")]
		[Address(RVA = "0x36B2190", Offset = "0x36B2190", VA = "0x36B2190")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601929D")]
	[Address(RVA = "0x36B1F00", Offset = "0x36B1F00", VA = "0x36B1F00")]
	private AkLogger()
	{
	}

	[Token(Token = "0x601929F")]
	[Address(RVA = "0x36B221C", Offset = "0x36B221C", VA = "0x36B221C", Slot = "1")]
	~AkLogger()
	{
	}

	[Token(Token = "0x60192A0")]
	[Address(RVA = "0x36B23EC", Offset = "0x36B23EC", VA = "0x36B23EC")]
	public void Init()
	{
	}

	[Token(Token = "0x60192A1")]
	[Address(RVA = "0x36B1E30", Offset = "0x36B1E30", VA = "0x36B1E30")]
	public static void WwiseInternalLogError(string message)
	{
	}

	[Token(Token = "0x60192A2")]
	[Address(RVA = "0x36B23F0", Offset = "0x36B23F0", VA = "0x36B23F0")]
	public static void Message(string message)
	{
	}

	[Token(Token = "0x60192A3")]
	[Address(RVA = "0x36B24C0", Offset = "0x36B24C0", VA = "0x36B24C0")]
	public static void Warning(string message)
	{
	}

	[Token(Token = "0x60192A4")]
	[Address(RVA = "0x36B2590", Offset = "0x36B2590", VA = "0x36B2590")]
	public static void Error(string message)
	{
	}
}
