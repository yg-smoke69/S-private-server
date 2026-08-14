using System;
using Il2CppDummyDll;

namespace UMACharacterSystem;

[Serializable]
[Token(Token = "0x2003CA2")]
public class WardrobeSettings
{
	[Token(Token = "0x4019C49")]
	[FieldOffset(Offset = "0x8")]
	public string slot;

	[Token(Token = "0x4019C4A")]
	[FieldOffset(Offset = "0xC")]
	public string recipe;

	[Token(Token = "0x6018408")]
	[Address(RVA = "0x2A59B10", Offset = "0x2A59B10", VA = "0x2A59B10")]
	public WardrobeSettings()
	{
	}

	[Token(Token = "0x6018409")]
	[Address(RVA = "0x2A59B18", Offset = "0x2A59B18", VA = "0x2A59B18")]
	public WardrobeSettings(string _slot, string _recipe)
	{
	}
}
