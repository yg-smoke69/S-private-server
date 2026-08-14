using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018E8")]
public class CreateWorkshopRoomInfo
{
	[Token(Token = "0x4009E2D")]
	[FieldOffset(Offset = "0x8")]
	public uint general_times;

	[Token(Token = "0x4009E2E")]
	[FieldOffset(Offset = "0xC")]
	public FreeWorkshopRoomCreateDesc free_create_room_desc;

	[Token(Token = "0x4009E2F")]
	[FieldOffset(Offset = "0x10")]
	public bool refresh;

	[Token(Token = "0x6007F41")]
	[Address(RVA = "0x309D84C", Offset = "0x309D84C", VA = "0x309D84C")]
	public CreateWorkshopRoomInfo()
	{
	}
}
