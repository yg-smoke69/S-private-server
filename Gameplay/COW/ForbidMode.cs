using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000FE")]
public class ForbidMode
{
	[Token(Token = "0x4000660")]
	[FieldOffset(Offset = "0x8")]
	public uint matchMode;

	[Token(Token = "0x4000661")]
	[FieldOffset(Offset = "0xC")]
	public uint groupMode;

	[Token(Token = "0x4000662")]
	[FieldOffset(Offset = "0x10")]
	public uint gameMode;

	[Token(Token = "0x6000660")]
	[Address(RVA = "0xDEE0A8", Offset = "0xDEE0A8", VA = "0xDEE0A8")]
	public ForbidMode(uint matchMode, uint groupMode, uint gameMode)
	{
	}

	[Token(Token = "0x6000661")]
	[Address(RVA = "0xDEE0D8", Offset = "0xDEE0D8", VA = "0xDEE0D8")]
	public static bool operator ==(ForbidMode a, ForbidMode b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000662")]
	[Address(RVA = "0xDEE190", Offset = "0xDEE190", VA = "0xDEE190")]
	public static bool operator !=(ForbidMode a, ForbidMode b)
	{
		return default(bool);
	}
}
