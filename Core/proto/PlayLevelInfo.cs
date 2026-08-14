using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015DB")]
public class PlayLevelInfo
{
	[Token(Token = "0x4009464")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x4009465")]
	[FieldOffset(Offset = "0xC")]
	public uint level;

	[Token(Token = "0x4009466")]
	[FieldOffset(Offset = "0x10")]
	public EStore.PayLevelInfoState state;

	[Token(Token = "0x6007C25")]
	[Address(RVA = "0x33DFF4C", Offset = "0x33DFF4C", VA = "0x33DFF4C")]
	public PlayLevelInfo()
	{
	}
}
