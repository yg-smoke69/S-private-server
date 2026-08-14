using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001ACE")]
public class ItemIntimacyOverrideDesc
{
	[Token(Token = "0x400A8C3")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400A8C4")]
	[FieldOffset(Offset = "0xC")]
	public string item_name;

	[Token(Token = "0x400A8C5")]
	[FieldOffset(Offset = "0x10")]
	public uint item_intimacy_value;

	[Token(Token = "0x600812B")]
	[Address(RVA = "0x30A4064", Offset = "0x30A4064", VA = "0x30A4064")]
	public ItemIntimacyOverrideDesc()
	{
	}
}
