using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003F1D")]
public class BitArray
{
	[Token(Token = "0x401A9F4")]
	public const uint NONE = 0u;

	[Token(Token = "0x401A9F5")]
	public const uint FULL = uint.MaxValue;

	[Token(Token = "0x401A9F6")]
	[FieldOffset(Offset = "0x8")]
	protected uint m_Value;

	[Token(Token = "0x6019B18")]
	[Address(RVA = "0x307CCFC", Offset = "0x307CCFC", VA = "0x307CCFC")]
	public BitArray()
	{
	}

	[Token(Token = "0x6019B19")]
	[Address(RVA = "0x307CD1C", Offset = "0x307CD1C", VA = "0x307CD1C")]
	public static bool HasFlag(uint value, uint flags)
	{
		return default(bool);
	}

	[Token(Token = "0x6019B1A")]
	[Address(RVA = "0x307CD28", Offset = "0x307CD28", VA = "0x307CD28")]
	public static bool HasFlagByPos(uint value, uint pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6019B1B")]
	[Address(RVA = "0x307CD50", Offset = "0x307CD50", VA = "0x307CD50")]
	public static uint AddFlag(uint value, uint flags)
	{
		return default(uint);
	}

	[Token(Token = "0x6019B1C")]
	[Address(RVA = "0x307CD58", Offset = "0x307CD58", VA = "0x307CD58")]
	public static uint AddFlagByPos(uint value, uint pos)
	{
		return default(uint);
	}

	[Token(Token = "0x6019B1D")]
	[Address(RVA = "0x307CD6C", Offset = "0x307CD6C", VA = "0x307CD6C")]
	public static uint RemoveFlag(uint value, uint flags)
	{
		return default(uint);
	}

	[Token(Token = "0x6019B1E")]
	[Address(RVA = "0x307CD74", Offset = "0x307CD74", VA = "0x307CD74")]
	public static uint RemoveFlagByPos(uint value, uint pos)
	{
		return default(uint);
	}

	[Token(Token = "0x6019B1F")]
	[Address(RVA = "0x307CD88", Offset = "0x307CD88", VA = "0x307CD88")]
	public bool HasFlag(uint flags)
	{
		return default(bool);
	}

	[Token(Token = "0x6019B20")]
	[Address(RVA = "0x307CD98", Offset = "0x307CD98", VA = "0x307CD98")]
	public bool HasFlagByPos(uint pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6019B21")]
	[Address(RVA = "0x307CDC4", Offset = "0x307CDC4", VA = "0x307CDC4")]
	public void AddFlag(uint flags)
	{
	}

	[Token(Token = "0x6019B22")]
	[Address(RVA = "0x307CDD4", Offset = "0x307CDD4", VA = "0x307CDD4")]
	public void AddFlagByPos(uint pos)
	{
	}

	[Token(Token = "0x6019B23")]
	[Address(RVA = "0x307CDF0", Offset = "0x307CDF0", VA = "0x307CDF0")]
	public void RemoveFlag(uint flags)
	{
	}

	[Token(Token = "0x6019B24")]
	[Address(RVA = "0x307CE00", Offset = "0x307CE00", VA = "0x307CE00")]
	public void RemoveFlagByPos(uint pos)
	{
	}

	[Token(Token = "0x6019B25")]
	[Address(RVA = "0x307CE1C", Offset = "0x307CE1C", VA = "0x307CE1C")]
	public uint GetValue()
	{
		return default(uint);
	}
}
