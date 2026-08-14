using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013C3")]
public class ClanWarMemberStatus
{
	[Token(Token = "0x4008AF7")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008AF8")]
	[FieldOffset(Offset = "0x10")]
	public uint personal_arms;

	[Token(Token = "0x4008AF9")]
	[FieldOffset(Offset = "0x14")]
	public uint kills;

	[Token(Token = "0x6007AAE")]
	[Address(RVA = "0x309C3A8", Offset = "0x309C3A8", VA = "0x309C3A8")]
	public ClanWarMemberStatus()
	{
	}
}
