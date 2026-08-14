using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AA9")]
public class EnvWeatherPreset : ScriptableObject
{
	[Token(Token = "0x4005D44")]
	[FieldOffset(Offset = "0xC")]
	public EnvSkybox skybox;

	[Token(Token = "0x4005D45")]
	[FieldOffset(Offset = "0x10")]
	public EnvGlobalSetting setting;

	[Token(Token = "0x4005D46")]
	[FieldOffset(Offset = "0x14")]
	public EnvWeatherEffect effect;

	[Token(Token = "0x4005D47")]
	[FieldOffset(Offset = "0x18")]
	public EnvWeatherSound sound;

	[Token(Token = "0x600519D")]
	[Address(RVA = "0x320DA18", Offset = "0x320DA18", VA = "0x320DA18")]
	public EnvWeatherPreset()
	{
	}
}
