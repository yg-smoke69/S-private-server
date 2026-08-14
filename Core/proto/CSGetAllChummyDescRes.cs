using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001935")]
public class CSGetAllChummyDescRes
{
	[Token(Token = "0x4009F18")]
	[FieldOffset(Offset = "0x8")]
	public List<MultiRelationTypeInfoDesc> multi_relation_type_info;

	[Token(Token = "0x4009F19")]
	[FieldOffset(Offset = "0xC")]
	public List<MultiIntimacyRankAwardDesc> multi_intimacy_rank_award;

	[Token(Token = "0x4009F1A")]
	[FieldOffset(Offset = "0x10")]
	public MentorSettingDesc mentor_setting_desc;

	[Token(Token = "0x6007F8E")]
	[Address(RVA = "0x31815C8", Offset = "0x31815C8", VA = "0x31815C8")]
	public CSGetAllChummyDescRes()
	{
	}
}
