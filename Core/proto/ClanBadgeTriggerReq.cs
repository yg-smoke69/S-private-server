using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013BE")]
public class ClanBadgeTriggerReq
{
	[Token(Token = "0x4008AED")]
	[FieldOffset(Offset = "0x8")]
	public EClan.ClanBadgeTriggerType type;

	[Token(Token = "0x4008AEE")]
	[FieldOffset(Offset = "0xC")]
	public uint value;

	[Token(Token = "0x6007AA9")]
	[Address(RVA = "0x309B840", Offset = "0x309B840", VA = "0x309B840")]
	public ClanBadgeTriggerReq()
	{
	}
}
