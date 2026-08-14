using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017C4")]
public class LinkageProcessRewards
{
	[Token(Token = "0x4009B61")]
	[FieldOffset(Offset = "0x8")]
	public uint process_id;

	[Token(Token = "0x4009B62")]
	[FieldOffset(Offset = "0xC")]
	public EPProcess_Status status;

	[Token(Token = "0x4009B63")]
	[FieldOffset(Offset = "0x10")]
	public ulong target_value;

	[Token(Token = "0x6007E1E")]
	[Address(RVA = "0x30A6414", Offset = "0x30A6414", VA = "0x30A6414")]
	public LinkageProcessRewards()
	{
	}
}
