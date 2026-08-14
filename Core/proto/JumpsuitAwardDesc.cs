using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BE9")]
public class JumpsuitAwardDesc
{
	[Token(Token = "0x400AFC2")]
	[FieldOffset(Offset = "0x8")]
	public uint stage_id;

	[Token(Token = "0x400AFC3")]
	[FieldOffset(Offset = "0xC")]
	public uint stage_amount;

	[Token(Token = "0x400AFC4")]
	[FieldOffset(Offset = "0x10")]
	public AwardDesc award;

	[Token(Token = "0x6008244")]
	[Address(RVA = "0x30A41A8", Offset = "0x30A41A8", VA = "0x30A41A8")]
	public JumpsuitAwardDesc()
	{
	}
}
