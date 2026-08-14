using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A08")]
public class AttendanceDesc
{
	[Token(Token = "0x400A336")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A337")]
	[FieldOffset(Offset = "0xC")]
	public uint index_id;

	[Token(Token = "0x400A338")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400A339")]
	[FieldOffset(Offset = "0x14")]
	public uint weight;

	[Token(Token = "0x400A33A")]
	[FieldOffset(Offset = "0x18")]
	public bool is_big_prize;

	[Token(Token = "0x6008060")]
	[Address(RVA = "0x317AE3C", Offset = "0x317AE3C", VA = "0x317AE3C")]
	public AttendanceDesc()
	{
	}
}
