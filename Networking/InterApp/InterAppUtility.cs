using System.Collections.Generic;
using Il2CppDummyDll;

namespace InterApp;

[Token(Token = "0x2003EF3")]
public static class InterAppUtility
{
	[Token(Token = "0x2003EF4")]
	public delegate void LogDelegate(string log);

	[Token(Token = "0x401A94C")]
	[FieldOffset(Offset = "0x0")]
	public static LogDelegate OnLog;

	[Token(Token = "0x401A94D")]
	[FieldOffset(Offset = "0x4")]
	public static Dictionary<int, BaseAppInfo> appInfos;

	[Token(Token = "0x17001C0A")]
	public static string[] LSApplicationQueriesSchemes
	{
		[Token(Token = "0x6019A3D")]
		[Address(RVA = "0x310C8A4", Offset = "0x310C8A4", VA = "0x310C8A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019A3C")]
	[Address(RVA = "0x310C6FC", Offset = "0x310C6FC", VA = "0x310C6FC")]
	public static BaseAppInfo Info(InterAppName name)
	{
		return null;
	}

	[Token(Token = "0x6019A3E")]
	[Address(RVA = "0x310CBC8", Offset = "0x310CBC8", VA = "0x310CBC8")]
	public static BaseAppInfo[] CanShareText()
	{
		return null;
	}

	[Token(Token = "0x6019A3F")]
	[Address(RVA = "0x310CE84", Offset = "0x310CE84", VA = "0x310CE84")]
	public static BaseAppInfo[] CanShareImage()
	{
		return null;
	}

	[Token(Token = "0x6019A40")]
	[Address(RVA = "0x310D140", Offset = "0x310D140", VA = "0x310D140")]
	public static void Log(string log)
	{
	}
}
