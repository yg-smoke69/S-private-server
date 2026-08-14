using Il2CppDummyDll;

[Token(Token = "0x2003DBB")]
public class AkBasePathGetter
{
	[Token(Token = "0x401A38C")]
	[FieldOffset(Offset = "0x0")]
	public static string DefaultBasePath;

	[Token(Token = "0x601923E")]
	[Address(RVA = "0x35C8F50", Offset = "0x35C8F50", VA = "0x35C8F50")]
	public AkBasePathGetter()
	{
	}

	[Token(Token = "0x601923F")]
	[Address(RVA = "0x35C8F58", Offset = "0x35C8F58", VA = "0x35C8F58")]
	public static string GetPlatformName()
	{
		return null;
	}

	[Token(Token = "0x6019240")]
	[Address(RVA = "0x35C900C", Offset = "0x35C900C", VA = "0x35C900C")]
	public static string GetPlatformBasePath()
	{
		return null;
	}

	[Token(Token = "0x6019241")]
	[Address(RVA = "0x35C90EC", Offset = "0x35C90EC", VA = "0x35C90EC")]
	public static string GetFullSoundBankPath()
	{
		return null;
	}

	[Token(Token = "0x6019242")]
	[Address(RVA = "0x35C9318", Offset = "0x35C9318", VA = "0x35C9318")]
	public static void FixSlashes(ref string path, char separatorChar, char badChar, bool addTrailingSlash)
	{
	}

	[Token(Token = "0x6019243")]
	[Address(RVA = "0x35C9234", Offset = "0x35C9234", VA = "0x35C9234")]
	public static void FixSlashes(ref string path)
	{
	}

	[Token(Token = "0x6019244")]
	[Address(RVA = "0x35C8AB4", Offset = "0x35C8AB4", VA = "0x35C8AB4")]
	public static string GetSoundbankBasePath()
	{
		return null;
	}
}
