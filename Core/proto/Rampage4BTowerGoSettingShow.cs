using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C10")]
public class Rampage4BTowerGoSettingShow
{
	[Token(Token = "0x400B096")]
	[FieldOffset(Offset = "0x8")]
	public uint hyper_per_move;

	[Token(Token = "0x400B097")]
	[FieldOffset(Offset = "0xC")]
	public AwardDesc box_award;

	[Token(Token = "0x400B098")]
	[FieldOffset(Offset = "0x10")]
	public AwardDesc book_token;

	[Token(Token = "0x400B099")]
	[FieldOffset(Offset = "0x14")]
	public AwardDesc boss1_award;

	[Token(Token = "0x400B09A")]
	[FieldOffset(Offset = "0x18")]
	public AwardDesc boss2_award;

	[Token(Token = "0x400B09B")]
	[FieldOffset(Offset = "0x1C")]
	public AwardDesc boss3_award;

	[Token(Token = "0x400B09C")]
	[FieldOffset(Offset = "0x20")]
	public long buff_time;

	[Token(Token = "0x600826A")]
	[Address(RVA = "0x33E03DC", Offset = "0x33E03DC", VA = "0x33E03DC")]
	public Rampage4BTowerGoSettingShow()
	{
	}
}
