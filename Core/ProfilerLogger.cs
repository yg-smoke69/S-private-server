using Il2CppDummyDll;

[Token(Token = "0x2003B2A")]
public class ProfilerLogger
{
	[Token(Token = "0x40192C8")]
	[FieldOffset(Offset = "0x0")]
	private static float m_StartTime;

	[Token(Token = "0x40192C9")]
	[FieldOffset(Offset = "0x4")]
	private static int m_FrameCount;

	[Token(Token = "0x40192CA")]
	[FieldOffset(Offset = "0x8")]
	private static float m_LastSecondTime;

	[Token(Token = "0x40192CB")]
	[FieldOffset(Offset = "0xC")]
	private static float m_LastFrameTime;

	[Token(Token = "0x60177D5")]
	[Address(RVA = "0x1E30FB0", Offset = "0x1E30FB0", VA = "0x1E30FB0")]
	public ProfilerLogger()
	{
	}

	[Token(Token = "0x60177D6")]
	[Address(RVA = "0x1E30FB8", Offset = "0x1E30FB8", VA = "0x1E30FB8")]
	public static void Flush()
	{
	}

	[Token(Token = "0x60177D7")]
	[Address(RVA = "0x1E31150", Offset = "0x1E31150", VA = "0x1E31150")]
	public static void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60177D8")]
	[Address(RVA = "0x1E31330", Offset = "0x1E31330", VA = "0x1E31330")]
	public static void Update()
	{
	}

	[Token(Token = "0x60177D9")]
	[Address(RVA = "0x1E31764", Offset = "0x1E31764", VA = "0x1E31764")]
	public static void Log(object message)
	{
	}

	[Token(Token = "0x60177DA")]
	[Address(RVA = "0x1E31B70", Offset = "0x1E31B70", VA = "0x1E31B70")]
	public static void StartLoading()
	{
	}

	[Token(Token = "0x60177DB")]
	[Address(RVA = "0x1E31C14", Offset = "0x1E31C14", VA = "0x1E31C14")]
	public static void EndLoading()
	{
	}

	[Token(Token = "0x60177DC")]
	[Address(RVA = "0x1E31834", Offset = "0x1E31834", VA = "0x1E31834")]
	private static string ProfileFormatMessage(object message)
	{
		return null;
	}

	[Token(Token = "0x60177DD")]
	[Address(RVA = "0x1E319EC", Offset = "0x1E319EC", VA = "0x1E319EC")]
	public static void WriteToProfileFile(string message)
	{
	}
}
