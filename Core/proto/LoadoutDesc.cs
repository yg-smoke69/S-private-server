using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019AB")]
public class LoadoutDesc
{
	[Token(Token = "0x400A0F5")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400A0F6")]
	[FieldOffset(Offset = "0xC")]
	public EInventory.LoadoutType type;

	[Token(Token = "0x400A0F7")]
	[FieldOffset(Offset = "0x10")]
	public uint play_card_id;

	[Token(Token = "0x6008002")]
	[Address(RVA = "0x30A6708", Offset = "0x30A6708", VA = "0x30A6708")]
	public LoadoutDesc()
	{
	}
}
