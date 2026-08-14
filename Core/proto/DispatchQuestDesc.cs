using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A64")]
public class DispatchQuestDesc
{
	[Token(Token = "0x400A532")]
	[FieldOffset(Offset = "0x8")]
	public uint quest_line;

	[Token(Token = "0x400A533")]
	[FieldOffset(Offset = "0xC")]
	public uint quest_id;

	[Token(Token = "0x400A534")]
	[FieldOffset(Offset = "0x10")]
	public bool is_repeated;

	[Token(Token = "0x400A535")]
	[FieldOffset(Offset = "0x14")]
	public float quest_time;

	[Token(Token = "0x400A536")]
	[FieldOffset(Offset = "0x18")]
	public uint quest_number;

	[Token(Token = "0x400A537")]
	[FieldOffset(Offset = "0x1C")]
	public List<ExchangedAward> awards;

	[Token(Token = "0x400A538")]
	[FieldOffset(Offset = "0x20")]
	public float critical_rate;

	[Token(Token = "0x400A539")]
	[FieldOffset(Offset = "0x24")]
	public uint critical_times;

	[Token(Token = "0x60080C1")]
	[Address(RVA = "0x309F05C", Offset = "0x309F05C", VA = "0x309F05C")]
	public DispatchQuestDesc()
	{
	}
}
