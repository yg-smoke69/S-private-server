using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001415")]
public class ELobbyDisplay
{
	[Token(Token = "0x2001416")]
	public enum SlotType
	{
		[Token(Token = "0x4008C31")]
		SlotType_NONE,
		[Token(Token = "0x4008C32")]
		SlotType_GLOO_DISPLAY,
		[Token(Token = "0x4008C33")]
		SlotType_SKYBOARD_DISPLAY
	}

	[Token(Token = "0x6007ADD")]
	[Address(RVA = "0x309F328", Offset = "0x309F328", VA = "0x309F328")]
	public ELobbyDisplay()
	{
	}
}
