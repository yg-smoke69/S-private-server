using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200195C")]
public class CSBoybandBExchangeCardRes
{
	[Token(Token = "0x4009F80")]
	[FieldOffset(Offset = "0x8")]
	public uint card_id;

	[Token(Token = "0x4009F81")]
	[FieldOffset(Offset = "0xC")]
	public bool is_rewarded;

	[Token(Token = "0x4009F82")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> awards;

	[Token(Token = "0x6007FB5")]
	[Address(RVA = "0x317DFEC", Offset = "0x317DFEC", VA = "0x317DFEC")]
	public CSBoybandBExchangeCardRes()
	{
	}
}
