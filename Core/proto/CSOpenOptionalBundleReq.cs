using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015AB")]
public class CSOpenOptionalBundleReq
{
	[Token(Token = "0x40093DF")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x40093E0")]
	[FieldOffset(Offset = "0xC")]
	public uint option_order;

	[Token(Token = "0x6007BF3")]
	[Address(RVA = "0x3098298", Offset = "0x3098298", VA = "0x3098298")]
	public CSOpenOptionalBundleReq()
	{
	}
}
