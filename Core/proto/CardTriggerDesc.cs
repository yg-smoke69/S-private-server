using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AD3")]
public class CardTriggerDesc
{
	[Token(Token = "0x400A8D3")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A8D4")]
	[FieldOffset(Offset = "0xC")]
	public uint match_mode;

	[Token(Token = "0x400A8D5")]
	[FieldOffset(Offset = "0x10")]
	public uint map_id;

	[Token(Token = "0x400A8D6")]
	[FieldOffset(Offset = "0x14")]
	public uint game_mode;

	[Token(Token = "0x400A8D7")]
	[FieldOffset(Offset = "0x18")]
	public bool trigger_card;

	[Token(Token = "0x400A8D8")]
	[FieldOffset(Offset = "0x1C")]
	public uint rank_need;

	[Token(Token = "0x400A8D9")]
	[FieldOffset(Offset = "0x20")]
	public uint kill_need;

	[Token(Token = "0x400A8DA")]
	[FieldOffset(Offset = "0x24")]
	public bool win_award;

	[Token(Token = "0x6008130")]
	[Address(RVA = "0x309AC58", Offset = "0x309AC58", VA = "0x309AC58")]
	public CardTriggerDesc()
	{
	}
}
