using System.Collections.Generic;
using COW;
using Il2CppDummyDll;
using UnityEngine;
using message;

[Token(Token = "0x2001E04")]
public class SceneEditModeSelect : ScriptableObject
{
	[Token(Token = "0x400BE25")]
	[FieldOffset(Offset = "0xC")]
	public ToggleButtonGroupRuleSetting GameModeSelection;

	[Token(Token = "0x400BE26")]
	[FieldOffset(Offset = "0x10")]
	public List<uint> SupportedGameModes;

	[Token(Token = "0x400BE27")]
	[FieldOffset(Offset = "0x14")]
	public List<uint> SupportedGroupModes;

	[Token(Token = "0x400BE28")]
	[FieldOffset(Offset = "0x18")]
	public JOKABEAPNPP DefaultGameMode;

	[Token(Token = "0x400BE29")]
	[FieldOffset(Offset = "0x1C")]
	public HHDIPHFOBFO DefaultGroupMode;

	[Token(Token = "0x6008F97")]
	[Address(RVA = "0x21C1080", Offset = "0x21C1080", VA = "0x21C1080")]
	public SceneEditModeSelect()
	{
	}
}
