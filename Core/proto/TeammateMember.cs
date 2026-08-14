using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013DE")]
public class TeammateMember
{
	[Token(Token = "0x4008B56")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008B57")]
	[FieldOffset(Offset = "0x10")]
	public string clan_name;

	[Token(Token = "0x4008B58")]
	[FieldOffset(Offset = "0x14")]
	public uint kills;

	[Token(Token = "0x4008B59")]
	[FieldOffset(Offset = "0x18")]
	public uint damage;

	[Token(Token = "0x4008B5A")]
	[FieldOffset(Offset = "0x1C")]
	public uint headshot_kills;

	[Token(Token = "0x4008B5B")]
	[FieldOffset(Offset = "0x20")]
	public uint hp_used_count;

	[Token(Token = "0x6007ABF")]
	[Address(RVA = "0x33E36A4", Offset = "0x33E36A4", VA = "0x33E36A4")]
	public TeammateMember()
	{
	}
}
