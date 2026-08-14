using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003B27")]
public class Debugger
{
	[Token(Token = "0x40192BC")]
	[FieldOffset(Offset = "0x0")]
	public static bool EnableLog;

	[Token(Token = "0x40192BD")]
	[FieldOffset(Offset = "0x1")]
	public static bool EnableProfilerLog;

	[Token(Token = "0x40192BE")]
	[FieldOffset(Offset = "0x2")]
	public static bool LogToFile;

	[Token(Token = "0x40192BF")]
	[FieldOffset(Offset = "0x4")]
	public static LogLevelType LogLevel;

	[Token(Token = "0x60177AD")]
	[Address(RVA = "0x23166C8", Offset = "0x23166C8", VA = "0x23166C8")]
	public Debugger()
	{
	}

	[Token(Token = "0x60177AE")]
	[Address(RVA = "0x23166D0", Offset = "0x23166D0", VA = "0x23166D0")]
	public static void DisableLogFor64bit(bool disable)
	{
	}

	[Token(Token = "0x60177AF")]
	[Address(RVA = "0x2316984", Offset = "0x2316984", VA = "0x2316984")]
	public static void Flush()
	{
	}

	[Token(Token = "0x60177B0")]
	[Address(RVA = "0x2316B4C", Offset = "0x2316B4C", VA = "0x2316B4C")]
	public static void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60177B1")]
	[Address(RVA = "0x230ADB8", Offset = "0x230ADB8", VA = "0x230ADB8")]
	public static void Log(object message)
	{
	}

	[Token(Token = "0x60177B2")]
	[Address(RVA = "0x2316EDC", Offset = "0x2316EDC", VA = "0x2316EDC")]
	public static void Log(object message, Object ownerInHierachy)
	{
	}

	[Token(Token = "0x60177B3")]
	[Address(RVA = "0x2316FA4", Offset = "0x2316FA4", VA = "0x2316FA4")]
	public static void Log(object message, LogColor type, [Optional] Object ownerInHierachy)
	{
	}

	[Token(Token = "0x60177B4")]
	[Address(RVA = "0x23173CC", Offset = "0x23173CC", VA = "0x23173CC")]
	public static void LogVerbose(object message, [Optional] Object ownerInHierachy)
	{
	}

	[Token(Token = "0x60177B5")]
	[Address(RVA = "0x2317494", Offset = "0x2317494", VA = "0x2317494")]
	public static void LogErrorIf(bool condition, object message)
	{
	}

	[Token(Token = "0x60177B6")]
	[Address(RVA = "0x2317520", Offset = "0x2317520", VA = "0x2317520")]
	public static void LogError(object message)
	{
	}

	[Token(Token = "0x60177B7")]
	[Address(RVA = "0x23175E4", Offset = "0x23175E4", VA = "0x23175E4")]
	public static void LogError(object message, Object ownerInHierachy)
	{
	}

	[Token(Token = "0x60177B8")]
	[Address(RVA = "0x23176AC", Offset = "0x23176AC", VA = "0x23176AC")]
	public static void LogErrorForcely(object message, [Optional] Object ownerInHierachy)
	{
	}

	[Token(Token = "0x60177B9")]
	[Address(RVA = "0x2317738", Offset = "0x2317738", VA = "0x2317738")]
	public static void LogWarning(object message, [Optional] Object ownerInHierachy)
	{
	}

	[Token(Token = "0x60177BA")]
	[Address(RVA = "0x2316D60", Offset = "0x2316D60", VA = "0x2316D60")]
	private static void LogInternal(LogLevelType level, object message, Object ownerInHierachy)
	{
	}

	[Token(Token = "0x60177BB")]
	[Address(RVA = "0x231711C", Offset = "0x231711C", VA = "0x231711C")]
	private static string FormatMessage(object message)
	{
		return null;
	}

	[Token(Token = "0x60177BC")]
	[Address(RVA = "0x2317248", Offset = "0x2317248", VA = "0x2317248")]
	private static void WriteToFile(string message)
	{
	}

	[Token(Token = "0x60177BD")]
	[Address(RVA = "0x23178E0", Offset = "0x23178E0", VA = "0x23178E0")]
	public static void DrawLine(Vector3 start, Vector3 end, Color color)
	{
	}

	[Token(Token = "0x60177BE")]
	[Address(RVA = "0x2317A10", Offset = "0x2317A10", VA = "0x2317A10")]
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
	{
	}

	[Token(Token = "0x60177BF")]
	[Address(RVA = "0x2317B58", Offset = "0x2317B58", VA = "0x2317B58")]
	public static void DrawLine(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x60177C0")]
	[Address(RVA = "0x2317C5C", Offset = "0x2317C5C", VA = "0x2317C5C")]
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest)
	{
	}

	[Token(Token = "0x60177C1")]
	[Address(RVA = "0x2317DB0", Offset = "0x2317DB0", VA = "0x2317DB0")]
	public static void LogJson(object o, string pre = "", LogColor color = LogColor.None)
	{
	}
}
