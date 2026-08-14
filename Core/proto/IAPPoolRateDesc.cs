using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AB2")]
public class IAPPoolRateDesc
{
	[Token(Token = "0x400A7F4")]
	[FieldOffset(Offset = "0x8")]
	public uint bundle_pool_id;

	[Token(Token = "0x400A7F5")]
	[FieldOffset(Offset = "0xC")]
	public uint store_id;

	[Token(Token = "0x400A7F6")]
	[FieldOffset(Offset = "0x10")]
	public string store_name;

	[Token(Token = "0x400A7F7")]
	[FieldOffset(Offset = "0x14")]
	public float discount;

	[Token(Token = "0x400A7F8")]
	[FieldOffset(Offset = "0x18")]
	public uint weight;

	[Token(Token = "0x400A7F9")]
	[FieldOffset(Offset = "0x1C")]
	public bool is_default;

	[Token(Token = "0x400A7FA")]
	[FieldOffset(Offset = "0x20")]
	public string title;

	[Token(Token = "0x600810F")]
	[Address(RVA = "0x30A3A5C", Offset = "0x30A3A5C", VA = "0x30A3A5C")]
	public IAPPoolRateDesc()
	{
	}
}
