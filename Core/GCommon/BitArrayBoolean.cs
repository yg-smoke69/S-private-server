using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003F1F")]
public class BitArrayBoolean : BitArray
{
	[Token(Token = "0x2003F20")]
	public enum EBitArrayBooleanMode
	{
		[Token(Token = "0x401A9FC")]
		AND_TURE,
		[Token(Token = "0x401A9FD")]
		OR_TRUE
	}

	[Token(Token = "0x401A9FA")]
	[FieldOffset(Offset = "0xC")]
	protected EBitArrayBooleanMode m_Mode;

	[Token(Token = "0x6019B34")]
	[Address(RVA = "0x307D0A4", Offset = "0x307D0A4", VA = "0x307D0A4")]
	public BitArrayBoolean(bool v, EBitArrayBooleanMode mode = EBitArrayBooleanMode.OR_TRUE)
	{
	}

	[Token(Token = "0x6019B35")]
	[Address(RVA = "0x307D0EC", Offset = "0x307D0EC", VA = "0x307D0EC")]
	public void SetBooleanValue(bool v)
	{
	}

	[Token(Token = "0x6019B36")]
	[Address(RVA = "0x307D10C", Offset = "0x307D10C", VA = "0x307D10C")]
	public void SetBooleanValue(uint flag, bool v)
	{
	}

	[Token(Token = "0x6019B37")]
	[Address(RVA = "0x307D124", Offset = "0x307D124", VA = "0x307D124")]
	public bool GetBooleanValue()
	{
		return default(bool);
	}

	[Token(Token = "0x6019B38")]
	[Address(RVA = "0x307D150", Offset = "0x307D150", VA = "0x307D150")]
	public static implicit operator bool(BitArrayBoolean ba)
	{
		return default(bool);
	}
}
