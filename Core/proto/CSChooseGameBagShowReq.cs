using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015A3")]
public class CSChooseGameBagShowReq
{
	[Token(Token = "0x40093C2")]
	[FieldOffset(Offset = "0x8")]
	public uint game_bag_id;

	[Token(Token = "0x40093C3")]
	[FieldOffset(Offset = "0x10")]
	public ulong group_id;

	[Token(Token = "0x6007BEB")]
	[Address(RVA = "0x317E304", Offset = "0x317E304", VA = "0x317E304")]
	public CSChooseGameBagShowReq()
	{
	}
}
