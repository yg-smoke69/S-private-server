using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002FCB")]
public class Report_TraceRoute
{
	[Token(Token = "0x401231B")]
	[FieldOffset(Offset = "0x8")]
	public byte build_variant_type;

	[Token(Token = "0x401231C")]
	[FieldOffset(Offset = "0xC")]
	public string region;

	[Token(Token = "0x401231D")]
	[FieldOffset(Offset = "0x10")]
	public string country;

	[Token(Token = "0x401231E")]
	[FieldOffset(Offset = "0x14")]
	public string phone_carrier;

	[Token(Token = "0x401231F")]
	[FieldOffset(Offset = "0x18")]
	public string client_ip;

	[Token(Token = "0x4012320")]
	[FieldOffset(Offset = "0x1C")]
	public List<PingResult> ping_results;

	[Token(Token = "0x6013F89")]
	[Address(RVA = "0x2406BE0", Offset = "0x2406BE0", VA = "0x2406BE0")]
	public Report_TraceRoute()
	{
	}
}
