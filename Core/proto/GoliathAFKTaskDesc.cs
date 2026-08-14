using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B4F")]
public class GoliathAFKTaskDesc
{
	[Token(Token = "0x400ABC6")]
	[FieldOffset(Offset = "0x8")]
	public uint task_id;

	[Token(Token = "0x400ABC7")]
	[FieldOffset(Offset = "0xC")]
	public uint duration;

	[Token(Token = "0x400ABC8")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> awards;

	[Token(Token = "0x60081AA")]
	[Address(RVA = "0x30A2AB8", Offset = "0x30A2AB8", VA = "0x30A2AB8")]
	public GoliathAFKTaskDesc()
	{
	}
}
