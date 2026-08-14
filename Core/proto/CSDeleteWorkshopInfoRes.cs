using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018EF")]
public class CSDeleteWorkshopInfoRes
{
	[Token(Token = "0x4009E3E")]
	[FieldOffset(Offset = "0x8")]
	public EWorkshop.SlotType slot_type;

	[Token(Token = "0x4009E3F")]
	[FieldOffset(Offset = "0xC")]
	public uint slot_id;

	[Token(Token = "0x6007F48")]
	[Address(RVA = "0x317F650", Offset = "0x317F650", VA = "0x317F650")]
	public CSDeleteWorkshopInfoRes()
	{
	}
}
