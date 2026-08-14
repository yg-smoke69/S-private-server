using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200189C")]
public class CSFFWS03SingleTrainRes
{
	[Token(Token = "0x4009D5B")]
	[FieldOffset(Offset = "0x8")]
	public uint level;

	[Token(Token = "0x4009D5C")]
	[FieldOffset(Offset = "0xC")]
	public uint experiences;

	[Token(Token = "0x4009D5D")]
	[FieldOffset(Offset = "0x10")]
	public uint trained_count_per_day;

	[Token(Token = "0x6007EF5")]
	[Address(RVA = "0x3180318", Offset = "0x3180318", VA = "0x3180318")]
	public CSFFWS03SingleTrainRes()
	{
	}
}
