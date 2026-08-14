using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019F7")]
public class RoomSeparateNodeDesc
{
	[Token(Token = "0x400A2FE")]
	[FieldOffset(Offset = "0x8")]
	public uint grab_node_num;

	[Token(Token = "0x400A2FF")]
	[FieldOffset(Offset = "0xC")]
	public uint each_node_room_num;

	[Token(Token = "0x600804F")]
	[Address(RVA = "0x33E1E30", Offset = "0x33E1E30", VA = "0x33E1E30")]
	public RoomSeparateNodeDesc()
	{
	}
}
