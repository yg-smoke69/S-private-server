using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001612")]
public class ActivityInfo
{
	[Token(Token = "0x40094F0")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x40094F1")]
	[FieldOffset(Offset = "0xC")]
	public uint data;

	[Token(Token = "0x40094F2")]
	[FieldOffset(Offset = "0x10")]
	public EActivity.State state;

	[Token(Token = "0x6007C5C")]
	[Address(RVA = "0x317A4B8", Offset = "0x317A4B8", VA = "0x317A4B8")]
	public ActivityInfo()
	{
	}
}
