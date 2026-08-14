using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001950")]
public class HurricaneBTeamMemberInfo
{
	[Token(Token = "0x4009F68")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009F69")]
	[FieldOffset(Offset = "0x10")]
	public string nickname;

	[Token(Token = "0x4009F6A")]
	[FieldOffset(Offset = "0x14")]
	public uint star_count;

	[Token(Token = "0x4009F6B")]
	[FieldOffset(Offset = "0x18")]
	public bool have_ep;

	[Token(Token = "0x6007FA9")]
	[Address(RVA = "0x30A3564", Offset = "0x30A3564", VA = "0x30A3564")]
	public HurricaneBTeamMemberInfo()
	{
	}
}
