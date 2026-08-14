using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D7A")]
public class RebateItemData
{
	[Token(Token = "0x4011731")]
	[FieldOffset(Offset = "0x8")]
	public long RebateId;

	[Token(Token = "0x4011732")]
	[FieldOffset(Offset = "0x10")]
	public string Name;

	[Token(Token = "0x4011733")]
	[FieldOffset(Offset = "0x14")]
	public string Description;

	[Token(Token = "0x4011734")]
	[FieldOffset(Offset = "0x18")]
	public int TotalDays;

	[Token(Token = "0x4011735")]
	[FieldOffset(Offset = "0x1C")]
	public int RemainingDays;

	[Token(Token = "0x4011736")]
	[FieldOffset(Offset = "0x20")]
	public int VirtualCurrencyAmunt;

	[Token(Token = "0x4011737")]
	[FieldOffset(Offset = "0x24")]
	public bool CanBuy;

	[Token(Token = "0x4011738")]
	[FieldOffset(Offset = "0x25")]
	public bool CanRedeem;

	[Token(Token = "0x4011739")]
	[FieldOffset(Offset = "0x26")]
	public bool Owned;

	[Token(Token = "0x60130A4")]
	[Address(RVA = "0x1970A6C", Offset = "0x1970A6C", VA = "0x1970A6C")]
	public RebateItemData()
	{
	}
}
