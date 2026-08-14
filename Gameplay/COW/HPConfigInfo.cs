using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E1B")]
public class HPConfigInfo
{
	[Token(Token = "0x4011A57")]
	[FieldOffset(Offset = "0x8")]
	public uint Key;

	[Token(Token = "0x4011A58")]
	[FieldOffset(Offset = "0xC")]
	public string HP;

	[Token(Token = "0x60134D0")]
	[Address(RVA = "0x1213248", Offset = "0x1213248", VA = "0x1213248")]
	public HPConfigInfo()
	{
	}
}
