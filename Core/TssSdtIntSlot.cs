using Il2CppDummyDll;

[Token(Token = "0x200401C")]
public class TssSdtIntSlot
{
	[Token(Token = "0x401AFD1")]
	[FieldOffset(Offset = "0x8")]
	private int[] m_value;

	[Token(Token = "0x401AFD2")]
	[FieldOffset(Offset = "0xC")]
	private int m_xor_key;

	[Token(Token = "0x401AFD3")]
	[FieldOffset(Offset = "0x10")]
	private int m_index;

	[Token(Token = "0x601A1A6")]
	[Address(RVA = "0x26465F0", Offset = "0x26465F0", VA = "0x26465F0")]
	public TssSdtIntSlot()
	{
	}

	[Token(Token = "0x601A1A7")]
	[Address(RVA = "0x2645F20", Offset = "0x2645F20", VA = "0x2645F20")]
	public static TssSdtIntSlot NewSlot(TssSdtIntSlot slot)
	{
		return null;
	}

	[Token(Token = "0x601A1A8")]
	[Address(RVA = "0x26466E0", Offset = "0x26466E0", VA = "0x26466E0")]
	private static void CollectSlot(TssSdtIntSlot slot)
	{
	}

	[Token(Token = "0x601A1A9")]
	[Address(RVA = "0x2646064", Offset = "0x2646064", VA = "0x2646064")]
	public void SetValue(int v)
	{
	}

	[Token(Token = "0x601A1AA")]
	[Address(RVA = "0x2645FC8", Offset = "0x2645FC8", VA = "0x2645FC8")]
	public int GetValue()
	{
		return default(int);
	}
}
