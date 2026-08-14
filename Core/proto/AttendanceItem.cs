using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001602")]
public class AttendanceItem
{
	[Token(Token = "0x40094C8")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x40094C9")]
	[FieldOffset(Offset = "0xC")]
	public uint signed;

	[Token(Token = "0x40094CA")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> awards;

	[Token(Token = "0x40094CB")]
	[FieldOffset(Offset = "0x14")]
	public bool is_big_prize;

	[Token(Token = "0x6007C4C")]
	[Address(RVA = "0x317AEC8", Offset = "0x317AEC8", VA = "0x317AEC8")]
	public AttendanceItem()
	{
	}
}
