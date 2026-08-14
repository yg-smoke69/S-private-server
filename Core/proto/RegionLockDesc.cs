using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A01")]
public class RegionLockDesc
{
	[Token(Token = "0x400A31E")]
	[FieldOffset(Offset = "0x8")]
	public string region_server;

	[Token(Token = "0x400A31F")]
	[FieldOffset(Offset = "0xC")]
	public List<string> ip_regions;

	[Token(Token = "0x400A320")]
	[FieldOffset(Offset = "0x10")]
	public List<string> languages;

	[Token(Token = "0x400A321")]
	[FieldOffset(Offset = "0x18")]
	public long active_time;

	[Token(Token = "0x6008059")]
	[Address(RVA = "0x33E1410", Offset = "0x33E1410", VA = "0x33E1410")]
	public RegionLockDesc()
	{
	}
}
