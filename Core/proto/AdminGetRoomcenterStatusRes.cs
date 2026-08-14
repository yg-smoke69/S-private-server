using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001439")]
public class AdminGetRoomcenterStatusRes
{
	[Token(Token = "0x4008CE5")]
	[FieldOffset(Offset = "0x8")]
	public uint room_node_cnt;

	[Token(Token = "0x4008CE6")]
	[FieldOffset(Offset = "0xC")]
	public List<VersionInfo> versions;

	[Token(Token = "0x4008CE7")]
	[FieldOffset(Offset = "0x10")]
	public bool is_roomcenter_ready;

	[Token(Token = "0x6007AEB")]
	[Address(RVA = "0x317A650", Offset = "0x317A650", VA = "0x317A650")]
	public AdminGetRoomcenterStatusRes()
	{
	}
}
