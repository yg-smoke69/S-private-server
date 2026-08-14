using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001599")]
public class CSChooseLoadoutReq
{
	[Token(Token = "0x40093AF")]
	[FieldOffset(Offset = "0x8")]
	public uint[] loadouts;

	[Token(Token = "0x40093B0")]
	[FieldOffset(Offset = "0x10")]
	public ulong group_id;

	[Token(Token = "0x40093B1")]
	[FieldOffset(Offset = "0x18")]
	public ulong room_id;

	[Token(Token = "0x6007BE1")]
	[Address(RVA = "0x317E314", Offset = "0x317E314", VA = "0x317E314")]
	public CSChooseLoadoutReq()
	{
	}
}
