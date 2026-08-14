using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015A4")]
public class CSChoosePinReq
{
	[Token(Token = "0x40093C4")]
	[FieldOffset(Offset = "0x8")]
	public uint pin_id;

	[Token(Token = "0x40093C5")]
	[FieldOffset(Offset = "0x10")]
	public ulong group_id;

	[Token(Token = "0x6007BEC")]
	[Address(RVA = "0x317E324", Offset = "0x317E324", VA = "0x317E324")]
	public CSChoosePinReq()
	{
	}
}
