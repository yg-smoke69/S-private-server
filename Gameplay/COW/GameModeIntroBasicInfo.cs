using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002757")]
public class GameModeIntroBasicInfo
{
	[Token(Token = "0x400F2ED")]
	[FieldOffset(Offset = "0x8")]
	public string ModeIcon;

	[Token(Token = "0x400F2EE")]
	[FieldOffset(Offset = "0xC")]
	public string Title;

	[Token(Token = "0x400F2EF")]
	[FieldOffset(Offset = "0x10")]
	public string Desc;

	[Token(Token = "0x600F060")]
	[Address(RVA = "0x1DD60F4", Offset = "0x1DD60F4", VA = "0x1DD60F4")]
	public GameModeIntroBasicInfo(string icon, string title, string desc)
	{
	}
}
