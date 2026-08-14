using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A43")]
public class AntiHackProtectSettingDesc
{
	[Token(Token = "0x400A476")]
	[FieldOffset(Offset = "0x8")]
	public bool gs_test_hack;

	[Token(Token = "0x400A477")]
	[FieldOffset(Offset = "0xC")]
	public uint cs_rank_reward;

	[Token(Token = "0x400A478")]
	[FieldOffset(Offset = "0x10")]
	public uint br_rank_reward;

	[Token(Token = "0x600809B")]
	[Address(RVA = "0x317AD70", Offset = "0x317AD70", VA = "0x317AD70")]
	public AntiHackProtectSettingDesc()
	{
	}
}
