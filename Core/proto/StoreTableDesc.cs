using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001749")]
public class StoreTableDesc
{
	[Token(Token = "0x40099CC")]
	[FieldOffset(Offset = "0x8")]
	public uint table_type;

	[Token(Token = "0x40099CD")]
	[FieldOffset(Offset = "0xC")]
	public string language;

	[Token(Token = "0x40099CE")]
	[FieldOffset(Offset = "0x10")]
	public string table_name;

	[Token(Token = "0x40099CF")]
	[FieldOffset(Offset = "0x14")]
	public uint mall_type;

	[Token(Token = "0x40099D0")]
	[FieldOffset(Offset = "0x18")]
	public uint sort_id;

	[Token(Token = "0x6007DA3")]
	[Address(RVA = "0x33E293C", Offset = "0x33E293C", VA = "0x33E293C")]
	public StoreTableDesc()
	{
	}
}
