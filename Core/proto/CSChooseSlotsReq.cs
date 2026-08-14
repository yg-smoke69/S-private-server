using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200159D")]
public class CSChooseSlotsReq
{
	[Token(Token = "0x40093B7")]
	[FieldOffset(Offset = "0x8")]
	public uint[] slots;

	[Token(Token = "0x40093B8")]
	[FieldOffset(Offset = "0x10")]
	public ulong group_id;

	[Token(Token = "0x6007BE5")]
	[Address(RVA = "0x317E508", Offset = "0x317E508", VA = "0x317E508")]
	public CSChooseSlotsReq()
	{
	}
}
