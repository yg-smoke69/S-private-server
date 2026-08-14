using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001708")]
public class DailyProcessStatus
{
	[Token(Token = "0x4009840")]
	[FieldOffset(Offset = "0x8")]
	public uint node_id;

	[Token(Token = "0x4009841")]
	[FieldOffset(Offset = "0xC")]
	public EPProcess_Status status;

	[Token(Token = "0x6007D62")]
	[Address(RVA = "0x309E550", Offset = "0x309E550", VA = "0x309E550")]
	public DailyProcessStatus()
	{
	}
}
