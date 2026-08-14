using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019F5")]
public class RoomCreateRuleRes
{
	[Token(Token = "0x400A2FA")]
	[FieldOffset(Offset = "0x8")]
	public List<RoomCreateRuleDropDesc> room_create_rule_drops;

	[Token(Token = "0x400A2FB")]
	[FieldOffset(Offset = "0xC")]
	public List<RoomCreateRuleDesc> room_create_rules;

	[Token(Token = "0x600804D")]
	[Address(RVA = "0x33E1CC8", Offset = "0x33E1CC8", VA = "0x33E1CC8")]
	public RoomCreateRuleRes()
	{
	}
}
