using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002F9A")]
public class ClanLuckyBagData
{
	[Token(Token = "0x4012265")]
	[FieldOffset(Offset = "0x8")]
	public uint Level;

	[Token(Token = "0x4012266")]
	[FieldOffset(Offset = "0xC")]
	public uint BigLuckyBag_Points;

	[Token(Token = "0x6013E5C")]
	[Address(RVA = "0x172B600", Offset = "0x172B600", VA = "0x172B600")]
	public ClanLuckyBagData()
	{
	}
}
