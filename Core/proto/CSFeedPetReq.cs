using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001554")]
public class CSFeedPetReq
{
	[Token(Token = "0x40092C5")]
	[FieldOffset(Offset = "0x8")]
	public uint pet_id;

	[Token(Token = "0x40092C6")]
	[FieldOffset(Offset = "0xC")]
	public uint food_id;

	[Token(Token = "0x40092C7")]
	[FieldOffset(Offset = "0x10")]
	public uint food_num;

	[Token(Token = "0x40092C8")]
	[FieldOffset(Offset = "0x18")]
	public ulong group_id;

	[Token(Token = "0x6007B9C")]
	[Address(RVA = "0x3180524", Offset = "0x3180524", VA = "0x3180524")]
	public CSFeedPetReq()
	{
	}
}
