using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B99")]
public class WinterFest21BBuildMissionDesc
{
	[Token(Token = "0x400AD9A")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AD9B")]
	[FieldOffset(Offset = "0xC")]
	public string title;

	[Token(Token = "0x400AD9C")]
	[FieldOffset(Offset = "0x10")]
	public string desc;

	[Token(Token = "0x400AD9D")]
	[FieldOffset(Offset = "0x14")]
	public uint pre_mission_id;

	[Token(Token = "0x400AD9E")]
	[FieldOffset(Offset = "0x18")]
	public uint building_id;

	[Token(Token = "0x400AD9F")]
	[FieldOffset(Offset = "0x1C")]
	public uint unlock_level;

	[Token(Token = "0x400ADA0")]
	[FieldOffset(Offset = "0x20")]
	public List<AwardDesc> award;

	[Token(Token = "0x400ADA1")]
	[FieldOffset(Offset = "0x24")]
	public string target_cdn;

	[Token(Token = "0x60081F4")]
	[Address(RVA = "0x33E5888", Offset = "0x33E5888", VA = "0x33E5888")]
	public WinterFest21BBuildMissionDesc()
	{
	}
}
