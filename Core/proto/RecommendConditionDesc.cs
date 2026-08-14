using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B82")]
public class RecommendConditionDesc
{
	[Token(Token = "0x400AD05")]
	[FieldOffset(Offset = "0x8")]
	public uint type;

	[Token(Token = "0x400AD06")]
	[FieldOffset(Offset = "0xC")]
	public uint default_weight;

	[Token(Token = "0x400AD07")]
	[FieldOffset(Offset = "0x10")]
	public uint algo_weight;

	[Token(Token = "0x400AD08")]
	[FieldOffset(Offset = "0x14")]
	public List<RecommendAlgo> algos;

	[Token(Token = "0x60081DD")]
	[Address(RVA = "0x33E10D4", Offset = "0x33E10D4", VA = "0x33E10D4")]
	public RecommendConditionDesc()
	{
	}
}
