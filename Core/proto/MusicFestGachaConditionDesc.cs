using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BBF")]
public class MusicFestGachaConditionDesc
{
	[Token(Token = "0x400AEA7")]
	[FieldOffset(Offset = "0x8")]
	public uint num_mod;

	[Token(Token = "0x400AEA8")]
	[FieldOffset(Offset = "0xC")]
	public uint gacha_id;

	[Token(Token = "0x600821A")]
	[Address(RVA = "0x30A92EC", Offset = "0x30A92EC", VA = "0x30A92EC")]
	public MusicFestGachaConditionDesc()
	{
	}
}
