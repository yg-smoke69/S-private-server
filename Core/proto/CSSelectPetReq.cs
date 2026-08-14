using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001556")]
public class CSSelectPetReq
{
	[Token(Token = "0x40092CE")]
	[FieldOffset(Offset = "0x8")]
	public uint pet_id;

	[Token(Token = "0x40092CF")]
	[FieldOffset(Offset = "0xC")]
	public bool is_selected;

	[Token(Token = "0x40092D0")]
	[FieldOffset(Offset = "0x10")]
	public ulong group_id;

	[Token(Token = "0x6007B9E")]
	[Address(RVA = "0x309975C", Offset = "0x309975C", VA = "0x309975C")]
	public CSSelectPetReq()
	{
	}
}
