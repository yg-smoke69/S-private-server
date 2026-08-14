using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C17")]
public class Rampage4BTowerWeather
{
	[Token(Token = "0x400B0CF")]
	[FieldOffset(Offset = "0x8")]
	public uint level;

	[Token(Token = "0x400B0D0")]
	[FieldOffset(Offset = "0xC")]
	public string weather_vfx;

	[Token(Token = "0x6008271")]
	[Address(RVA = "0x33E04B0", Offset = "0x33E04B0", VA = "0x33E04B0")]
	public Rampage4BTowerWeather()
	{
	}
}
