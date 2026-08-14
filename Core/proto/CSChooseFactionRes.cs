using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017F1")]
public class CSChooseFactionRes
{
	[Token(Token = "0x4009BBC")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009BBD")]
	[FieldOffset(Offset = "0x10")]
	public ELimitedEvent.RampageFaction faction;

	[Token(Token = "0x6007E4B")]
	[Address(RVA = "0x317E2FC", Offset = "0x317E2FC", VA = "0x317E2FC")]
	public CSChooseFactionRes()
	{
	}
}
