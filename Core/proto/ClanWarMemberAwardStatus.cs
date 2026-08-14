using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013C0")]
public class ClanWarMemberAwardStatus
{
	[Token(Token = "0x4008AF2")]
	[FieldOffset(Offset = "0x8")]
	public uint award_arms;

	[Token(Token = "0x4008AF3")]
	[FieldOffset(Offset = "0xC")]
	public bool has_claimed_award;

	[Token(Token = "0x6007AAB")]
	[Address(RVA = "0x309C300", Offset = "0x309C300", VA = "0x309C300")]
	public ClanWarMemberAwardStatus()
	{
	}
}
