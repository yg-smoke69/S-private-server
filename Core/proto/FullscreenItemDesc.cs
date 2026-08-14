using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019B9")]
public class FullscreenItemDesc
{
	[Token(Token = "0x400A135")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400A136")]
	[FieldOffset(Offset = "0xC")]
	public bool is_open;

	[Token(Token = "0x6008011")]
	[Address(RVA = "0x30A16A8", Offset = "0x30A16A8", VA = "0x30A16A8")]
	public FullscreenItemDesc()
	{
	}
}
