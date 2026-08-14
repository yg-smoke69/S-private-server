using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001372")]
public class PunishRecord
{
	[Token(Token = "0x4008985")]
	[FieldOffset(Offset = "0x8")]
	public uint behavior_rule_id;

	[Token(Token = "0x4008986")]
	[FieldOffset(Offset = "0xC")]
	public int delta_credit_score;

	[Token(Token = "0x6007A73")]
	[Address(RVA = "0x33E039C", Offset = "0x33E039C", VA = "0x33E039C")]
	public PunishRecord()
	{
	}
}
