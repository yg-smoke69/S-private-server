using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B87")]
public class PlayerBattleTagDesc
{
	[Token(Token = "0x400AD1F")]
	[FieldOffset(Offset = "0x8")]
	public ESocial.PlayerBattleTagID tag_id;

	[Token(Token = "0x400AD20")]
	[FieldOffset(Offset = "0xC")]
	public uint tag_sub_id;

	[Token(Token = "0x400AD21")]
	[FieldOffset(Offset = "0x10")]
	public uint game_mode;

	[Token(Token = "0x400AD22")]
	[FieldOffset(Offset = "0x14")]
	public uint match_mode;

	[Token(Token = "0x400AD23")]
	[FieldOffset(Offset = "0x18")]
	public uint tag_priority;

	[Token(Token = "0x400AD24")]
	[FieldOffset(Offset = "0x1C")]
	public List<PlayerBattleTagCdt> battle_tag_cdt;

	[Token(Token = "0x60081E2")]
	[Address(RVA = "0x33DFF5C", Offset = "0x33DFF5C", VA = "0x33DFF5C")]
	public PlayerBattleTagDesc()
	{
	}
}
