using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003F21")]
public class BitArrayRich
{
	[Token(Token = "0x401A9FE")]
	[FieldOffset(Offset = "0x8")]
	private byte[] data_array;

	[Token(Token = "0x401A9FF")]
	[FieldOffset(Offset = "0xC")]
	private uint m_FlagCount;

	[Token(Token = "0x6019B39")]
	[Address(RVA = "0x307D194", Offset = "0x307D194", VA = "0x307D194")]
	public BitArrayRich(uint length)
	{
	}

	[Token(Token = "0x6019B3A")]
	[Address(RVA = "0x307D234", Offset = "0x307D234", VA = "0x307D234")]
	public BitArrayRich(byte[] data)
	{
	}

	[Token(Token = "0x6019B3B")]
	[Address(RVA = "0x307D25C", Offset = "0x307D25C", VA = "0x307D25C")]
	public bool HasFlagByPos(uint pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6019B3C")]
	[Address(RVA = "0x307D31C", Offset = "0x307D31C", VA = "0x307D31C")]
	public void AddFlagByPos(uint pos)
	{
	}

	[Token(Token = "0x6019B3D")]
	[Address(RVA = "0x307D41C", Offset = "0x307D41C", VA = "0x307D41C")]
	public void RemoveFlagByPos(uint pos)
	{
	}

	[Token(Token = "0x6019B3E")]
	[Address(RVA = "0x307D4E4", Offset = "0x307D4E4", VA = "0x307D4E4", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6019B3F")]
	[Address(RVA = "0x307D5B8", Offset = "0x307D5B8", VA = "0x307D5B8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6019B40")]
	[Address(RVA = "0x307D2E8", Offset = "0x307D2E8", VA = "0x307D2E8")]
	private int GetValueIndexByPos(uint pos)
	{
		return default(int);
	}

	[Token(Token = "0x6019B41")]
	[Address(RVA = "0x307D5EC", Offset = "0x307D5EC", VA = "0x307D5EC")]
	public byte[] GetValue()
	{
		return null;
	}

	[Token(Token = "0x6019B42")]
	[Address(RVA = "0x307D6A8", Offset = "0x307D6A8", VA = "0x307D6A8")]
	public int GetValueLength()
	{
		return default(int);
	}

	[Token(Token = "0x6019B43")]
	[Address(RVA = "0x307D6CC", Offset = "0x307D6CC", VA = "0x307D6CC")]
	public void SetValue(byte[] value)
	{
	}

	[Token(Token = "0x6019B44")]
	[Address(RVA = "0x307D7FC", Offset = "0x307D7FC", VA = "0x307D7FC")]
	public void SetFull()
	{
	}

	[Token(Token = "0x6019B45")]
	[Address(RVA = "0x307D8EC", Offset = "0x307D8EC", VA = "0x307D8EC")]
	public static byte BitCount(byte n)
	{
		return default(byte);
	}

	[Token(Token = "0x6019B46")]
	[Address(RVA = "0x307D918", Offset = "0x307D918", VA = "0x307D918")]
	public uint GetFlagCount()
	{
		return default(uint);
	}

	[Token(Token = "0x6019B47")]
	[Address(RVA = "0x307D744", Offset = "0x307D744", VA = "0x307D744")]
	private void UpdateFlagCount()
	{
	}
}
