using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001707")]
public class WeeklyProcessStatus
{
	[Token(Token = "0x400983E")]
	[FieldOffset(Offset = "0x8")]
	public uint node_id;

	[Token(Token = "0x400983F")]
	[FieldOffset(Offset = "0xC")]
	public EPProcess_Status status;

	[Token(Token = "0x6007D61")]
	[Address(RVA = "0x33E55FC", Offset = "0x33E55FC", VA = "0x33E55FC")]
	public WeeklyProcessStatus()
	{
	}
}
