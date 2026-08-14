using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001417")]
public class MaxLobbyDisplayInfo
{
	[Token(Token = "0x4008C34")]
	[FieldOffset(Offset = "0x8")]
	public uint[] weapon_ids;

	[Token(Token = "0x4008C35")]
	[FieldOffset(Offset = "0xC")]
	public uint vehicle_display;

	[Token(Token = "0x4008C36")]
	[FieldOffset(Offset = "0x10")]
	public uint gloo_display;

	[Token(Token = "0x4008C37")]
	[FieldOffset(Offset = "0x14")]
	public uint skyboard_display;

	[Token(Token = "0x6007ADE")]
	[Address(RVA = "0x30A86CC", Offset = "0x30A86CC", VA = "0x30A86CC")]
	public MaxLobbyDisplayInfo()
	{
	}
}
