using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B78")]
public class BooyahgoSkullKingActivityDesc
{
	[Token(Token = "0x400ACD8")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400ACD9")]
	[FieldOffset(Offset = "0xC")]
	public uint activity_id;

	[Token(Token = "0x400ACDA")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> exchange_awards;

	[Token(Token = "0x60081D3")]
	[Address(RVA = "0x317CF74", Offset = "0x317CF74", VA = "0x317CF74")]
	public BooyahgoSkullKingActivityDesc()
	{
	}
}
