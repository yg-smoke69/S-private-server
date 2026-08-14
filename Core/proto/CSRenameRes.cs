using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001558")]
public class CSRenameRes
{
	[Token(Token = "0x40092D4")]
	[FieldOffset(Offset = "0x8")]
	public uint pet_id;

	[Token(Token = "0x40092D5")]
	[FieldOffset(Offset = "0xC")]
	public string name;

	[Token(Token = "0x6007BA0")]
	[Address(RVA = "0x3099274", Offset = "0x3099274", VA = "0x3099274")]
	public CSRenameRes()
	{
	}
}
