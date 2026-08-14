using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B89")]
public class AndroidApplicationToDetectDesc
{
	[Token(Token = "0x400AD27")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AD28")]
	[FieldOffset(Offset = "0xC")]
	public string bundle_identifier;

	[Token(Token = "0x60081E4")]
	[Address(RVA = "0x317A79C", Offset = "0x317A79C", VA = "0x317A79C")]
	public AndroidApplicationToDetectDesc()
	{
	}
}
