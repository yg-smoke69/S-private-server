using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20021DC")]
public class OtherChannelInfo
{
	[Token(Token = "0x400D3CD")]
	[FieldOffset(Offset = "0x8")]
	public string key;

	[Token(Token = "0x400D3CE")]
	[FieldOffset(Offset = "0xC")]
	public string icon;

	[Token(Token = "0x600B5AB")]
	[Address(RVA = "0x28C956C", Offset = "0x28C956C", VA = "0x28C956C")]
	public OtherChannelInfo()
	{
	}
}
