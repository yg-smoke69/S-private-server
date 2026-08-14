using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001557")]
public class CSRenamePetReq
{
	[Token(Token = "0x40092D1")]
	[FieldOffset(Offset = "0x8")]
	public uint pet_id;

	[Token(Token = "0x40092D2")]
	[FieldOffset(Offset = "0xC")]
	public string name;

	[Token(Token = "0x40092D3")]
	[FieldOffset(Offset = "0x10")]
	public ulong group_id;

	[Token(Token = "0x6007B9F")]
	[Address(RVA = "0x30991D4", Offset = "0x30991D4", VA = "0x30991D4")]
	public CSRenamePetReq()
	{
	}
}
