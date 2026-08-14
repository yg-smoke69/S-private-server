using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UMACharacterSystem;

[Serializable]
[Token(Token = "0x2003CA3")]
public class WardrobeSet
{
	[Token(Token = "0x4019C4B")]
	[FieldOffset(Offset = "0x8")]
	public string targetRace;

	[Token(Token = "0x4019C4C")]
	[FieldOffset(Offset = "0xC")]
	public List<WardrobeSettings> wardrobeSet;

	[Token(Token = "0x601840A")]
	[Address(RVA = "0x2A59A3C", Offset = "0x2A59A3C", VA = "0x2A59A3C")]
	public WardrobeSet()
	{
	}

	[Token(Token = "0x601840B")]
	[Address(RVA = "0x2A58D54", Offset = "0x2A58D54", VA = "0x2A58D54")]
	public WardrobeSet(string race)
	{
	}

	[Token(Token = "0x601840C")]
	[Address(RVA = "0x2A58F04", Offset = "0x2A58F04", VA = "0x2A58F04")]
	public WardrobeSet(string race, List<WardrobeSettings> settings)
	{
	}
}
