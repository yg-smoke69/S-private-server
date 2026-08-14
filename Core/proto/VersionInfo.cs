using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001438")]
public class VersionInfo
{
	[Token(Token = "0x4008CE3")]
	[FieldOffset(Offset = "0x8")]
	public string node;

	[Token(Token = "0x4008CE4")]
	[FieldOffset(Offset = "0x10")]
	public long version;

	[Token(Token = "0x6007AEA")]
	[Address(RVA = "0x33E42BC", Offset = "0x33E42BC", VA = "0x33E42BC")]
	public VersionInfo()
	{
	}
}
