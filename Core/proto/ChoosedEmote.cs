using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001411")]
public class ChoosedEmote
{
	[Token(Token = "0x4008C2A")]
	[FieldOffset(Offset = "0x8")]
	public uint slot_id;

	[Token(Token = "0x4008C2B")]
	[FieldOffset(Offset = "0xC")]
	public uint emote_id;

	[Token(Token = "0x6007AD9")]
	[Address(RVA = "0x309B774", Offset = "0x309B774", VA = "0x309B774")]
	public ChoosedEmote()
	{
	}
}
