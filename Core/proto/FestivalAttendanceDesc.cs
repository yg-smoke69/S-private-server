using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A13")]
public class FestivalAttendanceDesc
{
	[Token(Token = "0x400A381")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A382")]
	[FieldOffset(Offset = "0xC")]
	public uint index_id;

	[Token(Token = "0x400A383")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400A384")]
	[FieldOffset(Offset = "0x14")]
	public uint free_max_num;

	[Token(Token = "0x400A385")]
	[FieldOffset(Offset = "0x18")]
	public uint drop_max_num;

	[Token(Token = "0x600806B")]
	[Address(RVA = "0x30A0C4C", Offset = "0x30A0C4C", VA = "0x30A0C4C")]
	public FestivalAttendanceDesc()
	{
	}
}
