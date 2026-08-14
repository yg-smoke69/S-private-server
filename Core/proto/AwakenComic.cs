using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001384")]
public class AwakenComic
{
	[Token(Token = "0x40089C2")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40089C3")]
	[FieldOffset(Offset = "0x10")]
	public uint original_avatar_id;

	[Token(Token = "0x40089C4")]
	[FieldOffset(Offset = "0x14")]
	public uint comic_id;

	[Token(Token = "0x40089C5")]
	[FieldOffset(Offset = "0x18")]
	public uint unlock_num;

	[Token(Token = "0x6007A85")]
	[Address(RVA = "0x317B2D4", Offset = "0x317B2D4", VA = "0x317B2D4")]
	public AwakenComic()
	{
	}
}
