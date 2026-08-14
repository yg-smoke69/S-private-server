using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200137D")]
public class SupercarHelpPlayer
{
	[Token(Token = "0x40089A8")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40089A9")]
	[FieldOffset(Offset = "0x10")]
	public string nickname;

	[Token(Token = "0x40089AA")]
	[FieldOffset(Offset = "0x14")]
	public bool is_speed;

	[Token(Token = "0x40089AB")]
	[FieldOffset(Offset = "0x18")]
	public uint car_id;

	[Token(Token = "0x6007A7E")]
	[Address(RVA = "0x33E2E18", Offset = "0x33E2E18", VA = "0x33E2E18")]
	public SupercarHelpPlayer()
	{
	}
}
