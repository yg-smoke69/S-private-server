using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001672")]
public class CSChangeClothesReq
{
	[Token(Token = "0x4009633")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x4009634")]
	[FieldOffset(Offset = "0xC")]
	public uint[] clothes;

	[Token(Token = "0x4009635")]
	[FieldOffset(Offset = "0x10")]
	public uint skin_color;

	[Token(Token = "0x4009636")]
	[FieldOffset(Offset = "0x18")]
	public ulong room_id;

	[Token(Token = "0x4009637")]
	[FieldOffset(Offset = "0x20")]
	public ulong group_id;

	[Token(Token = "0x6007CBC")]
	[Address(RVA = "0x317E2BC", Offset = "0x317E2BC", VA = "0x317E2BC")]
	public CSChangeClothesReq()
	{
	}
}
