using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BAD")]
public class CupBlocklistDesc
{
	[Token(Token = "0x400AE2B")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x400AE2C")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_id;

	[Token(Token = "0x400AE2D")]
	[FieldOffset(Offset = "0x10")]
	public ulong[] account_ids;

	[Token(Token = "0x6008208")]
	[Address(RVA = "0x309DA74", Offset = "0x309DA74", VA = "0x309DA74")]
	public CupBlocklistDesc()
	{
	}
}
