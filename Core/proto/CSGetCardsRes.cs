using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016F0")]
public class CSGetCardsRes
{
	[Token(Token = "0x40097FE")]
	[FieldOffset(Offset = "0x8")]
	public PVPCardInfo pvp_cards;

	[Token(Token = "0x40097FF")]
	[FieldOffset(Offset = "0xC")]
	public PVECardInfo pve_cards;

	[Token(Token = "0x6007D4A")]
	[Address(RVA = "0x3182CC8", Offset = "0x3182CC8", VA = "0x3182CC8")]
	public CSGetCardsRes()
	{
	}
}
