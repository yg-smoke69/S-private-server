using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001498")]
public class SocialBasicInfo
{
	[Token(Token = "0x4008EF3")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008EF4")]
	[FieldOffset(Offset = "0x10")]
	public ESocial.Gender gender;

	[Token(Token = "0x4008EF5")]
	[FieldOffset(Offset = "0x14")]
	public ESocial.Language language;

	[Token(Token = "0x4008EF6")]
	[FieldOffset(Offset = "0x18")]
	public ESocial.TimeOnline time_online;

	[Token(Token = "0x4008EF7")]
	[FieldOffset(Offset = "0x1C")]
	public ESocial.TimeActive time_active;

	[Token(Token = "0x4008EF8")]
	[FieldOffset(Offset = "0x20")]
	public List<ESocial.PlayerBattleTagID> battle_tag;

	[Token(Token = "0x4008EF9")]
	[FieldOffset(Offset = "0x24")]
	public List<ESocial.SocialTag> social_tag;

	[Token(Token = "0x4008EFA")]
	[FieldOffset(Offset = "0x28")]
	public ESocial.ModePrefer mode_prefer;

	[Token(Token = "0x4008EFB")]
	[FieldOffset(Offset = "0x2C")]
	public string signature;

	[Token(Token = "0x4008EFC")]
	[FieldOffset(Offset = "0x30")]
	public ESocial.RankShow rank_show;

	[Token(Token = "0x4008EFD")]
	[FieldOffset(Offset = "0x34")]
	public uint[] battle_tag_count;

	[Token(Token = "0x6007B0B")]
	[Address(RVA = "0x33E2464", Offset = "0x33E2464", VA = "0x33E2464")]
	public SocialBasicInfo()
	{
	}
}
