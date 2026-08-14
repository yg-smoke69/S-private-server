using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200197B")]
public class CSGetRampage4BTowerSettingRes
{
	[Token(Token = "0x4009FE3")]
	[FieldOffset(Offset = "0x8")]
	public List<Rampage4BTowerDesc> rampage4b_tower;

	[Token(Token = "0x4009FE4")]
	[FieldOffset(Offset = "0xC")]
	public List<Rampage4BTowerStoryDesc> rampage4b_tower_story;

	[Token(Token = "0x4009FE5")]
	[FieldOffset(Offset = "0x10")]
	public Rampage4BTowerGoSettingShow tower_go_setting;

	[Token(Token = "0x4009FE6")]
	[FieldOffset(Offset = "0x14")]
	public List<Rampage4BTowerProgressSettingDesc> process_setting;

	[Token(Token = "0x4009FE7")]
	[FieldOffset(Offset = "0x18")]
	public List<Rampage4BTowerWeather> tower_weather;

	[Token(Token = "0x6007FD4")]
	[Address(RVA = "0x3094C94", Offset = "0x3094C94", VA = "0x3094C94")]
	public CSGetRampage4BTowerSettingRes()
	{
	}
}
