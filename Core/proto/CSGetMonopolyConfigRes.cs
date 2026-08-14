using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001847")]
public class CSGetMonopolyConfigRes
{
	[Token(Token = "0x4009C95")]
	[FieldOffset(Offset = "0x8")]
	public List<MonopolyNodeDesc> nodes;

	[Token(Token = "0x4009C96")]
	[FieldOffset(Offset = "0xC")]
	public MonopolySettingDesc setting;

	[Token(Token = "0x4009C97")]
	[FieldOffset(Offset = "0x10")]
	public List<MonopolyEventDesc> events;

	[Token(Token = "0x6007EA1")]
	[Address(RVA = "0x31879E4", Offset = "0x31879E4", VA = "0x31879E4")]
	public CSGetMonopolyConfigRes()
	{
	}
}
