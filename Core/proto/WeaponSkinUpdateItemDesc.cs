using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B47")]
public class WeaponSkinUpdateItemDesc
{
	[Token(Token = "0x400ABA1")]
	[FieldOffset(Offset = "0x8")]
	public EInventory.MaterialItemType item_type;

	[Token(Token = "0x400ABA2")]
	[FieldOffset(Offset = "0xC")]
	public uint item_id;

	[Token(Token = "0x400ABA3")]
	[FieldOffset(Offset = "0x10")]
	public uint item_num;

	[Token(Token = "0x60081A2")]
	[Address(RVA = "0x33E529C", Offset = "0x33E529C", VA = "0x33E529C")]
	public WeaponSkinUpdateItemDesc()
	{
	}
}
