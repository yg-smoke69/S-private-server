using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A1C")]
public class InstantGameConfigDesc
{
	[Token(Token = "0x400A3AB")]
	[FieldOffset(Offset = "0x8")]
	public uint download_item_id;

	[Token(Token = "0x400A3AC")]
	[FieldOffset(Offset = "0xC")]
	public uint download_item_num;

	[Token(Token = "0x6008074")]
	[Address(RVA = "0x30A3D24", Offset = "0x30A3D24", VA = "0x30A3D24")]
	public InstantGameConfigDesc()
	{
	}
}
