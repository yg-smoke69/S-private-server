using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014E4")]
public class LimitedEventEPRewardStatus
{
	[Token(Token = "0x4009021")]
	[FieldOffset(Offset = "0x8")]
	public uint unlock_id;

	[Token(Token = "0x4009022")]
	[FieldOffset(Offset = "0xC")]
	public uint status;

	[Token(Token = "0x6007B39")]
	[Address(RVA = "0x30A49FC", Offset = "0x30A49FC", VA = "0x30A49FC")]
	public LimitedEventEPRewardStatus()
	{
	}
}
