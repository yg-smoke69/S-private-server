using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A27")]
public class ClanSignInRewardsDesc
{
	[Token(Token = "0x400A3DA")]
	[FieldOffset(Offset = "0x8")]
	public uint sign_in_group;

	[Token(Token = "0x400A3DB")]
	[FieldOffset(Offset = "0xC")]
	public uint clan_level;

	[Token(Token = "0x400A3DC")]
	[FieldOffset(Offset = "0x10")]
	public uint weekday;

	[Token(Token = "0x400A3DD")]
	[FieldOffset(Offset = "0x14")]
	public AwardDesc award;

	[Token(Token = "0x600807F")]
	[Address(RVA = "0x309C148", Offset = "0x309C148", VA = "0x309C148")]
	public ClanSignInRewardsDesc()
	{
	}
}
