using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018EB")]
public class CSSubscribeWorkshopCodeReq
{
	[Token(Token = "0x4009E34")]
	[FieldOffset(Offset = "0x8")]
	public uint slot_id;

	[Token(Token = "0x4009E35")]
	[FieldOffset(Offset = "0xC")]
	public string workshop_code;

	[Token(Token = "0x4009E36")]
	[FieldOffset(Offset = "0x10")]
	public uint subscription_source;

	[Token(Token = "0x6007F44")]
	[Address(RVA = "0x3099EC4", Offset = "0x3099EC4", VA = "0x3099EC4")]
	public CSSubscribeWorkshopCodeReq()
	{
	}
}
