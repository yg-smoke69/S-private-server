using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001878")]
public class CSUpdateSocialBasicInfoReq
{
	[Token(Token = "0x4009D05")]
	[FieldOffset(Offset = "0x8")]
	public ESocial.Gender gender;

	[Token(Token = "0x4009D06")]
	[FieldOffset(Offset = "0xC")]
	public ESocial.Language language;

	[Token(Token = "0x4009D07")]
	[FieldOffset(Offset = "0x10")]
	public ESocial.TimeOnline time_online;

	[Token(Token = "0x4009D08")]
	[FieldOffset(Offset = "0x14")]
	public ESocial.TimeActive time_active;

	[Token(Token = "0x4009D09")]
	[FieldOffset(Offset = "0x18")]
	public List<ESocial.PlayerBattleTagID> battle_tag;

	[Token(Token = "0x4009D0A")]
	[FieldOffset(Offset = "0x1C")]
	public List<ESocial.SocialTag> social_tag;

	[Token(Token = "0x4009D0B")]
	[FieldOffset(Offset = "0x20")]
	public ESocial.ModePrefer mode_prefer;

	[Token(Token = "0x4009D0C")]
	[FieldOffset(Offset = "0x24")]
	public string signature;

	[Token(Token = "0x4009D0D")]
	[FieldOffset(Offset = "0x28")]
	public ESocial.RankShow rank_show;

	[Token(Token = "0x6007ED1")]
	[Address(RVA = "0x309A6D0", Offset = "0x309A6D0", VA = "0x309A6D0")]
	public CSUpdateSocialBasicInfoReq()
	{
	}
}
