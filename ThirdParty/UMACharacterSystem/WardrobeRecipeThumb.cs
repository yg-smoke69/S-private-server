using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UMACharacterSystem;

[Serializable]
[Token(Token = "0x2003CA1")]
public class WardrobeRecipeThumb
{
	[Token(Token = "0x4019C46")]
	[FieldOffset(Offset = "0x8")]
	public string race;

	[Token(Token = "0x4019C47")]
	[FieldOffset(Offset = "0xC")]
	public string filename;

	[Token(Token = "0x4019C48")]
	[FieldOffset(Offset = "0x10")]
	public Sprite thumb;

	[Token(Token = "0x6018405")]
	[Address(RVA = "0x2A59800", Offset = "0x2A59800", VA = "0x2A59800")]
	public WardrobeRecipeThumb()
	{
	}

	[Token(Token = "0x6018406")]
	[Address(RVA = "0x2A598AC", Offset = "0x2A598AC", VA = "0x2A598AC")]
	public WardrobeRecipeThumb(string n_race)
	{
	}

	[Token(Token = "0x6018407")]
	[Address(RVA = "0x2A59960", Offset = "0x2A59960", VA = "0x2A59960")]
	public WardrobeRecipeThumb(string n_race, Sprite n_thumb)
	{
	}
}
