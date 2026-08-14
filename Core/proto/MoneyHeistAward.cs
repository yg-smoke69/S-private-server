using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017FD")]
public class MoneyHeistAward
{
	[Token(Token = "0x4009BD7")]
	[FieldOffset(Offset = "0x8")]
	public uint money;

	[Token(Token = "0x4009BD8")]
	[FieldOffset(Offset = "0xC")]
	public bool big_one;

	[Token(Token = "0x4009BD9")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> awards;

	[Token(Token = "0x6007E57")]
	[Address(RVA = "0x30A8DC0", Offset = "0x30A8DC0", VA = "0x30A8DC0")]
	public MoneyHeistAward()
	{
	}
}
