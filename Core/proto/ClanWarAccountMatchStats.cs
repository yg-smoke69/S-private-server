using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001660")]
public class ClanWarAccountMatchStats
{
	[Token(Token = "0x400960B")]
	[FieldOffset(Offset = "0x8")]
	public uint award_arms;

	[Token(Token = "0x400960C")]
	[FieldOffset(Offset = "0xC")]
	public uint personal_arms;

	[Token(Token = "0x6007CAA")]
	[Address(RVA = "0x309C158", Offset = "0x309C158", VA = "0x309C158")]
	public ClanWarAccountMatchStats()
	{
	}
}
