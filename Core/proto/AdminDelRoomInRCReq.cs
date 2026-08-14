using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200143A")]
public class AdminDelRoomInRCReq
{
	[Token(Token = "0x4008CE8")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x4008CE9")]
	[FieldOffset(Offset = "0x10")]
	public ulong room_id;

	[Token(Token = "0x4008CEA")]
	[FieldOffset(Offset = "0x18")]
	public uint room_type;

	[Token(Token = "0x6007AEC")]
	[Address(RVA = "0x317A5B0", Offset = "0x317A5B0", VA = "0x317A5B0")]
	public AdminDelRoomInRCReq()
	{
	}
}
