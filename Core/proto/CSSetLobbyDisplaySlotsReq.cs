using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015CB")]
public class CSSetLobbyDisplaySlotsReq
{
	[Token(Token = "0x400944B")]
	[FieldOffset(Offset = "0x8")]
	public uint display_slot_type;

	[Token(Token = "0x400944C")]
	[FieldOffset(Offset = "0xC")]
	public uint display_slot_id;

	[Token(Token = "0x400944D")]
	[FieldOffset(Offset = "0x10")]
	public uint auto_rotate;

	[Token(Token = "0x6007C15")]
	[Address(RVA = "0x3099B48", Offset = "0x3099B48", VA = "0x3099B48")]
	public CSSetLobbyDisplaySlotsReq()
	{
	}
}
