using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018E0")]
public class CSDownloadWorkshopReq
{
	[Token(Token = "0x4009E10")]
	[FieldOffset(Offset = "0x8")]
	public EWorkshop.SlotType slot_type;

	[Token(Token = "0x4009E11")]
	[FieldOffset(Offset = "0xC")]
	public uint slot_id;

	[Token(Token = "0x4009E12")]
	[FieldOffset(Offset = "0x10")]
	public bool need_export_settings;

	[Token(Token = "0x6007F39")]
	[Address(RVA = "0x317FAB4", Offset = "0x317FAB4", VA = "0x317FAB4")]
	public CSDownloadWorkshopReq()
	{
	}
}
