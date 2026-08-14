using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040AC")]
public class MemoryProfiler
{
	[Token(Token = "0x601A50D")]
	[Address(RVA = "0x296C848", Offset = "0x296C848", VA = "0x296C848")]
	public MemoryProfiler()
	{
	}

	[Token(Token = "0x601A50E")]
	[Address(RVA = "0x296C850", Offset = "0x296C850", VA = "0x296C850")]
	public static void BeginMonoProfile(string tag)
	{
	}

	[Token(Token = "0x601A50F")]
	[Address(RVA = "0x296C854", Offset = "0x296C854", VA = "0x296C854")]
	public static void EndMonoProfile(string tag, bool additive = false)
	{
	}

	[Token(Token = "0x601A510")]
	[Address(RVA = "0x296C858", Offset = "0x296C858", VA = "0x296C858")]
	public static string GetMonoMemoryStatus()
	{
		return null;
	}
}
