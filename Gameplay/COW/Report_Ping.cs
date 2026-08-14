using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002FCA")]
public class Report_Ping
{
	[Token(Token = "0x4012314")]
	[FieldOffset(Offset = "0x8")]
	public byte build_variant_type;

	[Token(Token = "0x4012315")]
	[FieldOffset(Offset = "0xC")]
	public string region;

	[Token(Token = "0x4012316")]
	[FieldOffset(Offset = "0x10")]
	public string country;

	[Token(Token = "0x4012317")]
	[FieldOffset(Offset = "0x14")]
	public string phone_carrier;

	[Token(Token = "0x4012318")]
	[FieldOffset(Offset = "0x18")]
	public string client_ip;

	[Token(Token = "0x4012319")]
	[FieldOffset(Offset = "0x1C")]
	public List<PingResult> ping_results;

	[Token(Token = "0x401231A")]
	[FieldOffset(Offset = "0x20")]
	public List<TracerouteResult> trace_results;

	[Token(Token = "0x6013F88")]
	[Address(RVA = "0x2406B18", Offset = "0x2406B18", VA = "0x2406B18")]
	public Report_Ping()
	{
	}
}
