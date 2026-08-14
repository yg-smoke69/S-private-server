using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AB8")]
public class SpecialStoreDesc
{
	[Token(Token = "0x400A833")]
	[FieldOffset(Offset = "0x8")]
	public EStore.PbwActivityType id;

	[Token(Token = "0x400A834")]
	[FieldOffset(Offset = "0xC")]
	public string activity_name;

	[Token(Token = "0x400A835")]
	[FieldOffset(Offset = "0x10")]
	public uint weight;

	[Token(Token = "0x400A836")]
	[FieldOffset(Offset = "0x14")]
	public string icon;

	[Token(Token = "0x6008115")]
	[Address(RVA = "0x33E256C", Offset = "0x33E256C", VA = "0x33E256C")]
	public SpecialStoreDesc()
	{
	}
}
