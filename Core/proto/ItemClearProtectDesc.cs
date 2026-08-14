using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019BE")]
public class ItemClearProtectDesc
{
	[Token(Token = "0x400A153")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A154")]
	[FieldOffset(Offset = "0xC")]
	public bool is_delete_invalid;

	[Token(Token = "0x400A155")]
	[FieldOffset(Offset = "0xD")]
	public bool is_item_id_delete_invalid;

	[Token(Token = "0x6008016")]
	[Address(RVA = "0x30A3F04", Offset = "0x30A3F04", VA = "0x30A3F04")]
	public ItemClearProtectDesc()
	{
	}
}
