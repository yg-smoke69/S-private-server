using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015A2")]
public class CSChooseShowReq
{
	[Token(Token = "0x40093C0")]
	[FieldOffset(Offset = "0x8")]
	public uint[] shows;

	[Token(Token = "0x40093C1")]
	[FieldOffset(Offset = "0x10")]
	public ulong group_id;

	[Token(Token = "0x6007BEA")]
	[Address(RVA = "0x317E500", Offset = "0x317E500", VA = "0x317E500")]
	public CSChooseShowReq()
	{
	}
}
