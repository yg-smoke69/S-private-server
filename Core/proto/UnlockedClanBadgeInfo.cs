using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001640")]
public class UnlockedClanBadgeInfo
{
	[Token(Token = "0x40095A7")]
	[FieldOffset(Offset = "0x8")]
	public uint clan_badge_id;

	[Token(Token = "0x40095A8")]
	[FieldOffset(Offset = "0x10")]
	public ulong expire_time;

	[Token(Token = "0x6007C8A")]
	[Address(RVA = "0x33E41B8", Offset = "0x33E41B8", VA = "0x33E41B8")]
	public UnlockedClanBadgeInfo()
	{
	}
}
