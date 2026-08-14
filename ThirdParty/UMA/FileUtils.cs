using Il2CppDummyDll;

namespace UMA;

[Token(Token = "0x2003CAB")]
public static class FileUtils
{
	[Token(Token = "0x601843E")]
	[Address(RVA = "0x224CB74", Offset = "0x224CB74", VA = "0x224CB74")]
	public static string ReadAllText(string path)
	{
		return null;
	}

	[Token(Token = "0x601843F")]
	[Address(RVA = "0x224CCE8", Offset = "0x224CCE8", VA = "0x224CCE8")]
	public static void WriteAllText(string path, string content)
	{
	}

	[Token(Token = "0x6018440")]
	[Address(RVA = "0x224CCF0", Offset = "0x224CCF0", VA = "0x224CCF0")]
	public static void WriteAllBytes(string path, byte[] content)
	{
	}

	[Token(Token = "0x6018441")]
	[Address(RVA = "0x224CCF8", Offset = "0x224CCF8", VA = "0x224CCF8")]
	public static void EnsurePath(string path)
	{
	}

	[Token(Token = "0x6018442")]
	[Address(RVA = "0x224CD24", Offset = "0x224CD24", VA = "0x224CD24")]
	public static string GetInternalDataStoreFolder(bool fullPath = false, bool editorOnly = true)
	{
		return null;
	}
}
