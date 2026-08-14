using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001634")]
public class CSGetClanSignInRewardsByLevelReq
{
	[Token(Token = "0x4009569")]
	[FieldOffset(Offset = "0x8")]
	public uint clan_level;

	[Token(Token = "0x400956A")]
	[FieldOffset(Offset = "0xC")]
	public string clan_region;

	[Token(Token = "0x6007C7E")]
	[Address(RVA = "0x31831E4", Offset = "0x31831E4", VA = "0x31831E4")]
	public CSGetClanSignInRewardsByLevelReq()
	{
	}
}
