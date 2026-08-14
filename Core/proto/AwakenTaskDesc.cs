using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A5A")]
public class AwakenTaskDesc
{
	[Token(Token = "0x400A506")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A507")]
	[FieldOffset(Offset = "0xC")]
	public uint task_type;

	[Token(Token = "0x400A508")]
	[FieldOffset(Offset = "0x10")]
	public uint task_value;

	[Token(Token = "0x400A509")]
	[FieldOffset(Offset = "0x14")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400A50A")]
	[FieldOffset(Offset = "0x18")]
	public uint task_sub_value;

	[Token(Token = "0x60080B2")]
	[Address(RVA = "0x317B2EC", Offset = "0x317B2EC", VA = "0x317B2EC")]
	public AwakenTaskDesc()
	{
	}
}
