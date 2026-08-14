using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019F2")]
public class RoomCreateRuleDesc
{
	[Token(Token = "0x400A2DC")]
	[FieldOffset(Offset = "0x8")]
	public uint map_id;

	[Token(Token = "0x400A2DD")]
	[FieldOffset(Offset = "0xC")]
	public uint game_mode;

	[Token(Token = "0x400A2DE")]
	[FieldOffset(Offset = "0x10")]
	public uint group_mode;

	[Token(Token = "0x400A2DF")]
	[FieldOffset(Offset = "0x14")]
	public uint[] members;

	[Token(Token = "0x400A2E0")]
	[FieldOffset(Offset = "0x18")]
	public uint[] spectators;

	[Token(Token = "0x400A2E1")]
	[FieldOffset(Offset = "0x1C")]
	public uint room_type;

	[Token(Token = "0x400A2E2")]
	[FieldOffset(Offset = "0x20")]
	public uint min_member_cnt;

	[Token(Token = "0x400A2E3")]
	[FieldOffset(Offset = "0x24")]
	public bool enable_voice_chat;

	[Token(Token = "0x600804A")]
	[Address(RVA = "0x33E1C08", Offset = "0x33E1C08", VA = "0x33E1C08")]
	public RoomCreateRuleDesc()
	{
	}
}
