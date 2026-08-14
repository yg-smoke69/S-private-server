using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018DE")]
public class CSUpdateWorkshopBasicInfoReq
{
	[Token(Token = "0x4009E0B")]
	[FieldOffset(Offset = "0x8")]
	public uint slot_id;

	[Token(Token = "0x4009E0C")]
	[FieldOffset(Offset = "0xC")]
	public EWorkshop.SlotType slot_type;

	[Token(Token = "0x4009E0D")]
	[FieldOffset(Offset = "0x10")]
	public WorkshopBasicInfo basic_info;

	[Token(Token = "0x6007F37")]
	[Address(RVA = "0x309A7E0", Offset = "0x309A7E0", VA = "0x309A7E0")]
	public CSUpdateWorkshopBasicInfoReq()
	{
	}
}
