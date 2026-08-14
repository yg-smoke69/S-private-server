using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013E9")]
public class GainedTrainingToken
{
	[Token(Token = "0x4008B78")]
	[FieldOffset(Offset = "0x8")]
	public uint token_id;

	[Token(Token = "0x4008B79")]
	[FieldOffset(Offset = "0xC")]
	public uint gained_cnt;

	[Token(Token = "0x4008B7A")]
	[FieldOffset(Offset = "0x10")]
	public int delta_cnt;

	[Token(Token = "0x6007ACA")]
	[Address(RVA = "0x30A180C", Offset = "0x30A180C", VA = "0x30A180C")]
	public GainedTrainingToken()
	{
	}
}
