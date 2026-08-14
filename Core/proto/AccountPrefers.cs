using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200136B")]
public class AccountPrefers
{
	[Token(Token = "0x4008946")]
	[FieldOffset(Offset = "0x8")]
	public bool hide_my_lobby;

	[Token(Token = "0x4008947")]
	[FieldOffset(Offset = "0xC")]
	public uint[] pregame_show_choices;

	[Token(Token = "0x6007A6C")]
	[Address(RVA = "0x3179AC0", Offset = "0x3179AC0", VA = "0x3179AC0")]
	public AccountPrefers()
	{
	}
}
