using Il2CppDummyDll;

[Token(Token = "0x200401E")]
public class TssSdtLongSlot
{
	[Token(Token = "0x401AFD5")]
	[FieldOffset(Offset = "0x8")]
	private long[] m_value;

	[Token(Token = "0x401AFD6")]
	[FieldOffset(Offset = "0x10")]
	private long m_xor_key;

	[Token(Token = "0x401AFD7")]
	[FieldOffset(Offset = "0x18")]
	private int m_index;

	[Token(Token = "0x601A1B8")]
	[Address(RVA = "0x26466E4", Offset = "0x26466E4", VA = "0x26466E4")]
	public TssSdtLongSlot()
	{
	}

	[Token(Token = "0x601A1B9")]
	[Address(RVA = "0x26467D4", Offset = "0x26467D4", VA = "0x26467D4")]
	public static TssSdtLongSlot NewSlot(TssSdtLongSlot slot)
	{
		return null;
	}

	[Token(Token = "0x601A1BA")]
	[Address(RVA = "0x264683C", Offset = "0x264683C", VA = "0x264683C")]
	private static void CollectSlot(TssSdtLongSlot slot)
	{
	}

	[Token(Token = "0x601A1BB")]
	[Address(RVA = "0x2646840", Offset = "0x2646840", VA = "0x2646840")]
	public void SetValue(long v)
	{
	}

	[Token(Token = "0x601A1BC")]
	[Address(RVA = "0x2646900", Offset = "0x2646900", VA = "0x2646900")]
	public long GetValue()
	{
		return default(long);
	}
}
