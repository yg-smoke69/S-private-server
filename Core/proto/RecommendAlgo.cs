using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B84")]
public class RecommendAlgo
{
	[Token(Token = "0x400AD0B")]
	[FieldOffset(Offset = "0x8")]
	public string name;

	[Token(Token = "0x400AD0C")]
	[FieldOffset(Offset = "0xC")]
	public uint weight;

	[Token(Token = "0x60081DF")]
	[Address(RVA = "0x33E1034", Offset = "0x33E1034", VA = "0x33E1034")]
	public RecommendAlgo()
	{
	}
}
