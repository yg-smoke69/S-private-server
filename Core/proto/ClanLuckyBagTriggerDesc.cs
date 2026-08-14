using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A30")]
public class ClanLuckyBagTriggerDesc
{
	[Token(Token = "0x400A3FE")]
	[FieldOffset(Offset = "0x8")]
	public uint event_type;

	[Token(Token = "0x400A3FF")]
	[FieldOffset(Offset = "0xC")]
	public uint lucky_bag_capacity;

	[Token(Token = "0x400A400")]
	[FieldOffset(Offset = "0x10")]
	public uint cdt_value;

	[Token(Token = "0x400A401")]
	[FieldOffset(Offset = "0x14")]
	public uint level;

	[Token(Token = "0x400A402")]
	[FieldOffset(Offset = "0x18")]
	public uint cdt_type;

	[Token(Token = "0x6008088")]
	[Address(RVA = "0x309BD38", Offset = "0x309BD38", VA = "0x309BD38")]
	public ClanLuckyBagTriggerDesc()
	{
	}
}
