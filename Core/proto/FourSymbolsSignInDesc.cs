using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BB8")]
public class FourSymbolsSignInDesc
{
	[Token(Token = "0x400AE7D")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AE7E")]
	[FieldOffset(Offset = "0xC")]
	public uint start_time;

	[Token(Token = "0x400AE7F")]
	[FieldOffset(Offset = "0x10")]
	public uint end_time;

	[Token(Token = "0x400AE80")]
	[FieldOffset(Offset = "0x14")]
	public uint[] weight;

	[Token(Token = "0x400AE81")]
	[FieldOffset(Offset = "0x18")]
	public List<AwardDesc> awards;

	[Token(Token = "0x6008213")]
	[Address(RVA = "0x30A114C", Offset = "0x30A114C", VA = "0x30A114C")]
	public FourSymbolsSignInDesc()
	{
	}
}
