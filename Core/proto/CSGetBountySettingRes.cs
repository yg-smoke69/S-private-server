using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200180C")]
public class CSGetBountySettingRes
{
	[Token(Token = "0x4009BF2")]
	[FieldOffset(Offset = "0x8")]
	public BountySettingDesc setting;

	[Token(Token = "0x4009BF3")]
	[FieldOffset(Offset = "0xC")]
	public List<BigEventTokenTipsDesc> exchange_token_tips;

	[Token(Token = "0x4009BF4")]
	[FieldOffset(Offset = "0x10")]
	public List<BountyPlayerRatingDesc> player_ratings;

	[Token(Token = "0x6007E66")]
	[Address(RVA = "0x31828D4", Offset = "0x31828D4", VA = "0x31828D4")]
	public CSGetBountySettingRes()
	{
	}
}
