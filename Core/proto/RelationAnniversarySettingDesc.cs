using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001ACA")]
public class RelationAnniversarySettingDesc
{
	[Token(Token = "0x400A8AC")]
	[FieldOffset(Offset = "0x8")]
	public uint idx;

	[Token(Token = "0x400A8AD")]
	[FieldOffset(Offset = "0xC")]
	public EFriend.RelationType relation_type;

	[Token(Token = "0x400A8AE")]
	[FieldOffset(Offset = "0x10")]
	public uint anniversary_day;

	[Token(Token = "0x6008127")]
	[Address(RVA = "0x33E171C", Offset = "0x33E171C", VA = "0x33E171C")]
	public RelationAnniversarySettingDesc()
	{
	}
}
