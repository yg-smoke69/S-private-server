using Il2CppDummyDll;

[Token(Token = "0x200401F")]
public class TssSdtFloatSlot
{
	[Token(Token = "0x401AFD8")]
	[FieldOffset(Offset = "0x8")]
	private uint[] m_value;

	[Token(Token = "0x401AFD9")]
	[FieldOffset(Offset = "0xC")]
	private byte m_xor_key;

	[Token(Token = "0x401AFDA")]
	[FieldOffset(Offset = "0x10")]
	private int m_index;

	[Token(Token = "0x601A1BD")]
	[Address(RVA = "0x2645D98", Offset = "0x2645D98", VA = "0x2645D98")]
	public TssSdtFloatSlot()
	{
	}

	[Token(Token = "0x601A1BE")]
	[Address(RVA = "0x26456CC", Offset = "0x26456CC", VA = "0x26456CC")]
	public static TssSdtFloatSlot NewSlot(TssSdtFloatSlot slot)
	{
		return null;
	}

	[Token(Token = "0x601A1BF")]
	[Address(RVA = "0x2645E88", Offset = "0x2645E88", VA = "0x2645E88")]
	private static void CollectSlot(TssSdtFloatSlot slot)
	{
	}

	[Token(Token = "0x601A1C0")]
	[Address(RVA = "0x2645810", Offset = "0x2645810", VA = "0x2645810")]
	public void SetValue(float v)
	{
	}

	[Token(Token = "0x601A1C1")]
	[Address(RVA = "0x2645774", Offset = "0x2645774", VA = "0x2645774")]
	public float GetValue()
	{
		return default(float);
	}
}
