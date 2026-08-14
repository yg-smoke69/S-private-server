using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001529")]
public class killInfo
{
	[Token(Token = "0x40091EA")]
	[FieldOffset(Offset = "0x8")]
	public uint kill_time;

	[Token(Token = "0x40091EB")]
	[FieldOffset(Offset = "0xC")]
	public uint kill_hp;

	[Token(Token = "0x6007B72")]
	[Address(RVA = "0x33E6CD8", Offset = "0x33E6CD8", VA = "0x33E6CD8")]
	public killInfo()
	{
	}
}
