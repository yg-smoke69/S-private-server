using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A46")]
public class LimitNotifyControlDesc
{
	[Token(Token = "0x400A48A")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A48B")]
	[FieldOffset(Offset = "0x10")]
	public long notify_start_time;

	[Token(Token = "0x400A48C")]
	[FieldOffset(Offset = "0x18")]
	public long notify_end_time;

	[Token(Token = "0x400A48D")]
	[FieldOffset(Offset = "0x20")]
	public List<ModeRecord> modes;

	[Token(Token = "0x400A48E")]
	[FieldOffset(Offset = "0x24")]
	public uint[] groups;

	[Token(Token = "0x600809E")]
	[Address(RVA = "0x30A46DC", Offset = "0x30A46DC", VA = "0x30A46DC")]
	public LimitNotifyControlDesc()
	{
	}
}
