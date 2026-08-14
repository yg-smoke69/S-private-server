using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200170E")]
public class CSGetEPDebrisIngameRes
{
	[Token(Token = "0x4009864")]
	[FieldOffset(Offset = "0x8")]
	public uint ep_debris_id;

	[Token(Token = "0x4009865")]
	[FieldOffset(Offset = "0xC")]
	public uint gained_game_ep_debris;

	[Token(Token = "0x4009866")]
	[FieldOffset(Offset = "0x10")]
	public uint gained_daily_ep_debris;

	[Token(Token = "0x6007D68")]
	[Address(RVA = "0x3184380", Offset = "0x3184380", VA = "0x3184380")]
	public CSGetEPDebrisIngameRes()
	{
	}
}
