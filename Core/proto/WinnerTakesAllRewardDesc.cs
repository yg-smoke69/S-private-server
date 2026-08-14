using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A6E")]
public class WinnerTakesAllRewardDesc
{
	[Token(Token = "0x400A57B")]
	[FieldOffset(Offset = "0x8")]
	public uint group_mode;

	[Token(Token = "0x400A57C")]
	[FieldOffset(Offset = "0xC")]
	public uint first_chip_num;

	[Token(Token = "0x400A57D")]
	[FieldOffset(Offset = "0x10")]
	public uint second_chip_num;

	[Token(Token = "0x400A57E")]
	[FieldOffset(Offset = "0x14")]
	public uint third_chip_num;

	[Token(Token = "0x60080CB")]
	[Address(RVA = "0x33E5880", Offset = "0x33E5880", VA = "0x33E5880")]
	public WinnerTakesAllRewardDesc()
	{
	}
}
