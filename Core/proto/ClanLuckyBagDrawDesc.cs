using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A2F")]
public class ClanLuckyBagDrawDesc
{
	[Token(Token = "0x400A3FC")]
	[FieldOffset(Offset = "0x8")]
	public uint guild_token_num;

	[Token(Token = "0x400A3FD")]
	[FieldOffset(Offset = "0xC")]
	public uint weight;

	[Token(Token = "0x6008087")]
	[Address(RVA = "0x309BC9C", Offset = "0x309BC9C", VA = "0x309BC9C")]
	public ClanLuckyBagDrawDesc()
	{
	}
}
