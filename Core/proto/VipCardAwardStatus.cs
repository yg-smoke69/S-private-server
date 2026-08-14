using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001908")]
public class VipCardAwardStatus
{
	[Token(Token = "0x4009E96")]
	[FieldOffset(Offset = "0x8")]
	public uint day;

	[Token(Token = "0x4009E97")]
	[FieldOffset(Offset = "0xC")]
	public EVipCard.AwardStatus status;

	[Token(Token = "0x6007F61")]
	[Address(RVA = "0x33E4A3C", Offset = "0x33E4A3C", VA = "0x33E4A3C")]
	public VipCardAwardStatus()
	{
	}
}
