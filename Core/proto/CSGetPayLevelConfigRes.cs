using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015D6")]
public class CSGetPayLevelConfigRes
{
	[Token(Token = "0x400945E")]
	[FieldOffset(Offset = "0x8")]
	public List<PayLevelConfig> pay_level_config;

	[Token(Token = "0x6007C20")]
	[Address(RVA = "0x31884D4", Offset = "0x31884D4", VA = "0x31884D4")]
	public CSGetPayLevelConfigRes()
	{
	}
}
