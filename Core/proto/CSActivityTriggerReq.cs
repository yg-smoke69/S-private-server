using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200160A")]
public class CSActivityTriggerReq
{
	[Token(Token = "0x40094DF")]
	[FieldOffset(Offset = "0x8")]
	public uint event_type;

	[Token(Token = "0x40094E0")]
	[FieldOffset(Offset = "0xC")]
	public string language;

	[Token(Token = "0x40094E1")]
	[FieldOffset(Offset = "0x10")]
	public uint[] optional_download_id;

	[Token(Token = "0x6007C54")]
	[Address(RVA = "0x317D9F8", Offset = "0x317D9F8", VA = "0x317D9F8")]
	public CSActivityTriggerReq()
	{
	}
}
