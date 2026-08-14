using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001603")]
public class FestivalAttendanceItem
{
	[Token(Token = "0x40094CC")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x40094CD")]
	[FieldOffset(Offset = "0xC")]
	public uint signed;

	[Token(Token = "0x40094CE")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> awards;

	[Token(Token = "0x40094CF")]
	[FieldOffset(Offset = "0x14")]
	public uint drop_max_num;

	[Token(Token = "0x6007C4D")]
	[Address(RVA = "0x30A0CD8", Offset = "0x30A0CD8", VA = "0x30A0CD8")]
	public FestivalAttendanceItem()
	{
	}
}
