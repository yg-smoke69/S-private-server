using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A0B")]
public class NewPlayerRewardDesc
{
	[Token(Token = "0x400A345")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A346")]
	[FieldOffset(Offset = "0xC")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400A347")]
	[FieldOffset(Offset = "0x10")]
	public string tab_cdn_url;

	[Token(Token = "0x6008063")]
	[Address(RVA = "0x30A9E78", Offset = "0x30A9E78", VA = "0x30A9E78")]
	public NewPlayerRewardDesc()
	{
	}
}
