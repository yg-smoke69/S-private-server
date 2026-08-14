using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E1F")]
public class RoundNumConfigInfo
{
	[Token(Token = "0x4011A5F")]
	[FieldOffset(Offset = "0x8")]
	public uint Key;

	[Token(Token = "0x4011A60")]
	[FieldOffset(Offset = "0xC")]
	public string RoundNum;

	[Token(Token = "0x60134D4")]
	[Address(RVA = "0x2411024", Offset = "0x2411024", VA = "0x2411024")]
	public RoundNumConfigInfo()
	{
	}
}
