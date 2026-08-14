using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B14")]
public class ActivityModeDesc
{
	[Token(Token = "0x400AA3D")]
	[FieldOffset(Offset = "0x8")]
	public uint activity_id;

	[Token(Token = "0x400AA3E")]
	[FieldOffset(Offset = "0xC")]
	public uint game_mode;

	[Token(Token = "0x400AA3F")]
	[FieldOffset(Offset = "0x10")]
	public bool is_open;

	[Token(Token = "0x600816F")]
	[Address(RVA = "0x317A5A8", Offset = "0x317A5A8", VA = "0x317A5A8")]
	public ActivityModeDesc()
	{
	}
}
