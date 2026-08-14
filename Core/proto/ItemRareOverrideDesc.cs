using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AE6")]
public class ItemRareOverrideDesc
{
	[Token(Token = "0x400A927")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400A928")]
	[FieldOffset(Offset = "0xC")]
	public uint rare;

	[Token(Token = "0x6008141")]
	[Address(RVA = "0x30A410C", Offset = "0x30A410C", VA = "0x30A410C")]
	public ItemRareOverrideDesc()
	{
	}
}
