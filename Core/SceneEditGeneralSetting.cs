using COW;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001E02")]
public class SceneEditGeneralSetting : ScriptableObject
{
	[Token(Token = "0x400BE22")]
	[FieldOffset(Offset = "0xC")]
	public GeneralModeSetting GeneralModeSetting;

	[Token(Token = "0x400BE23")]
	[FieldOffset(Offset = "0x10")]
	public EndConditionSetting EndConditionSetting;

	[Token(Token = "0x6008F95")]
	[Address(RVA = "0x21C1070", Offset = "0x21C1070", VA = "0x21C1070")]
	public SceneEditGeneralSetting()
	{
	}
}
