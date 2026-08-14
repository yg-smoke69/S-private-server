using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BBB")]
public class MusicFestCardRewardDesc
{
	[Token(Token = "0x400AE8E")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AE8F")]
	[FieldOffset(Offset = "0xC")]
	public uint card_num;

	[Token(Token = "0x400AE90")]
	[FieldOffset(Offset = "0x10")]
	public AwardDesc award;

	[Token(Token = "0x6008216")]
	[Address(RVA = "0x30A92E4", Offset = "0x30A92E4", VA = "0x30A92E4")]
	public MusicFestCardRewardDesc()
	{
	}
}
