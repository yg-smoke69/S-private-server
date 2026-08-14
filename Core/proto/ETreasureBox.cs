using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001308")]
public class ETreasureBox
{
	[Token(Token = "0x2001309")]
	public enum BoxType
	{
		[Token(Token = "0x40086D9")]
		BoxType_NONE,
		[Token(Token = "0x40086DA")]
		BoxType_STORE,
		[Token(Token = "0x40086DB")]
		BoxType_LOADOUT,
		[Token(Token = "0x40086DC")]
		BoxType_CRATE,
		[Token(Token = "0x40086DD")]
		BoxType_AUTOOPEN
	}

	[Token(Token = "0x6007A48")]
	[Address(RVA = "0x309F914", Offset = "0x309F914", VA = "0x309F914")]
	public ETreasureBox()
	{
	}
}
