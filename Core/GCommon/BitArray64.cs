using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003F1E")]
public class BitArray64
{
	[Token(Token = "0x401A9F7")]
	public const ulong NONE = 0uL;

	[Token(Token = "0x401A9F8")]
	public const ulong FULL = 4294967295uL;

	[Token(Token = "0x401A9F9")]
	[FieldOffset(Offset = "0x8")]
	protected ulong m_Value;

	[Token(Token = "0x6019B26")]
	[Address(RVA = "0x307CE24", Offset = "0x307CE24", VA = "0x307CE24")]
	public BitArray64()
	{
	}

	[Token(Token = "0x6019B27")]
	[Address(RVA = "0x307CE48", Offset = "0x307CE48", VA = "0x307CE48")]
	public static bool HasFlag(ulong value, ulong flags)
	{
		return default(bool);
	}

	[Token(Token = "0x6019B28")]
	[Address(RVA = "0x307CE5C", Offset = "0x307CE5C", VA = "0x307CE5C")]
	public static bool HasFlagByPos(ulong value, uint pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6019B29")]
	[Address(RVA = "0x307CEB0", Offset = "0x307CEB0", VA = "0x307CEB0")]
	public static ulong AddFlag(ulong value, ulong flags)
	{
		return default(ulong);
	}

	[Token(Token = "0x6019B2A")]
	[Address(RVA = "0x307CEBC", Offset = "0x307CEBC", VA = "0x307CEBC")]
	public static ulong AddFlagByPos(ulong value, uint pos)
	{
		return default(ulong);
	}

	[Token(Token = "0x6019B2B")]
	[Address(RVA = "0x307CF00", Offset = "0x307CF00", VA = "0x307CF00")]
	public static ulong RemoveFlag(ulong value, ulong flags)
	{
		return default(ulong);
	}

	[Token(Token = "0x6019B2C")]
	[Address(RVA = "0x307CF0C", Offset = "0x307CF0C", VA = "0x307CF0C")]
	public static ulong RemoveFlagByPos(ulong value, ulong pos)
	{
		return default(ulong);
	}

	[Token(Token = "0x6019B2D")]
	[Address(RVA = "0x307CF50", Offset = "0x307CF50", VA = "0x307CF50")]
	public bool HasFlag(ulong flags)
	{
		return default(bool);
	}

	[Token(Token = "0x6019B2E")]
	[Address(RVA = "0x307CF68", Offset = "0x307CF68", VA = "0x307CF68")]
	public bool HasFlagByPos(uint pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6019B2F")]
	[Address(RVA = "0x307CFC4", Offset = "0x307CFC4", VA = "0x307CFC4")]
	public void AddFlag(ulong flags)
	{
	}

	[Token(Token = "0x6019B30")]
	[Address(RVA = "0x307CFE0", Offset = "0x307CFE0", VA = "0x307CFE0")]
	public void AddFlagByPos(uint pos)
	{
	}

	[Token(Token = "0x6019B31")]
	[Address(RVA = "0x307D030", Offset = "0x307D030", VA = "0x307D030")]
	public void RemoveFlag(ulong flags)
	{
	}

	[Token(Token = "0x6019B32")]
	[Address(RVA = "0x307D04C", Offset = "0x307D04C", VA = "0x307D04C")]
	public void RemoveFlagByPos(uint pos)
	{
	}

	[Token(Token = "0x6019B33")]
	[Address(RVA = "0x307D09C", Offset = "0x307D09C", VA = "0x307D09C")]
	public ulong GetValue()
	{
		return default(ulong);
	}
}
