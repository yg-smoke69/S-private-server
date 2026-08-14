using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017BB")]
public class FreshRewardItem
{
	[Token(Token = "0x4009B42")]
	[FieldOffset(Offset = "0x8")]
	public uint day;

	[Token(Token = "0x4009B43")]
	[FieldOffset(Offset = "0xC")]
	public bool if_signed;

	[Token(Token = "0x4009B44")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> signin_awards;

	[Token(Token = "0x4009B45")]
	[FieldOffset(Offset = "0x14")]
	public string tab_cdn_url;

	[Token(Token = "0x4009B46")]
	[FieldOffset(Offset = "0x18")]
	public uint achievement_id;

	[Token(Token = "0x6007E15")]
	[Address(RVA = "0x30A1280", Offset = "0x30A1280", VA = "0x30A1280")]
	public FreshRewardItem()
	{
	}
}
