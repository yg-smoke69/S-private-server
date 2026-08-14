using System.Collections.Generic;
using Il2CppDummyDll;

namespace InterApp;

[Token(Token = "0x2003EFD")]
public static class OpenedWithParamsProcessor
{
	[Token(Token = "0x401A960")]
	[FieldOffset(Offset = "0x0")]
	private static List<OpenedWithParamsDelegate> _Delegates;

	[Token(Token = "0x17001C13")]
	public static List<OpenedWithParamsDelegate> Delegates
	{
		[Token(Token = "0x6019A6E")]
		[Address(RVA = "0x3110254", Offset = "0x3110254", VA = "0x3110254")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019A6F")]
	[Address(RVA = "0x31102E0", Offset = "0x31102E0", VA = "0x31102E0")]
	public static void AddDelegate(OpenedWithParamsDelegate d)
	{
	}

	[Token(Token = "0x6019A70")]
	[Address(RVA = "0x31103E4", Offset = "0x31103E4", VA = "0x31103E4")]
	public static bool HasDelegate(OpenedWithParamsDelegate d)
	{
		return default(bool);
	}

	[Token(Token = "0x6019A71")]
	[Address(RVA = "0x31104A0", Offset = "0x31104A0", VA = "0x31104A0")]
	public static void RemoveDelegate(OpenedWithParamsDelegate d)
	{
	}

	[Token(Token = "0x6019A72")]
	[Address(RVA = "0x3110598", Offset = "0x3110598", VA = "0x3110598")]
	public static OpenedWithParamsDelegate.OpenedWithParams Process(Dictionary<string, string> parameters)
	{
		return null;
	}
}
