using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019A6")]
public class GameBagDesc
{
	[Token(Token = "0x400A0EC")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400A0ED")]
	[FieldOffset(Offset = "0xC")]
	public bool is_show;

	[Token(Token = "0x6007FFD")]
	[Address(RVA = "0x30A1814", Offset = "0x30A1814", VA = "0x30A1814")]
	public GameBagDesc()
	{
	}
}
