using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018E7")]
public class CSGetWorkshopBasicInfoRes
{
	[Token(Token = "0x4009E27")]
	[FieldOffset(Offset = "0x8")]
	public List<WorkshopSubscribeSlotInfo> subscribe_slots_info;

	[Token(Token = "0x4009E28")]
	[FieldOffset(Offset = "0xC")]
	public List<WorkshopClassicSlotInfo> classic_slots_info;

	[Token(Token = "0x4009E29")]
	[FieldOffset(Offset = "0x10")]
	public bool workshop_banned;

	[Token(Token = "0x4009E2A")]
	[FieldOffset(Offset = "0x11")]
	public bool is_manager;

	[Token(Token = "0x4009E2B")]
	[FieldOffset(Offset = "0x14")]
	public List<WorkshopAuthorSlotInfo> author_slots_info;

	[Token(Token = "0x4009E2C")]
	[FieldOffset(Offset = "0x18")]
	public CreateWorkshopRoomInfo create_workshop_room_info;

	[Token(Token = "0x6007F40")]
	[Address(RVA = "0x3096A14", Offset = "0x3096A14", VA = "0x3096A14")]
	public CSGetWorkshopBasicInfoRes()
	{
	}
}
