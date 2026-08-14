using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200143C")]
public class CustomRoomGroupStats
{
	[Token(Token = "0x4008CF4")]
	[FieldOffset(Offset = "0x8")]
	public ulong group_id;

	[Token(Token = "0x4008CF5")]
	[FieldOffset(Offset = "0x10")]
	public uint rank;

	[Token(Token = "0x4008CF6")]
	[FieldOffset(Offset = "0x14")]
	public uint score;

	[Token(Token = "0x4008CF7")]
	[FieldOffset(Offset = "0x18")]
	public List<CustomRoomPlayerStats> members;

	[Token(Token = "0x4008CF8")]
	[FieldOffset(Offset = "0x1C")]
	public string name;

	[Token(Token = "0x6007AEE")]
	[Address(RVA = "0x309E3E0", Offset = "0x309E3E0", VA = "0x309E3E0")]
	public CustomRoomGroupStats()
	{
	}
}
