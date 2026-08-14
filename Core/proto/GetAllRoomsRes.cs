using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001437")]
public class GetAllRoomsRes
{
	[Token(Token = "0x4008CE2")]
	[FieldOffset(Offset = "0x8")]
	public List<RoomBasicInfo> rooms;

	[Token(Token = "0x6007AE9")]
	[Address(RVA = "0x30A1E00", Offset = "0x30A1E00", VA = "0x30A1E00")]
	public GetAllRoomsRes()
	{
	}
}
