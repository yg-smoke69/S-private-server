using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E20")]
public class InitCoinConfigInfo
{
	[Token(Token = "0x4011A61")]
	[FieldOffset(Offset = "0x8")]
	public uint Key;

	[Token(Token = "0x4011A62")]
	[FieldOffset(Offset = "0xC")]
	public string InitCoin;

	[Token(Token = "0x60134D5")]
	[Address(RVA = "0x2C80978", Offset = "0x2C80978", VA = "0x2C80978")]
	public InitCoinConfigInfo()
	{
	}
}
