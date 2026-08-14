using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200149C")]
public class LoginQueueInfo
{
	[Token(Token = "0x4008F0B")]
	[FieldOffset(Offset = "0x8")]
	public bool Allow;

	[Token(Token = "0x4008F0C")]
	[FieldOffset(Offset = "0xC")]
	public uint queue_position;

	[Token(Token = "0x4008F0D")]
	[FieldOffset(Offset = "0x10")]
	public uint need_wait_secs;

	[Token(Token = "0x4008F0E")]
	[FieldOffset(Offset = "0x14")]
	public bool queue_is_full;

	[Token(Token = "0x6007B0D")]
	[Address(RVA = "0x30A6900", Offset = "0x30A6900", VA = "0x30A6900")]
	public LoginQueueInfo()
	{
	}
}
