using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019F9")]
public class MtpConfigDesc
{
	[Token(Token = "0x400A302")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A303")]
	[FieldOffset(Offset = "0xC")]
	public bool enable;

	[Token(Token = "0x6008051")]
	[Address(RVA = "0x30A90CC", Offset = "0x30A90CC", VA = "0x30A90CC")]
	public MtpConfigDesc()
	{
	}
}
