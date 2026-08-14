using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018EE")]
public class CSDeleteWorkshopInfoReq
{
	[Token(Token = "0x4009E3C")]
	[FieldOffset(Offset = "0x8")]
	public EWorkshop.SlotType slot_type;

	[Token(Token = "0x4009E3D")]
	[FieldOffset(Offset = "0xC")]
	public uint slot_id;

	[Token(Token = "0x6007F47")]
	[Address(RVA = "0x317F648", Offset = "0x317F648", VA = "0x317F648")]
	public CSDeleteWorkshopInfoReq()
	{
	}
}
