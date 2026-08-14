using Il2CppDummyDll;

[Token(Token = "0x200401B")]
public class TssSdtDataTypeFactory
{
	[Token(Token = "0x401AFCA")]
	[FieldOffset(Offset = "0x0")]
	private static byte m_byte_xor_key;

	[Token(Token = "0x401AFCB")]
	[FieldOffset(Offset = "0x2")]
	private static short m_short_xor_key;

	[Token(Token = "0x401AFCC")]
	[FieldOffset(Offset = "0x4")]
	private static ushort m_ushort_xor_key;

	[Token(Token = "0x401AFCD")]
	[FieldOffset(Offset = "0x8")]
	private static int m_int_xor_key;

	[Token(Token = "0x401AFCE")]
	[FieldOffset(Offset = "0xC")]
	private static uint m_uint_xor_key;

	[Token(Token = "0x401AFCF")]
	[FieldOffset(Offset = "0x10")]
	private static long m_long_xor_key;

	[Token(Token = "0x401AFD0")]
	[FieldOffset(Offset = "0x18")]
	private static ulong m_ulong_xor_key;

	[Token(Token = "0x601A197")]
	[Address(RVA = "0x2644B08", Offset = "0x2644B08", VA = "0x2644B08")]
	public TssSdtDataTypeFactory()
	{
	}

	[Token(Token = "0x601A198")]
	[Address(RVA = "0x2644B10", Offset = "0x2644B10", VA = "0x2644B10")]
	public static byte GetByteXORKey()
	{
		return default(byte);
	}

	[Token(Token = "0x601A199")]
	[Address(RVA = "0x2644BE8", Offset = "0x2644BE8", VA = "0x2644BE8")]
	public static void SetByteXORKey(byte v)
	{
	}

	[Token(Token = "0x601A19A")]
	[Address(RVA = "0x2644C4C", Offset = "0x2644C4C", VA = "0x2644C4C")]
	public static short GetShortXORKey()
	{
		return default(short);
	}

	[Token(Token = "0x601A19B")]
	[Address(RVA = "0x2644D28", Offset = "0x2644D28", VA = "0x2644D28")]
	public static ushort GetUshortXORKey()
	{
		return default(ushort);
	}

	[Token(Token = "0x601A19C")]
	[Address(RVA = "0x2644DFC", Offset = "0x2644DFC", VA = "0x2644DFC")]
	public static int GetIntXORKey()
	{
		return default(int);
	}

	[Token(Token = "0x601A19D")]
	[Address(RVA = "0x2644ED0", Offset = "0x2644ED0", VA = "0x2644ED0")]
	public static uint GetUintXORKey()
	{
		return default(uint);
	}

	[Token(Token = "0x601A19E")]
	[Address(RVA = "0x2644FA4", Offset = "0x2644FA4", VA = "0x2644FA4")]
	public static long GetLongXORKey()
	{
		return default(long);
	}

	[Token(Token = "0x601A19F")]
	[Address(RVA = "0x2645080", Offset = "0x2645080", VA = "0x2645080")]
	public static ulong GetUlongXORKey()
	{
		return default(ulong);
	}

	[Token(Token = "0x601A1A0")]
	[Address(RVA = "0x264515C", Offset = "0x264515C", VA = "0x264515C")]
	public static int GetRandomValueIndex()
	{
		return default(int);
	}

	[Token(Token = "0x601A1A1")]
	[Address(RVA = "0x26451C0", Offset = "0x26451C0", VA = "0x26451C0")]
	public static int GetValueArraySize()
	{
		return default(int);
	}

	[Token(Token = "0x601A1A2")]
	[Address(RVA = "0x26451C8", Offset = "0x26451C8", VA = "0x26451C8")]
	public static uint GetFloatEncValue(float v, byte key)
	{
		return default(uint);
	}

	[Token(Token = "0x601A1A3")]
	[Address(RVA = "0x26452E0", Offset = "0x26452E0", VA = "0x26452E0")]
	public static float GetFloatDecValue(uint v, byte key)
	{
		return default(float);
	}

	[Token(Token = "0x601A1A4")]
	[Address(RVA = "0x26453F8", Offset = "0x26453F8", VA = "0x26453F8")]
	public static ulong GetDoubleEncValue(double v, byte key)
	{
		return default(ulong);
	}

	[Token(Token = "0x601A1A5")]
	[Address(RVA = "0x2645518", Offset = "0x2645518", VA = "0x2645518")]
	public static double GetDoubleDecValue(ulong v, byte key)
	{
		return default(double);
	}
}
