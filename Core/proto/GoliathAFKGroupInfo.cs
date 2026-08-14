using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001815")]
public class GoliathAFKGroupInfo
{
	[Token(Token = "0x4009C04")]
	[FieldOffset(Offset = "0x8")]
	public ulong group_id;

	[Token(Token = "0x4009C05")]
	[FieldOffset(Offset = "0x10")]
	public ulong captain_id;

	[Token(Token = "0x4009C06")]
	[FieldOffset(Offset = "0x18")]
	public List<GoliathAFKGroupMember> members;

	[Token(Token = "0x4009C07")]
	[FieldOffset(Offset = "0x1C")]
	public uint task_id;

	[Token(Token = "0x4009C08")]
	[FieldOffset(Offset = "0x20")]
	public long start_time_stamp;

	[Token(Token = "0x4009C09")]
	[FieldOffset(Offset = "0x28")]
	public long create_time_stamp;

	[Token(Token = "0x6007E6F")]
	[Address(RVA = "0x30A298C", Offset = "0x30A298C", VA = "0x30A298C")]
	public GoliathAFKGroupInfo()
	{
	}
}
