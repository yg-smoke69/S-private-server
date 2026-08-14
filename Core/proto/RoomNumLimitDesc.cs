using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019F3")]
public class RoomNumLimitDesc
{
	[Token(Token = "0x400A2E4")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A2E5")]
	[FieldOffset(Offset = "0xC")]
	public uint max_in_game_room_num;

	[Token(Token = "0x400A2E6")]
	[FieldOffset(Offset = "0x10")]
	public uint tab_type;

	[Token(Token = "0x600804B")]
	[Address(RVA = "0x33E1D88", Offset = "0x33E1D88", VA = "0x33E1D88")]
	public RoomNumLimitDesc()
	{
	}
}
