using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001618")]
public class CSGetSecretMissionCodeRes
{
	[Token(Token = "0x400952C")]
	[FieldOffset(Offset = "0x8")]
	public ulong secret_code;

	[Token(Token = "0x400952D")]
	[FieldOffset(Offset = "0x10")]
	public uint key_exchanged_nums;

	[Token(Token = "0x6007C62")]
	[Address(RVA = "0x30953C8", Offset = "0x30953C8", VA = "0x30953C8")]
	public CSGetSecretMissionCodeRes()
	{
	}
}
