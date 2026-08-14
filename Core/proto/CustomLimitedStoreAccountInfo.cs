using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200145A")]
public class CustomLimitedStoreAccountInfo
{
	[Token(Token = "0x4008D5E")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x4008D5F")]
	[FieldOffset(Offset = "0xC")]
	public uint sku_id;

	[Token(Token = "0x4008D60")]
	[FieldOffset(Offset = "0x10")]
	public uint purchase_times;

	[Token(Token = "0x6007B01")]
	[Address(RVA = "0x309E3D8", Offset = "0x309E3D8", VA = "0x309E3D8")]
	public CustomLimitedStoreAccountInfo()
	{
	}
}
