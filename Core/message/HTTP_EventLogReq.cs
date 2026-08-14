using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001C3E")]
public class HTTP_EventLogReq
{
	[Token(Token = "0x400B40D")]
	[FieldOffset(Offset = "0x8")]
	public string event_type;

	[Token(Token = "0x400B40E")]
	[FieldOffset(Offset = "0xC")]
	public string event_payload;

	[Token(Token = "0x6008295")]
	[Address(RVA = "0x36148E0", Offset = "0x36148E0", VA = "0x36148E0")]
	public HTTP_EventLogReq()
	{
	}
}
