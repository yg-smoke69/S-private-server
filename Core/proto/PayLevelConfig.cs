using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015D8")]
public class PayLevelConfig
{
	[Token(Token = "0x4009460")]
	[FieldOffset(Offset = "0x8")]
	public PayLevelPoolDesc pool;

	[Token(Token = "0x4009461")]
	[FieldOffset(Offset = "0xC")]
	public List<PayLevelRewardDesc> rewards;

	[Token(Token = "0x6007C22")]
	[Address(RVA = "0x33DF19C", Offset = "0x33DF19C", VA = "0x33DF19C")]
	public PayLevelConfig()
	{
	}
}
