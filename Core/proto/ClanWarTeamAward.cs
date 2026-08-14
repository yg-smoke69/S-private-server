using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013C1")]
public class ClanWarTeamAward
{
	[Token(Token = "0x4008AF4")]
	[FieldOffset(Offset = "0x8")]
	public uint award_arms;

	[Token(Token = "0x4008AF5")]
	[FieldOffset(Offset = "0xC")]
	public ClanWarTeamAwardedLevel awarded_level;

	[Token(Token = "0x6007AAC")]
	[Address(RVA = "0x309C44C", Offset = "0x309C44C", VA = "0x309C44C")]
	public ClanWarTeamAward()
	{
	}
}
