using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003E8E")]
public static class SingletonModuleAppContext
{
	[Token(Token = "0x401A6C1")]
	[FieldOffset(Offset = "0x0")]
	private static List<ISingletonModule> Modules;

	[Token(Token = "0x6019753")]
	[Address(RVA = "0x3234354", Offset = "0x3234354", VA = "0x3234354")]
	internal static void RegisterModule(ISingletonModule module)
	{
	}

	[Token(Token = "0x6019754")]
	[Address(RVA = "0x3234410", Offset = "0x3234410", VA = "0x3234410")]
	public static void InitModules()
	{
	}

	[Token(Token = "0x6019755")]
	[Address(RVA = "0x323461C", Offset = "0x323461C", VA = "0x323461C")]
	public static void CleanupModules()
	{
	}
}
