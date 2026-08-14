using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001307")]
public class GameMissionInfo
{
	[Token(Token = "0x40086D4")]
	[FieldOffset(Offset = "0x8")]
	public uint mission_type;

	[Token(Token = "0x40086D5")]
	[FieldOffset(Offset = "0xC")]
	public uint get_times;

	[Token(Token = "0x40086D6")]
	[FieldOffset(Offset = "0x10")]
	public uint finish_times;

	[Token(Token = "0x40086D7")]
	[FieldOffset(Offset = "0x14")]
	public bool pre_cdt_triggered;

	[Token(Token = "0x6007A47")]
	[Address(RVA = "0x30A198C", Offset = "0x30A198C", VA = "0x30A198C")]
	public GameMissionInfo()
	{
	}
}
