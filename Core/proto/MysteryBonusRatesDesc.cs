using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019B6")]
public class MysteryBonusRatesDesc
{
	[Token(Token = "0x400A124")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A125")]
	[FieldOffset(Offset = "0xC")]
	public uint pool_id;

	[Token(Token = "0x400A126")]
	[FieldOffset(Offset = "0x10")]
	public uint bonus_percent;

	[Token(Token = "0x400A127")]
	[FieldOffset(Offset = "0x14")]
	public uint weight;

	[Token(Token = "0x600800E")]
	[Address(RVA = "0x30A96DC", Offset = "0x30A96DC", VA = "0x30A96DC")]
	public MysteryBonusRatesDesc()
	{
	}
}
