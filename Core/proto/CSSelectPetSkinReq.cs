using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001559")]
public class CSSelectPetSkinReq
{
	[Token(Token = "0x40092D6")]
	[FieldOffset(Offset = "0x8")]
	public uint pet_id;

	[Token(Token = "0x40092D7")]
	[FieldOffset(Offset = "0xC")]
	public uint skin_id;

	[Token(Token = "0x40092D8")]
	[FieldOffset(Offset = "0x10")]
	public bool is_selected;

	[Token(Token = "0x40092D9")]
	[FieldOffset(Offset = "0x18")]
	public ulong group_id;

	[Token(Token = "0x6007BA1")]
	[Address(RVA = "0x309976C", Offset = "0x309976C", VA = "0x309976C")]
	public CSSelectPetSkinReq()
	{
	}
}
