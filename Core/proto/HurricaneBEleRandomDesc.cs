using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BFB")]
public class HurricaneBEleRandomDesc
{
	[Token(Token = "0x400B021")]
	[FieldOffset(Offset = "0x8")]
	public uint level_id;

	[Token(Token = "0x400B022")]
	[FieldOffset(Offset = "0xC")]
	public List<HurricaneBRandomEle> elements;

	[Token(Token = "0x400B023")]
	[FieldOffset(Offset = "0x10")]
	public List<HurricaneBTarget> targets;

	[Token(Token = "0x400B024")]
	[FieldOffset(Offset = "0x14")]
	public uint steps_required_1;

	[Token(Token = "0x400B025")]
	[FieldOffset(Offset = "0x18")]
	public uint steps_required_2;

	[Token(Token = "0x400B026")]
	[FieldOffset(Offset = "0x1C")]
	public uint total_steps;

	[Token(Token = "0x6008256")]
	[Address(RVA = "0x30A32C4", Offset = "0x30A32C4", VA = "0x30A32C4")]
	public HurricaneBEleRandomDesc()
	{
	}
}
